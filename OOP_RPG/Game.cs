using System;
using System.Collections.Generic;

namespace OOP_RPG
{
    public class Game
    {
        public Hero hero { get; set; }
        
        public Game() {
            this.hero = new Hero();
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
            Console.WriteLine("3. Fight Monster");
            var input = Console.ReadLine();
            if (input == "1") {
                this.Stats();
            }
            else if (input == "2") {
                this.Inventory();
            }
            else if (input == "3") {
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
        
        public void Fight(){
            var fight = new Fight(this.hero, this);
            fight.Start();
        }
        

    }
}