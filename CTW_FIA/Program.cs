using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Microsoft.IdentityModel.Tokens;

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using EasyData;
using EasyData.Export;

using Korzh.EasyQuery.Services;
using Korzh.EasyQuery.Db;
using System.Net;

using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models;
using CTW_FIA.Repositories;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllersWithViews();
ConfigurationManager configuration = builder.Configuration;


builder.Services.AddDbContext<AppDbContext>(options =>
               options.UseSqlServer(
                   configuration.GetConnectionString("DefaultConnection")));

builder.Services.Configure<CookiePolicyOptions>(options =>
{
    options.CheckConsentNeeded = context => true;
    options.MinimumSameSitePolicy = SameSiteMode.None;
});
builder.Services.ConfigureApplicationCookie(options =>
{
    options.AccessDeniedPath = new PathString("/Home/Accessdenied");
});
builder.Services.AddTransient<IStoredProcedure, StoredProcedureRepo>();
builder.Services.AddTransient<IDashboard, DashboardReopsitories>();
builder.Services.AddTransient<IRecord, RecordReopsitorie>();
builder.Services.AddTransient<IUser, UserReopsitorie>();
builder.Services.AddTransient<IIncident, IncidentRepo>();
builder.Services.AddTransient<IDatabaseRepo, DatabaseRepo>();
builder.Services.AddTransient<ITerrorist, Terroristrepo>();
builder.Services.AddTransient<IExplosive, ExplosiveRepo>();
builder.Services.AddTransient<IVehicle, VehicleRepo>();
builder.Services.AddTransient<IPowerSource, PowerSourceRepo>();
builder.Services.AddTransient<ICommunication, CommunicationRepo>();
builder.Services.AddTransient<IOrdinance, OrdinanceRepo>();
builder.Services.AddTransient<IEvidence, EvidenceRepo>();
builder.Services.AddTransient<IEquipments, Equipemtsrepo>();
builder.Services.AddTransient<IIntianSystem, IntiasSystemRepo>();
builder.Services.AddTransient<IComponents, Componentsrepo>();
builder.Services.AddTransient<ICBRN, CBRNRepo>();
builder.Services.AddTransient<IFearams, FireamsRepo>();
builder.Services.AddTransient<Ichemical, chemicalrepo>();
builder.Services.AddTransient<IDetonators, Detanatorsrepo>();
builder.Services.AddTransient<ICommonlinks, CommonlinksRepo>();
builder.Services.AddTransient<IAddress, AddressRepo>();
builder.Services.AddTransient<IMediaFiles, MediaRepository>();
builder.Services.AddTransient<IJson, JsonRepo>();
builder.Services.AddTransient<IQuickSearch, QuickSearchRepo>();
builder.Services.AddTransient<ConverterModel>();
builder.Services.AddIdentity<IdentityUser, IdentityRole>(
    options => options.SignIn.RequireConfirmedAccount = true)
    .AddSignInManager<SignInManager<IdentityUser>>()
        .AddEntityFrameworkStores<AppDbContext>()
        .AddDefaultTokenProviders(); builder.Services.AddControllersWithViews();

builder.Services.AddControllersWithViews()
    .AddRazorRuntimeCompilation();
Korzh.EasyQuery.RazorUI.Pages.AdvancedSearch.ExportFormats = new string[] { "pdf", "excel", "excel-html", "csv" };
Korzh.EasyQuery.AspNetCore.License.Key = "EksmHUuVlrv1Qwql5804aOcGxQdlgln0gBdj7_r-PQoDJU7E7X7JXW8";
Korzh.EasyQuery.AspNetCore.JSLicense.Key = "L4j0KV-B4Vw_OTPfeZas-ksnAqhv1njX-Mvk5raa_Y4BBJ5E74WJ8W8";
builder.Services.AddEasyQuery()
               .UseSqlManager()
               .AddDefaultExporters()
               .RegisterDbGate<Korzh.EasyQuery.DbGates.SqlClientGate>();
builder.Services.AddRazorPages();
builder.Services.ConfigureApplicationCookie(options =>
{
    // Cookie settings
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan = TimeSpan.FromMinutes(472);

    options.LoginPath = "/Identity/Account/Login";
    options.AccessDeniedPath = "/Identity/Account/AccessDenied";
    options.SlidingExpiration = true;
});
builder.Services.AddAuthorization(options =>
{
    var defaultAuthorizationPolicyBuilder = new AuthorizationPolicyBuilder(CookieAuthenticationDefaults.AuthenticationScheme);
    defaultAuthorizationPolicyBuilder = defaultAuthorizationPolicyBuilder.RequireAuthenticatedUser();
    options.DefaultPolicy = defaultAuthorizationPolicyBuilder.Build();
});
builder.Services.Configure<ForwardedHeadersOptions>(options =>
{
    options.ForwardedHeaders =
        ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto;
});
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    Configure(app);
    //app.UseMigrationsEndPoint();
    app.UseForwardedHeaders();
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
    //app.Urls.Add("https://localhost:5070");
    app.UseForwardedHeaders();
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.

}
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.UseEasyQuery(options => {
    options.Endpoint = "/api/easyquery";
    options.UseDbContext<AppDbContext>();
});
app.UseEndpoints(endpoints =>
{
    endpoints.MapEasyQuery(options => {
        options.DefaultModelId = "nwind";
        options.BuildQueryOnSync = true;
        options.SaveNewQuery = false;
        options.ConnectionString = configuration.GetConnectionString("DefaultConnection");
        options.UseDbContext<AppDbContext>();

        // If you want to load model directly from DB metadata
        // remove (or comment) options.UseDbContext(...) call and uncomment the next 3 lines of code
        //options.ConnectionString = Configuration.GetConnectionString("EqDemoDb");
        //options.UseDbConnection<Microsoft.Data.SqlClient.SqlConnection>();
        //options.UseDbConnectionModelLoader();

        options.UseQueryStore((_) => new FileQueryStore("App_Data"));

        //options.UseModelTuner(manager => {
        //    var attr = manager.Model.FindEntityAttr("Order.ShipRegion");
        //    attr.Operations.RemoveByIDs(manager.Model, "StartsWith,Contains");
        //    attr.DefaultEditor = new CustomListValueEditor("Lookup", "Lookup");
        //});

        options.UseSqlFormats(FormatType.MsSqlServer, formats => {
            formats.UseDbName = true;
            formats.UseSchema = true;
        });
    });
    endpoints.MapControllerRoute(
        name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}");
});
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Dashboard}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();


void Configure(WebApplication host)
{
    using var scope = host.Services.CreateScope();
    var services = scope.ServiceProvider;

    try
    {
        var dbContext = services.GetRequiredService<AppDbContext>();

        //if (dbContext.Database.IsSqlServer())
        //{
        //    dbContext.Database.Migrate();
        //}

        var userManager = services.GetRequiredService<UserManager<IdentityUser>>();
        var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
 

    }
    catch (Exception ex)
    {
        //Log some error
        throw;
    }
}
