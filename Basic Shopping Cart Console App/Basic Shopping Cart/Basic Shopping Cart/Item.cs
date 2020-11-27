using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Shopping_Cart
{
    public class Item
    {
        private int ID;
        public string Name;

        public Item(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
