using ApiCargaArquivos.Models;
using Microsoft.AspNetCore.Mvc;


namespace ApiCargaArquivos.Controllers;
public class FilesController : ControllerBase
{
    private readonly ILogger<FilesController> _logger;

    public FilesController(ILogger<FilesController> logger)
    {
        _logger = logger;
    }

    [HttpPost("upload")]
    //[Consumes("multipart/form-data")]
    //[ProducesResponseType(StatusCodes.StatusCode200OK)]
    //[ProdocesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> UploadFormData([FromBody]FormData data)
    {
        return Ok();
    }
}