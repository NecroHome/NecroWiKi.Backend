using Microsoft.AspNetCore.Mvc;
using NecroWiKi.Application.Interfaces;

namespace NecroWiKi.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DownloadController : ControllerBase
{
    private readonly IDownloadService _downloadService;

    public DownloadController (
        IDownloadService downloadService
        )
    {
        _downloadService = downloadService;
    }

    [HttpGet("{gamename}")]
    public async Task<IActionResult> Download(string gameName)
    {
        Stream stream = await _downloadService.DownloadGame(gameName);
        if (stream == null)
        {
            return NotFound();
        }

        return File(stream, "application/zip", $"{gameName}.zip", enableRangeProcessing: true);
    }
}