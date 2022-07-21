using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Text.Json;

namespace FileReaderAndWriteAPI.Controllers
{

  

    [Route("api/[controller]")]
    [ApiController]

    public class WriteFiles : ControllerBase
    {

        [Route("fileWrite")]
       
        [HttpPost]
        
        public IActionResult WriteAllFilesInAPath([FromBody] FileStructure filestructure)
        {
            var withoutSeperatorAddress = filestructure.Folder.FolderPath.Split("\b");
            var pathReformated = String.Join(@"\", withoutSeperatorAddress);
            filestructure.Folder.FolderPath = pathReformated;

            if (filestructure == null)
            {
                return NoContent();
            }
            if (!Directory.Exists(filestructure.Folder.FolderPath)) { 
                   return NotFound("directory doesnt exist");
            }
          
            var result= FileReaderAndWriter.FileWritingUtilities.WriteAllFilesInAPath(filestructure);
            return Ok("Successfully all the files/folders were created");
        }
    }
}
