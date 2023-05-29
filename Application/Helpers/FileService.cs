using System;
namespace Application.Helpers
{
	public class FileService
	{
        public static byte[] FileConvertByteArrayToDatabase(IFormFile file)
        {
            using (var memoryStream = new MemoryStream())
            {
                file.CopyTo(memoryStream);
                var fileBytes = memoryStream.ToArray();
                string fileString = Convert.ToBase64String(fileBytes);
                return fileBytes;
            }
        }
        public static string ConvertIFormFileToBase64(string format,IFormFile file)
        {
            using (var memoryStream = new MemoryStream())
            {
                file.CopyTo(memoryStream);
                var fileBytes = memoryStream.ToArray();
                string fileString = Convert.ToBase64String(fileBytes);
                string baseFormat = "";
                switch (format)
                {
                    case "jpg":
                        baseFormat = "data:image/jpeg;base64,";
                        break;
                    default:
                        break;

                }

                string base64Format = baseFormat + Convert.ToBase64String(fileBytes);
                return base64Format;
            }
        }
    }
}

