using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Core.Interfaces
{
    public interface IFileService
    {
        Task UploadFileAsync(string folderName, IFormFile file, string fileName);
        void RemoveFile(string folderPath, string fileNameDel);
        ICollection<string> GetFilesInFolder(string folderPath);
        bool CheckFileExsist(string folderPath, string fileName);

    }
}