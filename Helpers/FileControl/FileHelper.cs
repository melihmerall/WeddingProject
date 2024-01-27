namespace WeddingProject.Helpers.FileControl
{
    public class FileHelper
    {
        public static string UploadedFile(IWebHostEnvironment webHostEnvironment, IFormFile formFile, string folderName)
        {
            string uniqueFileName = null;
			string imageName = GenerateRandomString(10);
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, $"Imagess/{folderName}");

                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }

                uniqueFileName = imageName + "_" + "wedding" + Path.GetExtension(formFile.FileName);
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    formFile.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
        public static string DeleteImageFromFile(IWebHostEnvironment webHostEnvironment, string folderName, string ImagePath)
        {
            // write delete method for image. 
            if (folderName != null)
            {
                string ExitingFile = Path.Combine(webHostEnvironment.WebRootPath, $"Imagess/{folderName}/{ImagePath}");
                File.Delete(ExitingFile);
                return true.ToString();
            }
            return false.ToString();

        }
		static string GenerateRandomString(int length)
		{
			// Rastgele karakterlerin bulunduğu bir karakter dizisi
			const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

			// Random sınıfı
			Random random = new Random();

			// StringBuilder nesnesi kullanarak rastgele karakterleri birleştirme
			char[] randomArray = new char[length];
			for (int i = 0; i < length; i++)
			{
				randomArray[i] = chars[random.Next(chars.Length)];
			}

			return new string(randomArray);
		}
	}
}
