using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;

static class Program
{
    static void Main(string[] args)
    {
        var memoryMappedFiles = new Dictionary<string, MemoryMappedFile>(); // we need keep MemoryMappedFile alive until the program exit
        string[] files =
        {
            "amdipc_shm_daemon_table_150805",
            "amdipc_shm_daemon_140819_id0"
        };

        foreach (var fileName in files)
        {
            using (var file = new FileStream($"{fileName}.bin", FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                memoryMappedFiles[fileName] = MemoryMappedFile.CreateNew(fileName, file.Length);
                using (var view = memoryMappedFiles[fileName].CreateViewStream())
                {
                    file.CopyTo(view);
                }
            }
        }

        Console.ReadKey(true);
    }
}