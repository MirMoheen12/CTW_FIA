﻿using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;

namespace CTW_FIA.Interface
{
    public interface IIncident
    {
        public List<PreviewIncident> getIncidentProvincewiese(string Province);
        public PreviewIncidentByStrUrn getIncidentID(string STRURN);
        public bool AddNewIncident(Incident incident);
        void DeleteIncident(string sTRUN);
        public Incident GetEditIncident(string sTRUN);
        public void PostEditIncident(Incident i);
    
    }
}
