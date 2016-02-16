using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Task1
    {
        public static void Main(string[] args)
        {
            int n;
            Console.WriteLine(@"Программа сортировки строк.");
            Console.WriteLine("\nВведите количество строк:");
            n = int.Parse(Console.ReadLine());
            string[] array = new string[n];
            Console.WriteLine("\nВведите строки (только Латиница):");
            for (int i = 1; i <= n; i++)
            {
                array[i] = Console.ReadLine();
            }
            Console.WriteLine("\nДо сортировки:");
            foreach (string word in array)  
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
            Console.WriteLine("\nПосле сортировки:");
            Sort sort = new Sort(CompareWords);
            sort(array);
            Console.ReadKey();
        }

        public delegate void Sort(string[] a);
        static void CompareWords(string[] arr)
        {
            IEnumerable<string> sortArray = from word in arr
                                            orderby word.Length, word
                                            select word;
            foreach (string word in sortArray)
            {
                Console.Write(word + " ");
            }
        }
    }
}
