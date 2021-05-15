using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PixelartCreator.Infrastructure
{
    public interface IFileService
    {
        Task<string> UploadImageAsync(FileUploadModel model);
        ImageInfoModel GetImageInfo(string fileName);
    }
}
