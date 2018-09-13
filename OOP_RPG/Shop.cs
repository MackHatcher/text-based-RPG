using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RPG
{
    public class Shop : IShopKeep 
    {
        public Shop(List<Armor> armorStock, List<Weapon> weaponStock, List<Potion> potionStock, Game game)
        {
            this.WeaponStock = weaponStock;
            this.ArmorStock = armorStock;
            this.PotionStock = potionStock;
            this.Game = game;
        }

        
        public Game Game { get; set; }
        public Shop ShopFront { get; set; }
        public List<Armor> ArmorStock { get; set; }
        
         public List<Weapon> WeaponStock { get; set; }
        
         public List<Potion> PotionStock { get; set; }  

        public void ShopMenu()
        {

            Console.WriteLine($"Welcome to the shop. You have {Game.hero.Gold} gold to spend. What would you like to do?");
            Console.WriteLine($"1. Buy a Health Potion");
            Console.WriteLine($"2. Buy Weapons");
            Console.WriteLine($"3. Buy Armor");
            Console.WriteLine($"4. Return to Main Menu");
            var shopFrontInput = Console.ReadLine();
            if (shopFrontInput == "1")
            {
                Console.WriteLine("Here's what potions we have available:");
                Console.WriteLine("1. Healing Potion (heals for 5hp) - 3gp");
                Console.WriteLine("2. Greater Healing Potion (heals for 10hp) - 6gp");
                Console.WriteLine("3. Superior Healing Potion (heals for 15hp) - 8gp");
                Console.WriteLine("4. Return to Shop Front");
                var potionInput = Console.ReadLine();
                if (potionInput == "1")
                {
                    if (Game.hero.Gold >= 3)
                    {
                        Game.hero.PotionsBag.Add(this.PotionStock[0]);
                        Game.hero.Gold = Game.hero.Gold - PotionStock[0].OriginalValue;
                        Console.WriteLine($"Purchased for {this.PotionStock[0].OriginalValue} gp. You have {Game.hero.Gold}gp left!");
                        Console.WriteLine("Press any key to return to the previous menu");
                        var purchaseInput = Console.ReadLine();
                        ShopMenu();
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you don't have enough gp to purchase this. Please come back when you're a bit more affluent!");
                        Console.ReadLine();
                        Game.Main();


                    }
                }
                else if (potionInput == "2")
                {
                    if (Game.hero.Gold >= 6)
                    {
                        Game.hero.PotionsBag.Add(this.PotionStock[1]);
                        Game.hero.Gold = Game.hero.Gold - PotionStock[1].OriginalValue;
                        Console.WriteLine($"Purchased for {this.PotionStock[1].OriginalValue} gp. You have {Game.hero.Gold}gp left!");
                        Console.WriteLine("Press any key to return to the previous menu");
                        var purchaseInput = Console.ReadLine();
                        ShopMenu();
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you don't have enough gp to purchase this. Please come back when you're a bit more affluent!");
                        Console.ReadLine();
                        Game.Main();
                    }
                }
                else if (potionInput == "3")
                {
                    if (Game.hero.Gold >= 8)
                    {
                        Game.hero.PotionsBag.Add(this.PotionStock[2]);
                        Game.hero.Gold = Game.hero.Gold - PotionStock[2].OriginalValue;
                        Console.WriteLine($"Purchased for {this.PotionStock[2].OriginalValue} gp. You have {Game.hero.Gold}gp left!");
                        Console.WriteLine("Press any key to return to the previous menu");
                        var purchaseInput = Console.ReadLine();
                        ShopMenu();
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you don't have enough gp to purchase this. Please come back when you're a bit more affluent!");
                        Console.ReadLine();
                        Game.Main();
                    }
                }
                else if (potionInput == "4")
                {
                    this.ShopMenu();
                    Console.ReadLine();
                    
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again");
                    Game.Main();
                }
            }
            else if (shopFrontInput == "2")
            {
                Console.WriteLine("Here's what the Blacksmith has available today:");
                Console.WriteLine("1. Knobbly Branch (+2 Str) - 3gp");
                Console.WriteLine("2. Squire's Sword (+3 Str) - 4gp");
                Console.WriteLine("3. Woodcutter's Axe (+4 Str) - 5gp");
                Console.WriteLine("4. Knight's Mace (+5 Str) - 6gp");
                Console.WriteLine("5. Knight's Blade (+6 Str) - 7gp");
                Console.WriteLine("6. Executioner's Axe (+6 Str) - 8gp");
                Console.WriteLine("7. Return to Shop Front");

                var weaponInput = Console.ReadLine();
                if (weaponInput == "1")
                {
                    if (Game.hero.Gold >= 3)
                    {
                        Game.hero.WeaponsBag.Add(this.WeaponStock[0]);
                        Game.hero.Gold = Game.hero.Gold - WeaponStock[0].OriginalValue;
                        Console.WriteLine($"Purchased for {this.WeaponStock[0].OriginalValue} gp. You have {Game.hero.Gold}gp left!");
                        Console.WriteLine("Press any key to return to the previous menu");
                        var purchaseInput = Console.ReadLine();
                        ShopMenu();
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you don't have enough gp to purchase this. Please come back when you're a bit more affluent!");
                        Console.ReadLine();
                        Game.Main();
                    }

                }
                else if (weaponInput == "2")
                {
                    if (Game.hero.Gold >= 4)
                    {
                        Game.hero.WeaponsBag.Add(this.WeaponStock[1]);
                        Game.hero.Gold = Game.hero.Gold - WeaponStock[1].OriginalValue;
                        Console.WriteLine($"Purchased for {this.WeaponStock[1].OriginalValue} gp. You have {Game.hero.Gold}gp left!");
                        Console.WriteLine("Press any key to return to the previous menu");
                        var purchaseInput = Console.ReadLine();
                        ShopMenu();
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you don't have enough gp to purchase this. Please come back when you're a bit more affluent!");
                        Console.ReadLine();
                        Game.Main();
                    }
                }
                else if (weaponInput == "3")
                {
                    if (Game.hero.Gold >= 5)
                    {
                        Game.hero.WeaponsBag.Add(this.WeaponStock[2]);
                        Game.hero.Gold = Game.hero.Gold - WeaponStock[2].OriginalValue;
                        Console.WriteLine($"Purchased for {this.WeaponStock[2].OriginalValue} gp. You have {Game.hero.Gold}gp left!");
                        Console.WriteLine("Press any key to return to the previous menu");
                        var purchaseInput = Console.ReadLine();
                        ShopMenu();
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you don't have enough gp to purchase this. Please come back when you're a bit more affluent!");
                        Console.ReadLine();
                        Game.Main();
                    }
                }
                else if (weaponInput == "4")
                {
                    if (Game.hero.Gold >= 6)
                    {
                        Game.hero.WeaponsBag.Add(this.WeaponStock[3]);
                        Game.hero.Gold = Game.hero.Gold - WeaponStock[3].OriginalValue;
                        Console.WriteLine($"Purchased for {this.WeaponStock[3].OriginalValue} gp. You have {Game.hero.Gold}gp left!");
                        Console.WriteLine("Press any key to return to the previous menu");
                        var purchaseInput = Console.ReadLine();
                        ShopMenu();
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you don't have enough gp to purchase this. Please come back when you're a bit more affluent!");
                        Console.ReadLine();
                        Game.Main();
                    }
                }
                else if (weaponInput == "5")
                {
                    if (Game.hero.Gold >= 7)
                    {
                        Game.hero.WeaponsBag.Add(this.WeaponStock[4]);
                        Game.hero.Gold = Game.hero.Gold - WeaponStock[4].OriginalValue;
                        Console.WriteLine($"Purchased for {this.WeaponStock[4].OriginalValue} gp. You have {Game.hero.Gold}gp left!");
                        Console.WriteLine("Press any key to return to the previous menu");
                        var purchaseInput = Console.ReadLine();
                        ShopMenu();
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you don't have enough gp to purchase this. Please come back when you're a bit more affluent!");
                        Console.ReadLine();
                        Game.Main();
                    }
                }
                else if (weaponInput == "6")
                {
                    if (Game.hero.Gold >= 8)
                    {
                        Game.hero.WeaponsBag.Add(this.WeaponStock[5]);
                        Game.hero.Gold = Game.hero.Gold - WeaponStock[5].OriginalValue;
                        Console.WriteLine($"Purchased for {this.WeaponStock[5].OriginalValue} gp. You have {Game.hero.Gold}gp left!");
                        Console.WriteLine("Press any key to return to the previous menu");
                        var purchaseInput = Console.ReadLine();
                        ShopMenu();
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you don't have enough gp to purchase this. Please come back when you're a bit more affluent!");
                        Console.ReadLine();
                        Game.Main();
                    }
                }
                else if (weaponInput == "7")
                {
                    this.ShopMenu();
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again");
                    Game.Main();
                }
            }
            else if (shopFrontInput == "3")
            {
                Console.WriteLine("Here's what the armorsmith has available today:");
                Console.WriteLine("1. Leather Armor (+5 Def) - 7gp");
                Console.WriteLine("2. Studded Leather Armor (+7 Def) - 10gp");
                Console.WriteLine("3. Chain Armor (+10 Def) - 15gp");
                Console.WriteLine("4. Return to Shop Front");

                var armorInput = Console.ReadLine();
                if (armorInput == "1")
                {
                    if (Game.hero.Gold >= 7)
                    {
                        Game.hero.ArmorsBag.Add(this.ArmorStock[0]);
                        Game.hero.Gold = Game.hero.Gold - ArmorStock[0].OriginalValue;
                        Console.WriteLine($"Purchased for {this.ArmorStock[0].OriginalValue} gp. You have {Game.hero.Gold}gp left!");
                        Console.WriteLine("Press any key to return to the previous menu");
                        var purchaseInput = Console.ReadLine();
                        ShopMenu();
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you don't have enough gp to purchase this. Please come back when you're a bit more affluent!");
                        Console.ReadLine();
                        Game.Main();
                    }
                }
                else if (armorInput == "2")
                {
                    if (Game.hero.Gold >= 10)
                    {
                        Game.hero.ArmorsBag.Add(this.ArmorStock[1]);
                        Game.hero.Gold = Game.hero.Gold - ArmorStock[1].OriginalValue;
                        Console.WriteLine($"Purchased for {this.ArmorStock[1].OriginalValue} gp. You have {Game.hero.Gold}gp left!");
                        Console.WriteLine("Press any key to return to the previous menu");
                        var purchaseInput = Console.ReadLine();
                        ShopMenu();
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you don't have enough gp to purchase this. Please come back when you're a bit more affluent!");
                        Console.ReadLine();
                        Game.Main();
                    }
                }
                else if (armorInput == "3")
                {
                    if (Game.hero.Gold >= 15)
                    {
                        Game.hero.ArmorsBag.Add(this.ArmorStock[2]);
                        Game.hero.Gold = Game.hero.Gold - ArmorStock[2].OriginalValue;
                        Console.WriteLine($"Purchased for {this.ArmorStock[2].OriginalValue} gp. You have {Game.hero.Gold}gp left!");
                        Console.WriteLine("Press any key to return to the previous menu");
                        var purchaseInput = Console.ReadLine();
                        ShopMenu();
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you don't have enough gp to purchase this. Please come back when you're a bit more affluent!");
                        Console.ReadLine();
                        Game.Main();
                    }
                }
                else if (armorInput == "4")
                {
                    this.ShopMenu();
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again");
                    Game.Main();
                }
            }
            else if (shopFrontInput == "4")
            {
                
                Game.Main();
            }
        }
    }

    public interface IShopKeep
    {
         List<Armor> ArmorStock { get; set; }
         List<Weapon> WeaponStock { get; set; }
         List<Potion> PotionStock { get; set; }
    }

    
}
