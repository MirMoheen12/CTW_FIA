using CTW_FIA.Models.DatabaseModels;

namespace CTW_FIA.Interface
{
    public interface IMediaFiles
    {
       public string AddMedia(MediaFile mediaFile);
        public string AddFileIntoServer(IFormFile Files);
    }
}
