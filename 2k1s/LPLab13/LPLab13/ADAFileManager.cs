using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;

namespace LPLab13
{
    //    a.Прочитать список файлов и папок заданного диска.Создать
    //      директорий XXXInspect, создать текстовый файл
    //      xxxdirinfo.txt и сохранить туда информацию. Создать
    //      копию файла и переименовать его. Удалить
    //      первоначальный файл.
    //    b.Создать еще один директорий XXXFiles.Скопировать в
    //      него все файлы с заданным расширением из заданного
    //      пользователем директория. Переместить XXXFiles в
    //      XXXInspect.
    //    c.Сделайте архив из файлов директория XXXFiles.
    //      Разархивируйте его в другой директорий.
    static class ADAFileManager
    {
        public static void ReadFilesAndDirs()
        {
            ADALog.WriteMessage("Вызов метода ADAFileManager.ReadFilesAndDirs()");
            try
            {
                Console.WriteLine("Введите корневую директорию диска(получение инфы о ее содержимом)");
                string dirName = Console.ReadLine();
                if (Directory.Exists(dirName))
                {
                    Directory.CreateDirectory(@"../../../ADAInspect");
                    using (StreamWriter s = new StreamWriter(@"../../../ADAInspect/ADAdirinfo.txt"))
                    {
                        foreach (string name in Directory.EnumerateFileSystemEntries(dirName)) s.WriteLine(name);
                        s.Close();
                    }
                    if (File.Exists(@"../../../ADAInspect/ADAdirinfo_copy.txt")) File.Delete(@"../../../ADAInspect/ADAdirinfo_copy.txt");
                    File.Copy(@"../../../ADAInspect/ADAdirinfo.txt", @"../../../ADAInspect/ADAdirinfo_copy.txt");
                    File.Delete(@"../../../ADAInspect/ADAdirinfo.txt");
                }
                else throw new Exception("Директория не найдена");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void SearchExt()
        {
            ADALog.WriteMessage("Вызов метода ADAFileManager.SearchExt()");
            try
            {
                Console.WriteLine("Введите директорию откуда будут браться файлы.");
                string dirName = Console.ReadLine();
                ADALog.WriteMessage($"Введенная директория: {dirName}");
                Console.WriteLine("Введите расширение");
                string extName = Console.ReadLine();
                ADALog.WriteMessage($"Введенное расширение: {extName}");

                DirectoryInfo source = new DirectoryInfo(dirName);
                DirectoryInfo destin = new DirectoryInfo(@"../../../ADAFiles/");

                if (Directory.Exists(dirName))
                {
                    Directory.CreateDirectory(@"../../../ADAFiles");
                    foreach (FileInfo item in source.GetFiles().Where(x => x.Extension == extName).ToList())
                    {
                        item.CopyTo(destin + item.Name, true);
                    }
                    if (Directory.Exists(@"../../../ADAFiles") && Directory.Exists(@"../../../ADAInspect"))
                        destin.MoveTo(@"../../../ADAInspect/ADAFiles");
                    else throw new Exception("Директория не найдена");
                }
                else throw new Exception("Директория не найдена");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void Archive()
        {
            ADALog.WriteMessage("Вызов метода ADAFileManager.Archive()");
            try
            {
                string zipName = @"../../../ADAFiles.zip";
                string zipFoulder = @"../../../ADAInspect/ADAFiles";
                if (Directory.Exists(zipFoulder))
                {
                    ZipFile.CreateFromDirectory(zipFoulder, zipName);
                    string fileUnzipFullPath = @"../../../ADAInspect/Unzip/";
                    Directory.CreateDirectory(fileUnzipFullPath);
                    using (ZipArchive archive = ZipFile.OpenRead(zipName))
                    {
                        //цикл для каждого файла
                        foreach (ZipArchiveEntry file in archive.Entries)
                        {
                            //вывод инфо
                            Console.WriteLine("File Name: {0}", file.Name);
                            Console.WriteLine("File Size: {0} bytes", file.Length);
                            Console.WriteLine("Compression Ratio: {0}",
                            ((double)file.CompressedLength / file.Length).ToString("0.0%"));
                            //извлечение файла по новому имени
                            file.ExtractToFile(fileUnzipFullPath + file.Name, true);
                        }
                    }
                }
                else throw new Exception("Не обнаружена целевая директория.");
            }
            catch (Exception e)
            {
                ADALog.WriteMessage($"Возникла ошибка: {e.Message}");
                Console.WriteLine(e.Message);
            }

        }
    }
}