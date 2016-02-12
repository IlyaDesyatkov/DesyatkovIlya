using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class QueueArr<T> : IQueue<T>
    {
        private int head;
        private int tail;
        private T[] array;
        public void Queue(int n)
        {
            array = new T[n];
            head = 0;
            tail = 0;
        }
        public void Enqueue(T newCellData)
        {
            if (tail == array.Length)
            {
                Console.WriteLine("очередь заполнена");
            }
            array[tail] = newCellData;
            tail++;
        }
        public T Dequeue()
        {
            tail--;
            return array[head];
        }
        private int GetCount
        {
            get { return tail; }
        }
    }
}
