using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace Core.Interfaces
{
    public interface IFileService
    {
        void UploadFile(string folderName, IFormFile file, string fileName);
        // void CreateFile(string dir, string name, string content);
        void RemoveFile(string filePath);
        // string ReadFile(string path);
        ICollection<string> GetFilesInFolder(string folderPath);

    }
}