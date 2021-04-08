using System.IO;

namespace PixelartCreator.Infrastructure
{
    public class FileUploadModel
    {
        public string OldName { get; set; }
        public Stream Stream { get; set; }
    }
}