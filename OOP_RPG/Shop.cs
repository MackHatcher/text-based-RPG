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
            for (var i = 0; i < this.PotionStock.Count(); i++)
            {
                Console.WriteLine($"{(i + 1)}. {this.PotionStock[i].Name}: {this.PotionStock[i].Hp} Health : ({this.PotionStock[i].OriginalValue} gp)");
            }

            var tryParse = int.TryParse(Console.ReadLine(), out var input);
            var itemToBePurchased = PotionStock.ElementAtOrDefault(input - 1);
            if (itemToBePurchased != null && tryParse)
            {
                if (Game.hero.Gold >= itemToBePurchased.OriginalValue && !Game.hero.PotionsBag.Contains(itemToBePurchased))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Game.hero.PotionsBag.Add(itemToBePurchased);
                    Game.hero.Gold = Game.hero.Gold - itemToBePurchased.OriginalValue;
                    Console.WriteLine($"Purchased for {itemToBePurchased.OriginalValue} gp. You have {Game.hero.Gold}gp left!");
                    Console.WriteLine("Press any key to return to the previous menu");
                    Console.ResetColor();
                    var purchaseInput = Console.ReadLine();
                    ShopMenu();
                }
            }
            else if (Game.hero.Gold < itemToBePurchased.OriginalValue)
            {
                Console.WriteLine("Sorry, you don't have enough gp to purchase this. Please come back when you're a bit more affluent!");
                Console.ReadLine();
                ShopMenu();
            }
            else
            {
                Console.WriteLine("Invalid input. Press any key to go to the previous menu.");
                Console.ReadLine();
                ShopMenu();
            }
        }
        public void BuyWeapons()
        {
            for (var i = 0; i < this.WeaponStock.Count(); i++)
            {
                Console.WriteLine($"{(i + 1)}. {this.WeaponStock[i].Name}: {this.WeaponStock[i].Strength} Strength : ({this.WeaponStock[i].OriginalValue} gp)");
            }

            var tryParse = int.TryParse(Console.ReadLine(), out var input);
            var itemToBePurchased = WeaponStock.ElementAtOrDefault(input - 1);
            if (itemToBePurchased != null && tryParse)
            {
                if (Game.hero.Gold >= itemToBePurchased.OriginalValue && !Game.hero.WeaponsBag.Contains(itemToBePurchased) && Game.hero.EquippedWeapon != itemToBePurchased)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Game.hero.WeaponsBag.Add(itemToBePurchased);
                    Game.hero.Gold = Game.hero.Gold - itemToBePurchased.OriginalValue;
                    Console.WriteLine($"Purchased for {itemToBePurchased.OriginalValue} gp. You have {Game.hero.Gold}gp left!");
                    Console.WriteLine("Press any key to return to the previous menu");
                    Console.ResetColor();
                    var purchaseInput = Console.ReadLine();
                    ShopMenu();
                }
            } 
            else if (Game.hero.Gold < itemToBePurchased.OriginalValue)
            {
                Console.WriteLine("Sorry, you don't have enough gp to purchase this. Please come back when you're a bit more affluent!");
                Console.ReadLine();
                ShopMenu();
            }else
            {
                Console.WriteLine("Invalid input. Press any key to go to the previous menu.");
                Console.ReadLine();
                ShopMenu();
            }
            }
        public void BuyArmor()
        {

            Console.WriteLine("Here's what the armorsmith has available today:");
            for (var i = 0; i < this.ArmorStock.Count(); i++)
            {
                Console.WriteLine($"{(i + 1)}. {this.ArmorStock[i].Name}: {this.ArmorStock[i].Defense} Defense : ({this.ArmorStock[i].OriginalValue} gp)");
            }

            var tryParse = int.TryParse(Console.ReadLine(), out var input);
            var itemToBePurchased = ArmorStock.ElementAtOrDefault(input - 1);
            if (itemToBePurchased != null && tryParse)
            {
                if (Game.hero.Gold >= itemToBePurchased.OriginalValue && !Game.hero.ArmorsBag.Contains(itemToBePurchased) && Game.hero.EquippedArmor != itemToBePurchased)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Game.hero.ArmorsBag.Add(itemToBePurchased);
                    Game.hero.Gold = Game.hero.Gold - itemToBePurchased.OriginalValue;
                    Console.WriteLine($"Purchased for {itemToBePurchased.OriginalValue} gp. You have {Game.hero.Gold}gp left!");
                    Console.WriteLine("Press any key to return to the previous menu");
                    Console.ResetColor();
                    var purchaseInput = Console.ReadLine();
                    ShopMenu();
                }
            }
            else if (Game.hero.Gold < itemToBePurchased.OriginalValue)
            {
                Console.WriteLine("Sorry, you don't have enough gp to purchase this. Please come back when you're a bit more affluent!");
                Console.ReadLine();
                ShopMenu();
            }
            else
            {
                Console.WriteLine("Invalid input. Press any key to go to the previous menu.");
                Console.ReadLine();
                ShopMenu();
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
                if (sellingItem == Hero.EquippedWeapon)
                {
                    Console.WriteLine("You cannot sell an equipped item. Returning to previous menu.");
                    Console.ReadLine();
                    SellItems();
                }
                else
                {
                    Hero.Strength = Hero.Strength - (sellingItem.Strength);
                    Console.WriteLine($"Item sold. {sellingItem.ResellValue} gp was added to your wallet.");
                    Hero.Gold = Hero.Gold + sellingItem.ResellValue;
                    Hero.WeaponsBag.Remove(sellingItem);
                    Console.ReadLine();
                    SellItems();
                }
                
                
                
                
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
                if (sellingItem == Hero.EquippedArmor)
                {
                    Console.WriteLine("You cannot sell an equipped item. Returning to previous menu.");
                    Console.ReadLine();
                    SellItems();
                    
                }
                else
                {
                    Hero.Defense = Hero.Defense - (sellingItem.Defense);
                    Hero.ArmorsBag.Remove(sellingItem);
                    Hero.Gold = Hero.Gold + sellingItem.ResellValue;
                    Console.WriteLine($"Item sold. {sellingItem.ResellValue} gp was added to your wallet.");
                    Console.ReadLine();
                    SellItems();
                }
                
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
            Console.WriteLine($"What would you like to buy? You have {Hero.Gold} gold to spend.");
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
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Welcome to the shop. You have {Game.hero.Gold} gold to spend. What would you like to do?");
            Console.WriteLine($"1. Buy Items");
            Console.WriteLine($"2. Sell Items");
            Console.WriteLine($"3. Return to Main Menu");
            Console.ResetColor();
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
