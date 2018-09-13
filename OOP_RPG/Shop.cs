using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RPG
{
    public class Shop : IShopKeep 
    {
        public Shop(List<Armor> armorStock, List<Weapon> weaponStock, List<Potion> potionStock, Game game, Hero hero)
        {
            this.WeaponStock = weaponStock;
            this.ArmorStock = armorStock;
            this.PotionStock = potionStock;
            this.Game = game;
            this.Hero = hero;
        }

        
        public Game Game { get; set; }
        public Hero Hero { get; set; }
        public Shop ShopFront { get; set; }
        public List<Armor> ArmorStock { get; set; }
        
         public List<Weapon> WeaponStock { get; set; }
        
         public List<Potion> PotionStock { get; set; }

        public void BuyPotions()
        {

            Console.WriteLine("Here's what potions we have available:");
            Console.WriteLine($"1. {PotionStock[0].Name} ({PotionStock[0].Hp} hp) - {PotionStock[0].OriginalValue} gp");
            Console.WriteLine($"2. {PotionStock[1].Name} ({PotionStock[1].Hp} hp) - {PotionStock[1].OriginalValue} gp");
            Console.WriteLine($"3. {PotionStock[2].Name} ({PotionStock[2].Hp} hp) - {PotionStock[2].OriginalValue} gp");
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
        public void BuyWeapons()
        {

            Console.WriteLine("Here's what the Blacksmith has available today:");
            Console.WriteLine($"1. {WeaponStock[0].Name} ({WeaponStock[0].Strength} Strength) - {WeaponStock[0].OriginalValue} gp");
            Console.WriteLine($"2. {WeaponStock[1].Name} ({WeaponStock[1].Strength} Strength) - {WeaponStock[1].OriginalValue} gp");
            Console.WriteLine($"3. {WeaponStock[2].Name} ({WeaponStock[2].Strength} Strength) - {WeaponStock[2].OriginalValue} gp");
            Console.WriteLine($"4. {WeaponStock[3].Name} ({WeaponStock[3].Strength} Strength) - {WeaponStock[3].OriginalValue} gp");
            Console.WriteLine($"5. {WeaponStock[4].Name} ({WeaponStock[4].Strength} Strength) - {WeaponStock[4].OriginalValue} gp");
            Console.WriteLine($"6. {WeaponStock[5].Name} ({WeaponStock[5].Strength} Strength) - {WeaponStock[5].OriginalValue} gp");
            Console.WriteLine($"7. Return to Shop Front");

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
        public void BuyArmor()
        {

            Console.WriteLine("Here's what the armorsmith has available today:");
            Console.WriteLine($"1. {ArmorStock[0].Name} ({ArmorStock[0].Defense} Defense) - {ArmorStock[0].OriginalValue} gp");
            Console.WriteLine($"2. {ArmorStock[1].Name} ({ArmorStock[1].Defense} Defense) - {ArmorStock[1].OriginalValue} gp");
            Console.WriteLine($"3. {ArmorStock[2].Name} ({ArmorStock[2].Defense} Defense) - {ArmorStock[2].OriginalValue} gp");
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
        public void sellPotions()
        {

            Console.WriteLine("Your Potions Bag contains the following items: ");
            
            for (var i = 0; i < Hero.PotionsBag.Count(); i++)
            {
                Console.WriteLine($"{(i+1)}. {Hero.PotionsBag[i].Name}: {Hero.PotionsBag[i].ResellValue} gp.");
            }


            var tryParse = int.TryParse(Console.ReadLine(), out var input);
            var sellingItem = Hero.PotionsBag.ElementAtOrDefault( input - 1 );
            if (sellingItem != null && tryParse)
            {
                Hero.PotionsBag.Remove(sellingItem);
                Hero.Gold = Hero.Gold + sellingItem.ResellValue;
                Console.WriteLine($"Item sold. {sellingItem.ResellValue} gp was added to your wallet.");
                Console.ReadLine();
                SellItems();
            }
            
            else
            {
                Console.WriteLine("Invalid input. Returning to previous menu.");
                Console.ReadLine();
                ShopMenu();
            }
            
            
        }
        public void sellWeapons()
        {
            Console.WriteLine("Your Weapon Bag contains the following items: ");
            
            for (var i = 0; i < Hero.WeaponsBag.Count(); i++)
            {
                Console.WriteLine($"{(i + 1)}. {Hero.WeaponsBag[i].Name}: {Hero.WeaponsBag[i].ResellValue} gp.");
            }
            
            var tryParse = int.TryParse(Console.ReadLine(), out var input);
            var sellingItem = Hero.WeaponsBag.ElementAtOrDefault(input - 1);
            if (sellingItem != null && tryParse)
            {
                Hero.WeaponsBag.Remove(sellingItem);
                Hero.Gold = Hero.Gold + sellingItem.ResellValue;
                Console.WriteLine($"Item sold. {sellingItem.ResellValue} gp was added to your wallet.");
                Console.ReadLine();
                SellItems();
            }
            else
            {
                Console.WriteLine("Invalid input. Returning to previous menu.");
                Console.ReadLine();
                SellItems();
            }
        }
        public void sellArmor()
        {
            Console.WriteLine("Your Armor Bag contains the following items: ");
            for (var i = 0; i < Hero.ArmorsBag.Count(); i++)
            {
                Console.WriteLine($"{(i + 1)}. {Hero.ArmorsBag[i].Name}: {Hero.ArmorsBag[i].ResellValue} gp.");
            }

            var tryParse = int.TryParse(Console.ReadLine(), out var input);
            var sellingItem = Hero.ArmorsBag.ElementAtOrDefault(input - 1);
            if (sellingItem != null && tryParse)
            {
                Hero.ArmorsBag.Remove(sellingItem);
                Hero.Gold = Hero.Gold + sellingItem.ResellValue;
                Console.WriteLine($"Item sold. {sellingItem.ResellValue} gp was added to your wallet.");
                Console.ReadLine();
                SellItems();
            }
            else
            {
                Console.WriteLine("Invalid input. Returning to previous menu.");
                Console.ReadLine();
                SellItems();
            }
        }
        public void SellItems()
        {

            Console.WriteLine("What type of item would you like to sell?");
            Console.WriteLine("1. Potions");
            Console.WriteLine("2. Weapons");
            Console.WriteLine("3. Armor");
            Console.WriteLine("4. Return to the previous menu.");
            var sellInput = Console.ReadLine();
            if (sellInput == "1")
            {
                sellPotions();
            }
            else if (sellInput == "2")
            {
                sellWeapons();
            }
            else if (sellInput == "3")
            {
                sellArmor();
            }
            
            else if (sellInput == "4")
            {
                Console.WriteLine("Returning to the previous menu...");
                ShopMenu();
            }
        }
        public void BuyItems()
        {
            Console.WriteLine($"What would you like to buy?");
            Console.WriteLine($"1. Potions");
            Console.WriteLine($"2. Weapons");
            Console.WriteLine($"3. Armor");
            Console.WriteLine($"4. Return to previous Menu");
            var shopBuyInput = Console.ReadLine();
            if (shopBuyInput == "1")
            {
                BuyPotions();
            }
            else if (shopBuyInput == "2")
            {
                BuyWeapons();
            }
            else if (shopBuyInput == "3")
            {
                BuyArmor();
            }
            else if (shopBuyInput == "4")
            {
                Console.WriteLine("Returning to previous menu...");
                ShopMenu();
            }
        }

        public void ShopMenu()
        {

            Console.WriteLine($"Welcome to the shop. You have {Game.hero.Gold} gold to spend. What would you like to do?");
            Console.WriteLine($"1. Buy Items");
            Console.WriteLine($"2. Sell Items");
            Console.WriteLine($"3. Return to Main Menu");
            var shopFrontInput = Console.ReadLine();
            if (shopFrontInput == "1")
            {
                BuyItems();
            }
            else if (shopFrontInput == "2")
            {
                SellItems();
            }
            else if (shopFrontInput == "3")
            {
                Game.Main();
            }

            else if (shopFrontInput == "5")
            {
                ShopMenu();
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
