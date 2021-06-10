using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{

    class Item<T>
    {
// prop of the items class that will hold the data inputted 
        public T t { get; set; }
        public int Next { get; set; } = -1; //helps to keep stack in order
        public int Prev { get; set; } = -1; // helps to keep stack in order


        public Item (T t)
        {
            this.t = t;
        }
    }
}
