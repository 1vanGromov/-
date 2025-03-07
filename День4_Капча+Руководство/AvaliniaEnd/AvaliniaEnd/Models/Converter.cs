using Avalonia.Media.Imaging;
using Avalonia.Platform;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AvaliniaEnd.Models
{
    class Converter
    {
        public static Bitmap LoadImage(string photoFileName, string path)
        {
            string fullPath = Path.Combine(path, photoFileName);
            if (File.Exists(fullPath))
            {
                return new Bitmap(fullPath);
            }
            else
            {
                Console.WriteLine($"Изображение не найдено: {fullPath}");
                return new Bitmap("C:\\Users\\kkrok\\source\\repos\\AvaliniaEnd\\AvaliniaEnd\\Assets\\Модераторы_import\\foto1.jpg");
            }
        }
    }
}
