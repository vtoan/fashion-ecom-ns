using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Core.Interfaces
{
    public interface IFileService
    {
        Task UploadFileAsync(string folderName, IFormFile file, string fileName);
        // void CreateFile(string dir, string name, string content);
        void RemoveFile(string folderPath, string fileNameDel);
        // string ReadFile(string path);
        ICollection<string> GetFilesInFolder(string folderPath);

    }
}