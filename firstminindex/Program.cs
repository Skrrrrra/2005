using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace firstminindex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //путь
            string inputpath = "D:\\SolutionsForSpaceApp\\2005\\input.txt";
            string outputpath = "D:\\SolutionsForSpaceApp\\2005\\output.txt";

            //создание файлов
            FileStream fs = new FileStream(inputpath, FileMode.OpenOrCreate);
            fs.Close();
            FileStream fsout = new FileStream(outputpath, FileMode.OpenOrCreate);
            fsout.Close();

            //переменная для обьвления размера массива(1 стр)
            int a;
            using (var reader = new StreamReader(inputpath))
            {
                a = Convert.ToInt32(reader.ReadLine());  // записываем в переменную
            }

            //запись в строку содержимого 2 строки файла
            string secondLine;
            using (var reader = new StreamReader(inputpath))
            {
                reader.ReadLine(); //пропуск 1 строки
                secondLine = reader.ReadLine();  // записываем в переменную
            }

            //запись из строки в массив строк с разделением
            string[] secondlineforint = secondLine.Split(' ');

            //массив для действий над числами
            int[] lastintarr;
            lastintarr = new int[a];

            //запись в интовый массив из массива строк
            int count = 0;
            foreach (var s in secondlineforint)
            {
                lastintarr[count] = Convert.ToInt32(s);
                count++;
            }

            //максимальное значение инт для сравнения
            int minnumb = 2147483647;
            
            //цикл для нахождения минимального значения в массиве 
            for (int i = 0; i < lastintarr.Length; i++)
            {
                if (minnumb > lastintarr[i])
                {
                    minnumb = lastintarr[i];
                }
            }

            //запись в файл вывода
            File.WriteAllText(outputpath, minnumb.ToString());

        }
    }
}
