using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPLab13
{
    static class ADAFileInfo
    {
        //        a.Полный путь
        //        b.Размер, расширение, имя
        //        c.Дата создания, изменения
        public static void GetFileInfo()
        {
            ADALog.WriteMessage("Вызов метода ADAFileInfo.GetFileInfo()");
            try
            {
                Console.WriteLine("Введите путь к файлу");
                string fileName = Console.ReadLine();
                ADALog.WriteMessage($"Введенный путь к файлу: {fileName}");
                FileInfo file = new FileInfo(fileName);
                if (file.Exists)
                {
                    Console.WriteLine($"Файл {file.Name}.\n" +
                        $"Размер: {file.Length}.\n" +
                        $"Расширение: {file.Extension}.\n" +
                        $"Время создания: {file.CreationTime}.\n" +
                        $"Время изменения: {file.LastWriteTime}.");
                }
                else throw new Exception("Файл не найдена");
            }
            catch (Exception e)
            {
                ADALog.WriteMessage($"Возникла ошибка: {e.Message}");
                Console.WriteLine(e.Message);
            }
        }
    }
}