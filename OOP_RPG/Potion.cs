using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RPG
{
    public class Potion
    {
        public Potion(string name, int value)
        {
            this.Name = name;
            this.value = value;
        }

        public string Name { get; set; }
        public int value { get; set; }
    }
}
