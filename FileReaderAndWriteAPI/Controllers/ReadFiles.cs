using FileReaderAndWriteAPI.FileReaderAndWriter;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Text.Json;


namespace FileReaderAndWriteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReadFiles : ControllerBase
    {
        [Route("fileread")]
        [HttpPost]
      
        public IActionResult GetAllFilesInAPath([FromBody] FolderDetails path)
        {
            if (path == null)
            {
              return NoContent();
            }
            var withoutSeperatorAddress = path.FolderPath.Split("\b");
            var pathReformated = String.Join(@"\", withoutSeperatorAddress);
            FolderDetails fd=new();
            fd= path;
            fd.FolderPath=pathReformated;
            if (!Directory.Exists(fd.FolderPath))
            {
                return NotFound("Directory doesnt exist");
            }
            
            string jsonString = JsonSerializer.Serialize(FileReadingUtilities.GetAllFilesInAPath(fd));
            return Ok(jsonString);
        }
    }
}
