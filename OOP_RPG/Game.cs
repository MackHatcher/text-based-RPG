using System;
using System.Collections.Generic;

namespace OOP_RPG
{
    public class Game
    {
        

        public Hero hero { get; set; }

        public Shop ShopFront { get; set; }
        public object shop { get; internal set; }

        public Game() {
            this.hero = new Hero();
            this.ShopFront = stockShop();
        }
            
        public void Start() {
            Console.WriteLine("  _    _ ______ _____   ____             _______      ________ _   _ _______ _    _ _____  ______  _____ ");
            Console.WriteLine(" | |  | |  ____|  __ \\ / __ \\      /\\   |  __ \\ \\    / /  ____| \\ | |__   __| |  | |  __ \\|  ____|/ ____|");
            Console.WriteLine(" | |__| | |__  | |__) | |  | |    /  \\  | |  | \\ \\  / /| |__  |  \\| |  | |  | |  | | |__) | |__  | (___  ");
            Console.WriteLine(" |  __  |  __| |  _  /| |  | |   / /\\ \\ | |  | |\\ \\/ / |  __| | . ` |  | |  | |  | |  _  /|  __|  \\___ \\ ");
            Console.WriteLine(" | |  | | |____| | \\ \\| |__| |  / ____ \\| |__| | \\  /  | |____| |\\  |  | |  | |__| | | \\ \\| |____ ____) |");
            Console.WriteLine(" |_|  |_|______|_|  \\_ \\____/  /_/    \\_\\_____/   \\/   |______|_| \\_|  |_|   \\____/|_|  \\_\\______|_____/ ");
            Console.WriteLine("   ____                 ___                                                                     ");
            Console.WriteLine("  / __ \\ ______ ______ / _ \\ ______ ______ ______ ______ ______ ______ ______ ______ ______ __ _ ");
            Console.WriteLine(" | |  | |______|______| (_) |______|______|______|______|______|______|______|______|______|  \\ \\ ");
            Console.WriteLine(" | |  | |______ ______ > _ < ______ ______ ______ ______ ______ ______ ______ ______ ______    > >");
            Console.WriteLine(" | |__| |______|______| (_) |______|______|______|______|______|______|______|______|______|__/_/ ");
            Console.WriteLine("  \\____/               \\___/                                                                   ");
            Console.WriteLine("o==|=======> Welcome hero! <=======|==o");
            Console.WriteLine("Please enter your name so you can begin your adventure!");
            this.hero.Name = Console.ReadLine();
            Console.WriteLine("Hello " + hero.Name + ".");
            this.Main();
        }
        
        public void Main() {
            Console.WriteLine("Please choose an option by entering a number.");
            Console.WriteLine("1. View Stats");
            Console.WriteLine("2. View Inventory");
            Console.WriteLine("3. Visit Shop");
            Console.WriteLine("4. Fight Monster");
            var input = Console.ReadLine();
            if (input == "1") {
                this.Stats();
            }
            else if (input == "2") {
                this.Inventory();
            }
            else if (input == "3")
            {
                stockShop();
                ShopFront.ShopMenu();
                
                }
            else if (input == "4") {
                this.Fight();
            }
            else {
                return;
            }
        }
        
        public void Stats() {
            hero.ShowStats();
            Console.WriteLine("Press any key to return to main menu.");
            Console.ReadKey();
            this.Main();
        }
        
        public void Inventory(){
            hero.ShowInventory();
            Console.WriteLine("Press any key to return to main menu.");
            Console.ReadKey();
            this.Main();
        }

        public Shop stockShop()
        {
            var club1 = new Weapon("Knobbly Branch", 2, 3, 1);
            var sword1 = new Weapon("Squire's Sword", 3, 4, 2);
            var axe1 = new Weapon("Woodcutter's Axe", 4, 5, 3);
            var club2 = new Weapon("Knight's Mace", 5, 6, 2);
            var sword2 = new Weapon("Knight's Blade", 6, 7, 5);
            var axe2 = new Weapon("Executioner's Axe", 6, 8, 6);
            var weaponStock = new List<Weapon>();
            weaponStock.Add(axe1);
            weaponStock.Add(axe2);
            weaponStock.Add(sword1);
            weaponStock.Add(sword2);
            weaponStock.Add(club1);
            weaponStock.Add(club2);
            var armor1 = new Armor("Leather Armor", 5, 7, 5);
            var armor2 = new Armor("Studded Leather Armor", 7, 10, 5);
            var armor3 = new Armor("Chain Armor", 10, 15, 12);
            var armorStock = new List<Armor>();
            armorStock.Add(armor1);
            armorStock.Add(armor2);
            armorStock.Add(armor3);
            var potion1 = new Potion("Healing Potion", 5, 3, 1);
            var potion2 = new Potion("Greater Healing Potion", 10, 6, 3);
            var potion3 = new Potion("Superior Healing Potion", 15, 8, 5);
            var potionStock = new List<Potion>();
            potionStock.Add(potion1);
            potionStock.Add(potion2);
            potionStock.Add(potion3);
            var shopFront = new Shop(armorStock, weaponStock, potionStock, this);
            return shopFront;

        }
        
        public void Fight(){
            var fight = new Fight(this.hero, this);
            fight.Start();
        }
        

    }
}