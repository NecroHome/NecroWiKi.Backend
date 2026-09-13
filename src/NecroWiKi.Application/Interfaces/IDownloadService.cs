using System;
using System.Collections.Generic;
using System.Text;

namespace NecroWiKi.Application.Interfaces
{
    public interface IDownloadService
    {
        Task<Stream> DownloadGame(string gameName);
    }
}
