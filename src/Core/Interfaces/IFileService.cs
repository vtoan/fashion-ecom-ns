using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace Core.Interfaces
{
    public interface IFileService
    {
        bool UploadFile(string folderName, IFormFile file, string fileName);
        // void CreateFile(string dir, string name, string content);
        bool RemoveFile(string filePath);
        // string ReadFile(string path);
        ICollection<string> GetFilesInFolder(string folderPath);

    }
}