using System;
using System.Collections.Generic;

namespace OOP_RPG
{
    public class Monster
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Defense { get; set; }
        public int OriginalHP { get; set; }
        public int CurrentHP { get; set; }
        public int Gold { get; set; }
        public int Speed { get; set; }

        public Monster(string name, int strength, int defense, int originalHP, int currentHP, int gold, int speed)
        {
            this.Name = name;
            this.Strength = strength;
            this.Defense = defense;
            this.OriginalHP = originalHP;
            this.CurrentHP = originalHP;
            var random = new Random();
            Gold = gold;
            this.Speed = speed;
        }
    }
    

}