using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Task_2
    {
        public static void Main()
        {
             Console.WriteLine("Определим, число ли ваша строка?");
             Console.WriteLine("Вводите вашу строку:");
             string str = Console.ReadLine();
             char[] ch = str.ToCharArray();
             var a = from i in ch
                     where char.IsDigit()
                     select i;
             char[] array = a.ToArray();
             if (a.Length == array.Length)
             {
                 Console.WriteLine("Строка является числом");
             }
             else Console.WriteLine("Строка не являетс числом");

             Console.ReadKey(); 

        }
    }
}
