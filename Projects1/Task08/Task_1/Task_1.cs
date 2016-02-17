using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Task_1
    {
        public static void Main()
        {
            int[] arr = new int[100];
            int i = 0;
            string str;
            int j = 0;
            Console.WriteLine("Вводите массив целых чисел, по окончанию введите 'end':");
            do
            {
                str = Console.ReadLine();
                if (str == "end") break;
                arr[i] = Convert.ToInt32(str);
                ++i; ++j;
            } while (true);
            Console.WriteLine("Массив");
            foreach (var t in arr)
            {
                Console.Write(t + " ");
            }
            Console.WriteLine("\nСумма массива: {0}", arr.PlusAll());

            Console.ReadLine();    
        }
    }
    public static class Plus
    {
        public static int PlusAll(this IEnumerable<int> collection)
        {
            var items = new List<int>();
            int s = 0;
            foreach (var t in collection)
            {
                s += t;
            }
            return s;
        }
    }
}
