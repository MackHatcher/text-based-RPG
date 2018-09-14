using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_RPG
{
    public class Hero
    {
        /*This is a Constructor.
        When we create a new object from our Hero class, the instance of this class, our hero, has:
        an empty List that has to contain instances of the Armor class,
        an empty List that has to contain instance of the Weapon class,
        stats of the "int" data type, including an intial strength and defense,
        original hitpoints that are going to be the same as the current hitpoints.
        */
        public Hero() {
            this.ArmorsBag = new List<Armor>();
            this.WeaponsBag = new List<Weapon>();
            this.PotionsBag = new List<Potion>();
            this.Strength = 10;
            this.Defense = 10;
            this.OriginalHP = 30;
            this.CurrentHP = 30;
            this.Gold = 20;
            this.Speed = 10;
        }
        
        // These are the Properties of our Class.
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Defense { get; set; }
        public int OriginalHP { get; set; }
        public int CurrentHP { get; set; }
        public int Gold { get; set; }
        public int Speed { get; set; }
        public Potion HealthPotion { get; set; }
        public Weapon EquippedWeapon { get; set; }
        public Armor EquippedArmor { get; set; }
        
        public List<Armor> ArmorsBag { get; set;}
        public List <Weapon> WeaponsBag { get; set; }
        public List<Potion> PotionsBag { get; set; }
       
        
        //These are the Methods of our Class.
        public void ShowStats() {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"o ==|=======> {this.Name} <=======|== o");
            Console.WriteLine($"Strength: { this.Strength}");
            Console.WriteLine("Defense: " + this.Defense);
            Console.WriteLine("Hitpoints: " + this.CurrentHP + "/" + this.OriginalHP);
            Console.ResetColor();
        }
        
        public void ShowInventory() {

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("o ==|=======>  INVENTORY <=======|== o");
            Console.WriteLine($"Wallet: {this.Gold} gold");
            Console.WriteLine("");
            Console.WriteLine("Weapons: ");
            for (var i = 0; i < this.WeaponsBag.Count(); i++)
            {
                Console.WriteLine($"{(i + 1)}. {this.WeaponsBag[i].Name}: {this.WeaponsBag[i].Strength} Strength.");
            }
            
            Console.WriteLine("Armor: ");
            for (var i = 0; i < this.ArmorsBag.Count(); i++)
            {
                Console.WriteLine($"{(i + 1)}. {this.ArmorsBag[i].Name}: {this.ArmorsBag[i].Defense} Defense.");
            }
            
            Console.WriteLine($"Health Potions: ");

            foreach (var p in this.PotionsBag.GroupBy(p=> p.Name))
            {               
                    Console.WriteLine($"{p.Key}: ({p.Count()})");
            }
            Console.WriteLine("");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("");
            Console.WriteLine("1. Equip an Item");
            Console.WriteLine("2. Unequip an Item");
            
            var input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("1. Equip a Weapon");
                Console.WriteLine("2. Equip Armor");
                var equipInput = Console.ReadLine();
                if (equipInput == "1")
                {
                    EquipWeapon();
                }
                else if (equipInput == "2")
                {
                    EquipArmor();
                }
                else
                {
                    Console.WriteLine("Invalid input. Returning to inventory...");
                    Console.ReadLine();
                    ShowInventory();
                }
            }
            else if (input == "2")
            {
                Console.WriteLine("1. Unequip a Weapon");
                Console.WriteLine("2. Unequip Armor");
                var equipInput = Console.ReadLine();
                if (equipInput == "1")
                {
                    RemoveWeapon();
                }
                else if (equipInput == "2")
                {
                    RemoveArmor();
                }
                else
                {
                    Console.WriteLine("Invalid input. Returning to inventory...");
                    Console.ReadLine();
                    ShowInventory();
                }
            }Console.ResetColor();
            
        }
        
        public void EquipWeapon() {

            if (this.WeaponsBag.Any())
            {
                Console.WriteLine("Please enter which weapon you would like to equip.");
                for (var i = 0; i < this.WeaponsBag.Count(); i++)
                {
                    Console.WriteLine($"{(i + 1)}. {this.WeaponsBag[i].Name}: {this.WeaponsBag[i].Strength} Strength.");
                }
                var tryParse = int.TryParse(Console.ReadLine(), out var input);
                var itemToAdd = this.WeaponsBag.ElementAtOrDefault(input - 1);
                if (itemToAdd != null && tryParse)
                {
                    this.EquippedWeapon = itemToAdd;
                    this.Strength = Strength + itemToAdd.Strength;
                    Console.WriteLine($"Item equipped. Your Strength has increased by {itemToAdd.Strength}.");
                    Console.WriteLine($"Press any key to return to your inventory.");
                    Console.ReadLine();
                    ShowInventory();
                    
                }
            }
            else if (!this.WeaponsBag.Any())
            {
                Console.WriteLine("Sorry, it doesn't appear that you have any weapons currently.");
                Console.WriteLine("Press any key to return to the previous screen.");
                Console.ReadLine();
                ShowInventory();
            }
            else
            {
                Console.WriteLine($"Invalid input.");
                EquipWeapon();
            }
        }

        public void RemoveWeapon()
        {
            Console.WriteLine($"Are you sure you want to unequip your {this.EquippedWeapon}?");
            Console.WriteLine("1. Unequip");
            Console.WriteLine("2. Return to previous menu");
            var input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine($"{EquippedWeapon} has been removed.");
                Console.WriteLine($"Press any key to return to your inventory.");
                this.Strength = Strength - EquippedWeapon.Strength;
                this.EquippedWeapon = null;
                Console.ReadLine();
                ShowInventory();
            }
            else
            {
                Console.WriteLine($"Invalid input. Returning to inventory.");
                Console.ReadLine();
                ShowInventory();
            }
            
        }
        
        public void EquipArmor() {
            if (this.ArmorsBag.Any())
            {
                Console.WriteLine("Please enter what armor you would like to equip.");
                for (var i = 0; i < this.ArmorsBag.Count(); i++)
                {
                    Console.WriteLine($"{(i + 1)}. {this.ArmorsBag[i].Name}: {this.ArmorsBag[i].Defense} Defense.");
                }
                var tryParse = int.TryParse(Console.ReadLine(), out var input);
                var itemToAdd = this.ArmorsBag.ElementAtOrDefault(input - 1);
                if (itemToAdd != null && tryParse)
                {
                    this.EquippedArmor = itemToAdd;
                    this.Defense = Defense + itemToAdd.Defense;
                    Console.WriteLine($"Item equipped. Your Defense has increased by {itemToAdd.Defense}.");
                    Console.WriteLine($"Press any key to return to your inventory.");
                    Console.ReadLine();
                    ShowInventory();

                }
            }
            else if (!this.ArmorsBag.Any())
            {
                Console.WriteLine("Sorry, it doesn't appear that you have any armor currently.");
                Console.WriteLine("Press any key to return to the previous screen.");
                Console.ReadLine();
                ShowInventory();
            }
            else
            {
                Console.WriteLine($"Invalid input.");
                EquipWeapon();
            }
        }

        public void RemoveArmor()
        {
            Console.WriteLine($"Are you sure you want to unequip your {this.EquippedArmor}?");
            Console.WriteLine("1. Unequip");
            Console.WriteLine("2. Return to previous menu");
            var input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine($"{EquippedArmor} has been removed.");
                Console.WriteLine($"Press any key to return to your inventory.");
                this.Defense = Defense - EquippedArmor.Defense;
                this.EquippedArmor = null;
                Console.ReadLine();
                ShowInventory();
            }
            else
            {
                Console.WriteLine($"Invalid input. Returning to inventory.");
                Console.ReadLine();
                ShowInventory();
            }
        }
    }
}