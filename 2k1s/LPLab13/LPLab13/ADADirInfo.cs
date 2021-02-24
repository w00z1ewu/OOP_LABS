using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPLab13
{
    //a.Количестве файлов
    //b.Время создания
    //c.Количестве поддиректориев
    //d.Список родительских директориев
    static class ADADirInfo
    {
        public static void GetDirInfo()
        {
            ADALog.WriteMessage("Вызов метода ADADirInfo.GetDirInfo()");
            try
            {
                Console.WriteLine("Введите путь к директории");
                string dirName = Console.ReadLine();
                ADALog.WriteMessage($"Введенная директория: {dirName}");
                if (Directory.Exists(dirName))
                {
                    Console.WriteLine($"Директория {dirName}.\n" +
                        $"Количество файлов: {Directory.EnumerateFiles(dirName).Count()}.\n" +
                        $"Время создания: {Directory.GetCreationTime(dirName)}.\n" +
                        $"Количество поддиректориев {Directory.GetDirectories(dirName).Length}.\n" +
                        $"Список родительских директориев: {Directory.GetParent(dirName)}");
                }
                else throw new Exception("Директория не найдена");
            }
            catch (Exception e)
            {
                ADALog.WriteMessage($"Возникла ошибка: {e.Message}");
                Console.WriteLine(e.Message);
            }
        }
    }
}