﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public interface IStack<T>
    {
        void Push(T newCellData);
        T Pop();
    }
}
