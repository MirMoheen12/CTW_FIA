using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Interface;
using CTW_FIA.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddIdentity<IdentityUser, IdentityRole>().

                AddDefaultTokenProviders().
             AddEntityFrameworkStores<AppDbContext>();
builder.Services.AddControllersWithViews(opt => {

    var policy = new AuthorizationPolicyBuilder()
               .RequireAuthenticatedUser().Build();
    opt.Filters.Add(new AuthorizeFilter(policy));
    opt.Filters.Add(new RequestSizeLimitAttribute(100 * 1024 * 1024)); // 100MB

});
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
    sqlServerOptionsAction: sqlOptions =>
    {
        sqlOptions.EnableRetryOnFailure();
    });
});
builder.Services.ConfigureApplicationCookie(options =>
{
    options.AccessDeniedPath = new PathString("/Home/Accessdenied");
});





builder.Services.AddTransient<IDashboard, DashboardReopsitories>();









builder.Services.AddRazorPages()
    .AddRazorRuntimeCompilation();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/UniversalError");
    //app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    //app.UseHsts();
    //app.UseStatusCodePagesWithReExecute("/Home/UniversalError", "?statusCode={0}");
}
else
{
    app.UseExceptionHandler("/Home/UniversalError");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
