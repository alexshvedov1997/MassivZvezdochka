using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsOpMassZvezdochka
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = null;
            string path = @"D:\programmC#\TextC#.txt";
            string path2 = @"D:\programmC#\TextWriting.txt";
             using(FileStream read = File.OpenRead(path)){     
                 byte[] array = new byte[read.Length];
              read.Read(array, 0, array.Length);
            str = Encoding.Default.GetString(array);
             }
        int[] mass = str.Where(x => Char.IsDigit(x)).Select( j => (int)Char.GetNumericValue(j)).ToArray(); // чтение чисел из файла
         char[,] arr = ClassMethods.ArrayFiling( mass);
          ClassMethods.ArrayPrint(arr);
          str = ClassMethods.ArrayToString(arr);
          using (FileStream write = new FileStream(path2, FileMode.Append)) {
              byte[] mas = Encoding.Default.GetBytes(str);
              write.Write(mas, 0, mas.Length);
          }
        }
    }
}
