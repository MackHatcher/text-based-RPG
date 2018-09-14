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
                if (Game.hero.Gold >= PotionStock[0].OriginalValue)
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
                if (Game.hero.Gold >= PotionStock[1].OriginalValue)
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
                if (Game.hero.Gold >= PotionStock[2].OriginalValue)
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
                    Game.hero.WeaponsBag.Add(itemToBePurchased);
                    Game.hero.Gold = Game.hero.Gold - itemToBePurchased.OriginalValue;
                    Console.WriteLine($"Purchased for {itemToBePurchased.OriginalValue} gp. You have {Game.hero.Gold}gp left!");
                    Console.WriteLine("Press any key to return to the previous menu");

                    var purchaseInput = Console.ReadLine();
                    ShopMenu();
                }
            } 
            else
            {
                Console.WriteLine("Sorry, you don't have enough gp to purchase this. Please come back when you're a bit more affluent!");
                Console.ReadLine();
                Game.Main();
            }
            }
        
        public void BuyArmor()
        {

            Console.WriteLine("Here's what the armorsmith has available today:");

            for (var i = 0; i < this.ArmorStock.Count(); i++)
            {
                Console.WriteLine($"{(i + 1)}. {this.ArmorStock[i].Name}: {this.ArmorStock[i].Defense} Defense : ({this.WeaponStock[i].OriginalValue} gp)");
            }
            
            var armorInput = Console.ReadLine();
            if (armorInput == "1")
            {
                if (Game.hero.Gold >= ArmorStock[0].OriginalValue && !Game.hero.ArmorsBag.Contains(ArmorStock[0]) && Game.hero.EquippedArmor != ArmorStock[0])
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
                if (Game.hero.Gold >= ArmorStock[1].OriginalValue && !Game.hero.ArmorsBag.Contains(ArmorStock[1]) && Game.hero.EquippedArmor != ArmorStock[1])
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
                if (Game.hero.Gold >= ArmorStock[2].OriginalValue && !Game.hero.ArmorsBag.Contains(ArmorStock[2]) && Game.hero.EquippedArmor != ArmorStock[2])
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
