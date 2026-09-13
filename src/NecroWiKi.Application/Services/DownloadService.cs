using NecroWiKi.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NecroWiKi.Application.Services
{
    public class DownloadService : IDownloadService
    {
        public Task<Stream> DownloadGame(string gameName)
        {
            string filePath = Path.Combine("games", $"{gameName}.zip");

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"File {filePath} not found.");
            }

            Stream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);

            return Task.FromResult<Stream>(stream);
        }
    }
}
