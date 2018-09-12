using System;
using System.Collections.Generic;

namespace OOP_RPG
{
    public class Game
    {
        private List<Potion> potionStock;
        private List<Weapon> weaponStock;
        private List<Armor> armorStock;

        public Hero hero { get; set; }

        public Shop ShopFront { get; set; }
        
        public Game() {
            this.hero = new Hero();
            this.ShopFront = new Shop(armorStock, weaponStock, potionStock);
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
                Console.WriteLine($"Welcome to the shop. You have {hero.Gold} gold to spend. What would you like to do?");
                Console.WriteLine($"1. Buy a Health Potion");
                Console.WriteLine($"2. Buy Weapons");
                Console.WriteLine($"3. Buy Armor");
                var shopFrontInput = Console.ReadLine();
                if (shopFrontInput == "1")
                {
                    Console.WriteLine("Here's what potions we have available:");
                    Console.WriteLine("1. Healing Potion (heals for 5hp) - 3gp");
                    Console.WriteLine("2. Greater Healing Potion (heals for 10hp) - 6gp");
                    Console.WriteLine("3. Superior Healing Potion (heals for 15hp) - 8gp");
                    var potionInput = Console.ReadLine();
                    if (potionInput == "1")
                    {
                        if (hero.Gold >= 3)
                        {
                            hero.PotionsBag.Add(ShopFront.PotionStock[0]);
                            Console.WriteLine($"Purchased for 3gp. You have {hero.Gold}gp left!");
                            Console.WriteLine("Press any key to return to the previous menu");
                            var purchaseInput = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Sorry, you don't have enough gp to purchase this. Please come back when you're a bit more affluent!");
                            Console.ReadLine();



                        }
                    }
                    else if (potionInput == "2")
                    {
                        if (hero.Gold >= 6)
                        {
                            hero.PotionsBag.Add(ShopFront.PotionStock[1]);
                            Console.WriteLine($"Purchased for 6gp. You have {hero.Gold}gp left!");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, you don't have enough gp to purchase this. Please come back when you're a bit more affluent!");
                            Console.ReadLine();
                        }    
                    }
                    else if (potionInput == "3")
                    {
                        if (hero.Gold >= 8)
                        {
                            hero.PotionsBag.Add(ShopFront.PotionStock[2]);
                            Console.WriteLine($"Purchased for 8gp. You have {hero.Gold}gp left!");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, you don't have enough gp to purchase this. Please come back when you're a bit more affluent!");
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please try again");
                    }
                }
                else if (shopFrontInput == "2")
                {
                    Console.WriteLine("Here's what the blacksmith has available today:");
                    Console.WriteLine("1. Knobbly Branch (+2 Str) - 3gp");
                    Console.WriteLine("2. Squire's Sword (+3 Str) - 4gp");
                    Console.WriteLine("3. Woodcutter's Axe (+4 Str) - 5gp");
                    Console.WriteLine("4. Knight's Mace (+5 Str) - 6gp");
                    Console.WriteLine("5. Knight's Blade (+6 Str) - 7gp");
                    Console.WriteLine("3. Executioner's Axe (+6 Str) - 8gp");

                    var weaponInput = Console.ReadLine();
                    if (weaponInput == "1")
                    {
                        if (hero.Gold >= 3)
                        {
                            hero.WeaponsBag.Add(ShopFront.WeaponStock[0]);
                            Console.WriteLine($"Purchased for 3gp. You have {hero.Gold}gp left!");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, you don't have enough gp to purchase this. Please come back when you're a bit more affluent!");
                            Console.ReadLine();
                        }
                        
                    }
                    else if (weaponInput == "2")
                    {
                        if (hero.Gold >= 4)
                        {
                            hero.WeaponsBag.Add(ShopFront.WeaponStock[1]);
                            Console.WriteLine($"Purchased for 4gp. You have {hero.Gold}gp left!");
                            
                        }
                        else
                        {
                            Console.WriteLine("Sorry, you don't have enough gp to purchase this. Please come back when you're a bit more affluent!");
                            Console.ReadLine();
                        }
                    }
                    else if (weaponInput == "3")
                    {
                        if (hero.Gold >= 5)
                        {
                            hero.WeaponsBag.Add(ShopFront.WeaponStock[2]);
                            Console.WriteLine($"Purchased for 5gp. You have {hero.Gold}gp left!");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, you don't have enough gp to purchase this. Please come back when you're a bit more affluent!");
                            Console.ReadLine();
                        }
                    }
                    else if (weaponInput == "4")
                    {
                        if (hero.Gold >= 6)
                        {
                            hero.WeaponsBag.Add(ShopFront.WeaponStock[3]);
                            Console.WriteLine($"Purchased for 6gp. You have {hero.Gold}gp left!");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, you don't have enough gp to purchase this. Please come back when you're a bit more affluent!");
                            Console.ReadLine();
                        }
                    }
                    else if (weaponInput == "5")
                    {
                        if (hero.Gold >= 7)
                        {
                            hero.WeaponsBag.Add(ShopFront.WeaponStock[4]);
                            Console.WriteLine($"Purchased for 7gp. You have {hero.Gold}gp left!");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, you don't have enough gp to purchase this. Please come back when you're a bit more affluent!");
                            Console.ReadLine();
                        }
                    }
                    else if (weaponInput == "6")
                    {
                        if (hero.Gold >= 8)
                        {
                            hero.WeaponsBag.Add(ShopFront.WeaponStock[5]);
                            Console.WriteLine($"Purchased for 8gp. You have {hero.Gold}gp left!");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, you don't have enough gp to purchase this. Please come back when you're a bit more affluent!");
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please try again");
                    }
                }
                else if (shopFrontInput == "3")
                {
                    Console.WriteLine("Here's what the armorsmith has available today:");
                    Console.WriteLine("1. Leather Armor (+5 Def) - 7gp");
                    Console.WriteLine("2. Studded Leather Armor (+7 Def) - 10gp");
                    Console.WriteLine("3. Chain Armor (+10 Def) - 15gp");
                    
                    var armorInput = Console.ReadLine();
                    if (armorInput == "1")
                    {
                        if (hero.Gold >= 7)
                        {
                            hero.ArmorsBag.Add(ShopFront.ArmorStock[0]);
                            Console.WriteLine($"Purchased for 7gp. You have {hero.Gold}gp left!");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, you don't have enough gp to purchase this. Please come back when you're a bit more affluent!");
                            Console.ReadLine();
                        }
                    }
                    else if (armorInput == "2")
                    {
                        if (hero.Gold >= 10)
                        {
                            hero.ArmorsBag.Add(ShopFront.ArmorStock[1]);
                            Console.WriteLine($"Purchased for 10gp. You have {hero.Gold}gp left!");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, you don't have enough gp to purchase this. Please come back when you're a bit more affluent!");
                            Console.ReadLine();
                        }
                    }
                    else if (armorInput == "3")
                    {
                        if (hero.Gold >= 15)
                        {
                            hero.ArmorsBag.Add(ShopFront.ArmorStock[2]);
                            Console.WriteLine($"Purchased for 15gp. You have {hero.Gold}gp left!");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, you don't have enough gp to purchase this. Please come back when you're a bit more affluent!");
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please try again");

                    }
                }
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

        public void stockShop()
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
            var shopFront = new Shop(armorStock, weaponStock, potionStock);

        }
        
        public void Fight(){
            var fight = new Fight(this.hero, this);
            fight.Start();
        }
        

    }
}