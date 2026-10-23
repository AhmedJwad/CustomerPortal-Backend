namespace CustomerPortal.Backend.Helpers
{
    public class FileStorage : IFileStorage
    {
        public async Task RemoveFileAsync(string path, string containerName)
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), path);

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        public async Task<string> SaveFileAsync(byte[] content, string extention, string containerName)
        {
            try
            {
                string fileName = $"{Guid.NewGuid()}{extention}";
                string directory = Path.Combine(Directory.GetCurrentDirectory(), "images", containerName);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                string path = Path.Combine(directory, fileName);
                await File.WriteAllBytesAsync(path, content);
                return $"Images/{containerName}/{fileName}";
            }
            catch
            {

                return string.Empty;
            }
        }
    }
}
