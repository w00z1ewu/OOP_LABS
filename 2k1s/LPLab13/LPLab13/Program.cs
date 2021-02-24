using System;

namespace LPLab13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================ Работа с дисками ==============");
            ADADiskInfo.GetFreeSpace();
            ADADiskInfo.GetFileSystem();
            Console.WriteLine();
            ADADiskInfo.GetDisksInfo();
            Console.WriteLine();
            Console.WriteLine("================ Работа с директориями ==============");
            ADADirInfo.GetDirInfo();
            Console.WriteLine();
            Console.WriteLine("================  Работа с файлами ================");
            ADAFileInfo.GetFileInfo();
            Console.WriteLine();
            ADAFileManager.ReadFilesAndDirs();
            ADAFileManager.SearchExt();
            ADAFileManager.Archive();
            ADALog.SearchbyDate();
        }
    }
}
