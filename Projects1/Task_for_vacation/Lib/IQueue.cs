using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public interface IQueue<T>
    {
        void Enqueue(T newCellData);
        T Dequeue();
    }
}
