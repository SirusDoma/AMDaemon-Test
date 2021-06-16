using System;

static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"BOARD ID   : {AMDaemon.System.BoardId.Value}");
        Console.WriteLine($"KEYCHIP ID : {AMDaemon.System.KeychipId.Value}");
        Console.WriteLine($"MODEL TYPE : {AMDaemon.System.ModelType}");
        Console.WriteLine($"GAME ID    : {AMDaemon.System.GameId}");
        Console.WriteLine($"DEVELOP    : {AMDaemon.System.IsDevelop}");
        Console.WriteLine($"REGION     : {AMDaemon.System.RegionCode.ToString()}");
        Console.WriteLine($"PATH       : {AMDaemon.System.AppRootPath}");

        Console.ReadKey(true);
    }
}