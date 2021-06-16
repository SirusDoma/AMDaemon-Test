using System;
using System.IO;
using System.IO.MemoryMappedFiles;

static class Program
{
    static void Main(string[] args)
    {
        string[] files =
        {
            "amdipc_shm_daemon_table_150805",
            "amdipc_shm_daemon_140819_id0"
        };

        foreach (var fileName in files)
        {
            using (var memoryMappedFile = MemoryMappedFile.OpenExisting(fileName, MemoryMappedFileRights.FullControl, HandleInheritability.None))
            using (var view = memoryMappedFile.CreateViewStream())
            using (var file = new FileStream($"{fileName}.bin", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                view.CopyTo(file);
            }
        }
    }
}