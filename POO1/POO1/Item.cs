using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    class Item
    {
        string itemType;
        Person person;

        public Item(string type, Person p)
        {
            itemType = type;
            person = p;
        }
    }
}



