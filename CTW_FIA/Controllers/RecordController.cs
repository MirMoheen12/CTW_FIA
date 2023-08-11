using CTW_FIA.Interface;
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
        private readonly ICommonlinks commonlinks;
        private readonly ConverterModel converterModel;

        private readonly ITerrorist terrorist;
        private readonly IIncident incident;
        private readonly IExplosive explosive;
        private readonly IVehicle vehicle;
        private readonly IPowerSource powerSource;
        private readonly ICommunication communication;
        private readonly IOrdinance ordinance;
        private readonly IEquipments equipments;
        private readonly IIntianSystem intianSystem;
        private readonly IComponents components;
        private readonly ICBRN cBRN;
        private readonly IFearams fearams;
        private readonly Ichemical chemical;
        private readonly IDetonators detonators;
        public RecordController(
        IRecord record,
        ICommonlinks commonlinks,
        ConverterModel converterModel,
        ITerrorist terrorist,
        IIncident incident,
        IExplosive explosive,
        IVehicle vehicle,
        IPowerSource powerSource,
        ICommunication communication,
        IOrdinance ordinance,
        IEquipments equipments,
        IIntianSystem intianSystem,
        IComponents components,
        ICBRN cBRN,
        IFearams fearams,
        Ichemical chemical,
        IDetonators detonators)
        {
            this.record = record;
            this.commonlinks = commonlinks;
            this.converterModel = converterModel;
            this.terrorist = terrorist;
            this.incident = incident;
            this.explosive = explosive;
            this.vehicle = vehicle;
            this.powerSource = powerSource;
            this.communication = communication;
            this.ordinance = ordinance;
            this.equipments = equipments;
            this.intianSystem = intianSystem;
            this.components = components;
            this.cBRN = cBRN;
            this.fearams = fearams;
            this.chemical = chemical;
            this.detonators = detonators;
        }

        public IActionResult AddRecord(string pagname = "All", string pagestatus = "New")
        {
            ViewBag.pagename = pagname;
            ViewBag.pagstatus = pagestatus;
            return View();
        }
        public IActionResult RecordDetails(string STRUN, string modelname)
        {
            List<DisplayModel> lis = new List<DisplayModel>();
            switch (modelname)
            {
                case "Person":
                    {

                        var dat = terrorist.GetPeronByID(STRUN);
                        lis = converterModel.getModel(dat);
                        break;
                    }
                case "Incident":
                    {
                        var dat = incident.getIncidentID(STRUN);
                        lis = converterModel.getModel(dat);
                        break;
                    }
                case "Terrorist Groups":
                    {
                        var dat = terrorist.GetGroupsByStrurn(STRUN);
                        lis = converterModel.getModel(dat);
                        break;
                    }
                case "Explosives":
                    {
                        var dat = explosive.GetExplosiveByStrurn(STRUN);
                        lis = converterModel.getModel(dat);
                        break;
                    }
                case "Vehicles":
                    {
                        var dat = vehicle.GetVehcileByStrurn(STRUN);
                        lis = converterModel.getModel(dat);
                        break;
                    }
                case "Power Source":
                    {
                        var dat = powerSource.GetPowerSourceByStrurn(STRUN);
                        lis = converterModel.getModel(dat);
                        break;
                    }
                case "Communication":
                    {
                        var dat = communication.GetCommunicationByStrurn(STRUN);
                        lis = converterModel.getModel(dat);
                        break;
                    }
                case "Ordinance":
                    {
                        var dat = ordinance.OrdinanceDetails(STRUN);
                        lis = converterModel.getModel(dat);
                        break;
                    }
                case "Equipment":
                    {
                        var dat = equipments.GetEquByStrurn(STRUN);
                        lis = converterModel.getModel(dat);
                        break;
                    }
                case "Initiation System":
                    {
                        var dat = intianSystem.GetIntianDystmByStrurn(STRUN);
                        lis = converterModel.getModel(dat);
                        break;
                    }
                case "Components":
                    {
                        var dat = components.GetComponByStrurn(STRUN);
                        lis = converterModel.getModel(dat);
                        break;
                    }
                case "CBRN":
                    {
                        var dat = cBRN.getCBRNByStrurn(STRUN);
                        lis = converterModel.getModel(dat);
                        break;
                    }
                case "Firearms":
                    {
                        var dat = fearams.GetFiremsByStrurn(STRUN);
                        lis = converterModel.getModel(dat);
                        break;
                    }
                case "Chemicals":
                    {
                        var dat = chemical.ChemicalByStrurn(STRUN);
                        lis = converterModel.getModel(dat);
                        break;
                    }
                case "Detonators":
                    {
                        var dat = detonators.GetDetonatorsByStrurn(STRUN);
                        lis = converterModel.getModel(dat);
                        break;
                    }
                default:
                    break;
            }
            ViewData["Title"] = modelname;
            ViewBag.link = commonlinks.getAlllinksCount(STRUN);

            return View(lis);
        }







        public IActionResult Delete(string STRUN, string modelname)
        {
            List<DisplayModel> lis = new List<DisplayModel>();
            switch (modelname)
            {
                case "Person":
                    {

                        var dat = terrorist.Delete(STRUN);
                        lis = converterModel.getModel(dat);
                        break;
                    }
                case "Incident":
                    {
                        var dat = incident.getIncidentID(STRUN);
                        lis = converterModel.getModel(dat);
                        break;
                    }
                case "Terrorist Groups":
                    {
                        var dat = terrorist.GetGroupsByStrurn(STRUN);
                        lis = converterModel.getModel(dat);
                        break;
                    }
                case "Explosives":
                    {
                        var dat = explosive.GetExplosiveByStrurn(STRUN);
                        lis = converterModel.getModel(dat);
                        break;
                    }
                case "Vehicles":
                    {
                        var dat = vehicle.GetVehcileByStrurn(STRUN);
                        lis = converterModel.getModel(dat);
                        break;
                    }
                case "Power Source":
                    {
                        var dat = powerSource.GetPowerSourceByStrurn(STRUN);
                        lis = converterModel.getModel(dat);
                        break;
                    }
                case "Communication":
                    {
                        var dat = communication.GetCommunicationByStrurn(STRUN);
                        lis = converterModel.getModel(dat);
                        break;
                    }
                case "Ordinance":
                    {
                        var dat = ordinance.OrdinanceDetails(STRUN);
                        lis = converterModel.getModel(dat);
                        break;
                    }
                case "Equipment":
                    {
                        var dat = equipments.GetEquByStrurn(STRUN);
                        lis = converterModel.getModel(dat);
                        break;
                    }
                case "Initiation System":
                    {
                        var dat = intianSystem.GetIntianDystmByStrurn(STRUN);
                        lis = converterModel.getModel(dat);
                        break;
                    }
                case "Components":
                    {
                        var dat = components.GetComponByStrurn(STRUN);
                        lis = converterModel.getModel(dat);
                        break;
                    }
                case "CBRN":
                    {
                        var dat = cBRN.getCBRNByStrurn(STRUN);
                        lis = converterModel.getModel(dat);
                        break;
                    }
                case "Firearms":
                    {
                        var dat = fearams.GetFiremsByStrurn(STRUN);
                        lis = converterModel.getModel(dat);
                        break;
                    }
                case "Chemicals":
                    {
                        var dat = chemical.ChemicalByStrurn(STRUN);
                        lis = converterModel.getModel(dat);
                        break;
                    }
                case "Detonators":
                    {
                        var dat = detonators.GetDetonatorsByStrurn(STRUN);
                        lis = converterModel.getModel(dat);
                        break;
                    }
                default:
                    break;
            }
            ViewData["Title"] = modelname;
            ViewBag.link = commonlinks.getAlllinksCount(STRUN);

            return View(lis);
        }

    }

}

