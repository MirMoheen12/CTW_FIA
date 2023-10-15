using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;

namespace CTW_FIA.Repositories
{
    public class MediaRepository : IMediaFiles
    {
        private readonly IDatabaseRepo databaseRepo;
      
        private readonly AppDbContext dbContext;

        public MediaRepository(IDatabaseRepo databaseRepo, AppDbContext dbContext)
        {
            this.databaseRepo = databaseRepo;
     
            this.dbContext = dbContext;
      
        }

		//public string AddFileIntoServer(IFormFile Files)
		//{
		//	string fileName = Guid.NewGuid().ToString();
		//	string fileexten = Path.GetExtension(Files.FileName);
		//	fileName = fileName + fileexten;
		//	var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\AllMedia\", fileName);
		//	using (FileStream stream = new FileStream(filePath, FileMode.Create))
		//	{
		//		Files.CopyTo(stream);

		//	}
		//	return fileName;
		//}
		public string AddFileIntoServer(IFormFile Files)
		{
			try
			{
				string fileName = Guid.NewGuid().ToString();
				string fileexten = Path.GetExtension(Files.FileName);
				fileName = fileName + fileexten;

				// Replace this with the UNC path to your server folder
				string serverFolderPath = @"\\10.1.3.24\media";
				string filePath = Path.Combine(serverFolderPath, fileName);

				using (FileStream stream = new FileStream(filePath, FileMode.Create))
				{
					Files.CopyTo(stream);
				}

				// Return the file name or full UNC path if needed
				return fileName;
			}
			catch (Exception ex)
			{
				// Handle any exceptions that may occur during the file upload process
				return null;
			}
		}

		public string AddMedia(MediaFile mediaFile )
        {
            try
            {
                mediaFile.strURN = databaseRepo.ExecuteProc("GetMediaSTRURN", null).Rows[0][0].ToString();
                mediaFile.CreatedOn = DateTime.Now;
                dbContext.MediaFile.Add(mediaFile);
                dbContext.SaveChanges();
                return mediaFile.strURN;
            }
            catch (Exception)
            {
                return null;
            }
            
        }

        public string AddMedia(tblMedia tblMedia)
        {
            throw new NotImplementedException();
        }
    }
}
