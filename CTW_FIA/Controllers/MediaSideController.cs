using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.LocalModels;
using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    public class MediaSideController : Controller
    {
        private readonly IMediaFiles media;
        private readonly ICommonlinks commonlinks;
        public MediaSideController(IMediaFiles media, ICommonlinks commonlinks)
        {
            this.media = media;
            this.commonlinks = commonlinks;

        }
        [HttpGet]
        public IActionResult AddMedia(string Table="",string Strurn="")
        {
            ViewBag.Table = Table;
            ViewBag.Strurn = Strurn;
            return View();
        }
        [HttpPost]
        public IActionResult PostMedia(MediaDto mediaDto)
        {
            string mstrin = "";
            MediaFile md= new MediaFile();
            if (mediaDto.formFile != null)
            {
                md.FileName= media.AddFileIntoServer(mediaDto.formFile);
                md.Description = mediaDto.Descr;
                md.UpdatedBy = "Intial";
                md.IsDeleted = false;
                md.textSearch = "Intail insert";
                mstrin = media.AddMedia(md);
            }
            if (mediaDto.SourceTab != null)
            {
                commonlinks.CreateCommonlinks(mediaDto.strurn, mstrin, mediaDto.SourceTab, "tblMedia", "Direct link", mediaDto.SourceTab);
            }

            return RedirectToAction("AddMedia","MediaSide");
        }
    }
}
