namespace AkademiFarmasiYPF.Helper
{
    public class UploadImageHelper
    {
        public static string UploadImage(IFormFile fileImage, string url)
        {
            if (fileImage != null)
            {
                string fileName = Guid.NewGuid().ToString() + Path.GetExtension(fileImage.FileName);
                string path = Path.Combine(url, fileName);
                using (var stream = File.Create(path))
                {
                    fileImage.CopyTo(stream);
                }
                return fileName;
            }
            return string.Empty;
        }
    }
}
