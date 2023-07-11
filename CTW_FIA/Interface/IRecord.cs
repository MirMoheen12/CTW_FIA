using CTW_FIA.Models.DatabaseModels;

namespace CTW_FIA.Interface
{
    public interface IRecord
    {

        List<DistrictDatas> GetFirstDistrictDataPerCountry();

    }
}
