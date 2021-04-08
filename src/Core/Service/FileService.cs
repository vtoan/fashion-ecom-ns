using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Core.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Core.Service
{
    public class FileService : IFileService
    {
        private string webRootPath = "";
        private ILogger _logger;
        public FileService(IWebHostEnvironment environment, ILogger<string> logger)
        {
            _logger = logger;
            webRootPath = environment.WebRootPath;
        }

        public ICollection<string> GetFilesInFolder(string folderPath)
        {
            var listImage = new List<string>();
            string dir = Path.Combine(webRootPath, folderPath);
            if (!Directory.Exists(dir)) return listImage;
            var re = Directory.GetFiles(dir);
            foreach (var item in re)
                listImage.Add(item.Split("/").Last());
            return listImage;
        }

        public void RemoveFile(string filePath)
        {
            throw new NotImplementedException();
        }

        public void UploadFile(string folderName, IFormFile file, string fileName)
        {
            try
            {
                //Check folder
                string dir = _checkExsistOrCreate(folderName);
                //Save file
                string filePath = Path.Combine(dir, fileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                    file.CopyTo(fileStream);
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, ex, "Upload file " + folderName);
                throw new Exception("Can't upload image");
            }
        }

        private string _checkExsistOrCreate(string dir)
        {
            string folderPath = Path.Combine(webRootPath, dir);
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);
            return folderPath;
        }

        // public void CreateFile(string dir, string name, string content)
        // {
        //     try
        //     {
        //         string folderPath = _checkPath(dir);
        //         string filePath = Path.Combine(folderPath, name);
        //         using (FileStream fs = File.Create(filePath))
        //         {
        //             byte[] info = new UTF8Encoding(true).GetBytes(content);
        //             // Add some information to the file.
        //             fs.Write(info, 0, info.Length);
        //         }
        //     }
        //     catch (Exception ex)
        //     {
        //         _logger.Log(LogLevel.Error, ex, "Create file " + dir);
        //     }
        // }

        // public string ReadFile(string path)
        // {
        //     try
        //     {
        //         var task = System.IO.File.ReadAllTextAsync(path);
        //         task.Start();
        //         task.Wait();
        //         return task.Result;
        //     }
        //     catch (Exception ex)
        //     {
        //         _logger.Log(LogLevel.Error, ex, "Red file " + path);
        //         return null;
        //     }
        // }

    }
}