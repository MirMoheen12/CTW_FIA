﻿using CTW_FIA.Interface;
using CTW_FIA.Models;
using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.LocalModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace CTW_FIA.Controllers
{
    [AllowAnonymous]
    public class RecordController : Controller
    {
        private readonly IRecord record;
        private readonly ITerrorist terrorist;
        private readonly ICommonlinks commonlinks;
        private readonly ConverterModel converterModel;
        public RecordController(IRecord record, ICommonlinks commonlinks, ConverterModel converterModel,ITerrorist terrorist) { 
        
            this.record = record;
            this.commonlinks = commonlinks;
            this.terrorist = terrorist;
            this.converterModel = converterModel;
        }


        public IActionResult AddRecord(string pagname="All",string pagestatus="New")
        {
            ViewBag.pagename = pagname;
            ViewBag.pagstatus = pagestatus;
            return View();
        }
        public IActionResult RecordDetails(string STRUN,string modelname)
        {
            List<DisplayModel> lis = new List<DisplayModel>();
            switch (modelname)
            {
                case "Person":
                    {
                        var dat=terrorist.GetPeronByID(STRUN);
                        lis = converterModel.getModel(dat);
                        break;
                    }
                default:
                    break;
            }
            ViewBag.link = commonlinks.getAlllinksCount(STRUN);
        
            return View(lis);
        }

    }

}

