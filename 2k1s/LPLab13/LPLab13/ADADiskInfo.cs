using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPLab13
{
    //a.свободном месте на диске
    //b.Файловой системе
    //c.Для каждого существующего диска - имя, объем, доступный
    //  объем, метка тома.
    //d.Продемонстрируйте работу класса
    static class ADADiskInfo
    {
        public static void GetFreeSpace()
        {
            ADALog.WriteMessage("Вызов метода ADADiskInfo.GetFreeSpace()");
            try
            {
                Console.WriteLine("Введите имя диска.");
                string DiskName = Console.ReadLine();
                ADALog.WriteMessage($"Введенное имя диска: {DiskName}");
                DriveInfo disk = DriveInfo.GetDrives().Where(d => d.Name.Contains(DiskName)).ToArray()[0];
                Console.WriteLine($"Диск: {disk.Name}" +
                     $". Свободное место: {disk.AvailableFreeSpace / 1073741824} ГБ");
            }
            catch
            {
                ADALog.WriteMessage("Возникла ошибка: неверное имя диска.");
                Console.WriteLine("Неверное имя диска.");
            }
        }

        public static void GetFileSystem()
        {
            ADALog.WriteMessage("Вызов метода ADADiskInfo.GetFileSystem()");
            try
            {
                Console.WriteLine("Введите имя диска.");
                string DiskName = Console.ReadLine();
                ADALog.WriteMessage($"Введенное имя диска: {DiskName}");
                DriveInfo disk = DriveInfo.GetDrives().Where(d => d.Name.Contains(DiskName)).ToArray()[0];
                Console.WriteLine($"Диск: {disk.Name}" +
                    $". Файловая система: {disk.DriveFormat}");
            }
            catch
            {
                ADALog.WriteMessage("Возникла ошибка: неверное имя диска.");
                Console.WriteLine("Неверное имя диска.");
            }
        }

        public static void GetDisksInfo()
        {
            ADALog.WriteMessage("Вызов метода ADADiskInfo.GetDisksInfo()");
            try
            {
                DriveInfo[] disks = DriveInfo.GetDrives();
                foreach (DriveInfo d in disks)
                {
                    Console.WriteLine("Имя диска: {0}", d.Name);
                    if (!d.IsReady) continue;
                    Console.WriteLine("Метка тома: {0}", d.VolumeLabel);
                    Console.WriteLine("Файловая система: {0}", d.DriveFormat);
                    Console.WriteLine("Объем: {0} ГБ", d.TotalSize / 1073741824);
                    Console.WriteLine("Доступный объем: {0} ГБ", d.AvailableFreeSpace / 1073741824);
                }

            }
            catch (Exception e)
            {
                ADALog.WriteMessage($"Возникла ошибка: {e.Message}.");
                Console.WriteLine(e.Message);
            }
        }

    }
}