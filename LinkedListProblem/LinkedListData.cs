﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    public class LinkedListData
    {
        public void Add()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(56);
            list.AddFirst(30);
            list.AddFirst(70);
            foreach (int val in list)
            {
                Console.WriteLine(val);
            }
        }
    }
}
