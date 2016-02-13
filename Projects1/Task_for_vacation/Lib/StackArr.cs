using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class StackArr<T> : IStack<T>, IEnumerable<T>
    {
        private T[] array;
        private int top; 
        public void Stack(int n) 
        {
            array = new T[n];
            top = 0;
        }

        public void Push(T newCellData) 
        {
            if (top == array.Length)
            {
                Console.WriteLine("Cтек заполнен");
            }

            array[top] = newCellData;
            top++;
        }

        public T Pop() 
        {
            if (top == 0)
            {
                Console.WriteLine("Cтек пуст");
            }
            top--;
            return array[top];
        }

        public T Peek() 
        {
            return array[top];
        }
        public int GetCount
        {
            get { return top; }
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = top - 1; i >= 0; i--)
                yield return array[i];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
