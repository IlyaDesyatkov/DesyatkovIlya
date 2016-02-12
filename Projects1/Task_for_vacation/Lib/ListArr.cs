using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class ListArr<T> : IList<T>
    {
        private int head;
        private int tail;
        public T[] array;
        public void List(int n)
        {
            array = new T[n];
            tail = 0;
        }
        private int n;
        private int GetCount
        {
            get { return tail; }
            set { }
        }
        public void Append(T cellData)
        {
            if (tail == array.Length)
            {
                Console.WriteLine("список заполнен");
            }
            else if (tail < n)
            {
                array[tail] = cellData;
                tail++;
            }
        }
        public void Insert(int index, T newCell)
        {
            if (tail == array.Length)
            {
                Console.WriteLine("список заполнен");
            }
            else if (index < n)
            {
                for (int i = index + 1; i < n; i++)
                {
                    array[i] = array[i + 1];
                }
                array[index] = newCell;
                n++;
            }
        }
        public void Delete(int index)
        {
            if (n == 0)
            {
                throw new Exception("Список пуст");
            }
            else if (index < n)
            {
                for (int i = index + 1; i < n; i++)
                {
                    array[i] = array[i - 1];
                }
                n--;
            }
        }
    }
}
