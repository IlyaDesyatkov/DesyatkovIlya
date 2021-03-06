﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class Queue<T> : IQueue<T>
    {
        private class Cell
        {
            private T data;
            private Cell next;
            public Cell(T firstCellData)
            {
                data = firstCellData;
                next = null;
            }
            public Cell Next
            {
                get { return next; }
                set { next = value; }
            }
            public T Data
            {
                get { return data; }
                set { data = value; }
            }
        }
        private Cell head; 
        private Cell tail; 
        public Queue()
        {
            head = null;
            tail = null;
        }
        public void Enqueue(T cellData) 
        {
            Cell t = new Cell(cellData);
            if (head == null)
            {
                head = t;
                tail = t;
            }
            else
            {
                tail.Next = t;
                tail = t;
            }
        }
        public T Dequeue() 
        {
            if (head == null)
            {
                throw new Exception("Очередь пуста.");
            }
            else
            {
                Cell t = head;
                head = head.Next;
                if (head == null)
                {
                    tail = null;
                }
                return t.Data;
            }
        }
    }
}
