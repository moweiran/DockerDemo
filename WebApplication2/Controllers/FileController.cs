using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.Configuration;
using Microsoft.Net.Http.Headers;
using System;
using System.IO;
using System.Linq;

namespace WebApplication2.Controllers
{
    public class FileController : Controller
    {
        private IConfiguration configuration;
        public FileController(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        public class WSFileInfo
        {
            public string MimeType { get; set; }
            public byte[] Bytes { get; set; }
            public string FileName { get; set; }
            public string ETag { get; set; }
            public string ThumbETag { get; set; }
        }
        [HttpGet]
        [Route("File/Image/Single/{name}")]
        public IActionResult Image(string name)
        {
            string filePath = Path.Combine(configuration.GetSection("FileRootPath").Value, "NewsCoverImage", name);
            string fileExt = Path.GetExtension(name);
            var file = new WSFileInfo();
            file.FileName = name;
            file.Bytes = System.IO.File.ReadAllBytes(filePath);
            var provider = new FileExtensionContentTypeProvider();
            file.MimeType = provider.Mappings[fileExt];
            return File(file.Bytes, file.MimeType, file.FileName);
        }

        [HttpPost]
        [Route("File/Uploader/{refType}/{refId}")]
        public IActionResult Uploader(string refType, int refId, IFormCollection formCollection)
        {
            var postedFile = formCollection.Files[0];
            string originFileName = postedFile.FileName;
            string fileType = originFileName.Split('.').Last().ToLower();

            string newFileName = Guid.NewGuid().ToString("N") + "." + fileType;
            string filePath = Path.Combine(configuration.GetSection("FileRootPath").Value, refType);
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            filePath = Path.Combine(filePath, newFileName);
            byte[] fileByte = new byte[postedFile.Length];
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                postedFile.CopyTo(stream);
                stream.Read(fileByte);
            }
            return Json(new { });
        }
    }
}