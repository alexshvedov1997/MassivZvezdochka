using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsOpMassZvezdochka
{
    class ClassMethods
    {
        static public int MaxElement(params int[] mass) {
            int max = mass[0];
            for (int i = 0; i < mass.Length; i++) {
                if (max < mass[i]) max = mass[i];
            }
            return max;        
        }

        static public void ArrayPrint( char[,] mass) {
            Console.WriteLine(" Результат");
            for (int i = 0; i < mass.GetLength(0); i++, Console.WriteLine())
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    Console.Write(mass[i,j]);
                }
            } 
        }
        static public char[,] ArrayFiling( params int [] mass) {
            int n = ClassMethods.MaxElement(mass);
            char[,] array = new char[n, mass.Length];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (   i < array.GetLength(0) - mass[j]) array[i, j] = ' ';
                        if (  i >= array.GetLength(0) - mass[j]) array[i, j] = '*';
                    }
                }
                return array;
            }

        static public string ArrayToString(char[,] mass) {
            string text = null;
            for (int i = 0; i < mass.GetLength(0); i++, Console.WriteLine())
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                  text += mass[i, j];
                }
                  text += "\n";
            }
            return text;
        
        }
        
        
    }
}
