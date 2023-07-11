using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;

namespace CTW_FIA.Repositories
{
    public class RecordReopsitorie : IRecord
    {
        private readonly AppDbContext _context;

        public RecordReopsitorie(AppDbContext context)
        {
            _context = context;
        }

        public List<DistrictDatas> GetFirstDistrictDataPerCountry()
        {
            var districtData = _context.DistrictDatas
                .GroupBy(x => x.Country)
                .Select(x => x.FirstOrDefault()).ToList();

            return districtData;
        }


    }
}
