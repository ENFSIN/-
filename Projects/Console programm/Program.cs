﻿using System.Globalization;
using System.Numerics;
using System;
using System.Runtime.InteropServices;
using System.ComponentModel.Design;

namespace Консольноеприложение
{ /*Операторы
   * арифметические операции с числами
   */
    class Programm
    {
        static void Main(string[] args)
            
        {
            int rub = 1;
            int dol = 30;
            int b =1;
            Console.WriteLine("Конвертация рублей в доллары и наоборот. Напишите 1 или 2 для выбора волюты для конвертации");
            int a =Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Конвертация долларов в рубли. Введите колличество долларов ");
                int c = Convert.ToInt32(Console.ReadLine());
                int d = dol * c;
                Console.WriteLine("Колличество рублей после конвертации " + d);

            }
            else 

               { Console.WriteLine("Конвертаци рублей в доллары. Введите колличество рублей ");
                int e = Convert.ToInt32(Console.ReadLine());
                int j = e / 30;
                Console.WriteLine("Колличество доллоров после конвертации" + j);
            };



            

        }
    }
}