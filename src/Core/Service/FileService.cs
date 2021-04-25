using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Core.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

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

        public void RemoveFile(string folderPath, string fileNameDel)
        {
            string dir = Path.Combine(webRootPath, folderPath);
            var re = Directory.GetFiles(dir);
            if (re == null) return;
            for (int i = 0; i < re.Length; i++)
            {
                var fileName = re[i].Split("/").Last();
                if (fileName == fileNameDel)
                {
                    File.Delete(re[i]);
                    break;
                }
            }
        }

        public async Task UploadFileAsync(string folderPath, IFormFile file, string fileName)
        {
            try
            {
                //Check folder
                string dir = _checkFolderExsistOrCreate(folderPath);
                //Save file
                string filePath = Path.Combine(dir, fileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                    await file.CopyToAsync(fileStream);
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, ex, "Upload file " + folderPath);
                throw new Exception("Can't upload image");
            }
        }

        public bool CheckFileExsist(string folderPath, string fileName)
        {
            string dir = _checkFolderExsistOrCreate(folderPath);
            string filePath = Path.Combine(dir, fileName);
            return File.Exists(filePath);
        }

        private string _checkFolderExsistOrCreate(string dir)
        {
            string folderPath = Path.Combine(webRootPath, dir);
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);
            return folderPath;
        }
    }
}