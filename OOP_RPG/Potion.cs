using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RPG
{
    public class Potion : IItem
    {
        public Potion(string name, int hp, int originalValue, int resellValue)
        {
            this.Name = name;
            this.Hp = hp;
            this.OriginalValue = originalValue;
            this.ResellValue = resellValue;
        }

        public string Name { get; set; }
        public int Hp { get; set; }
        public int OriginalValue { get; set; }
        public int ResellValue { get; set; }
    }
}
