﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    internal interface IOperations<T>
    {
        bool Add(T obj);
        bool UpdateFile(List<T> list);
        List<T> GetAll();
    }
}
