using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace ReliableDownloader;

internal class Program
{
    public static async Task Main(string[] args)
    {
        // If this url 404's, you can get a live one from https://installer.demo.accurx.com/chain/latest.json.
        var exampleUrl = "https://installer.demo.accurx.com/chain/4.22.50587.0/accuRx.Installer.Local.msi";
        var exampleFilePath = Path.Combine(Directory.GetCurrentDirectory(), "myfirstdownload.msi");
        var fileDownloader = new FileDownloader();
        var didDownloadSuccessfully = await fileDownloader.TryDownloadFile(
            exampleUrl,
            exampleFilePath,
            progress => Console.WriteLine($"Percent progress is {progress.ProgressPercent}"),
            CancellationToken.None);
        Console.WriteLine($"File download ended! Success: {didDownloadSuccessfully}");
    }
}