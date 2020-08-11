using System.Diagnostics;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FileController : ControllerBase
    {
        private readonly ILogger<FileController> _logger;

        public FileController(ILogger<FileController> logger)
{
            this._logger = logger;
        }

        [HttpPost]
        [RequestSizeLimit(700_000_000)]
        public async System.Threading.Tasks.Task<IActionResult> UploadAsync([FromForm] IFormFile file){
            return Ok(file.Length);
        }
    }
}