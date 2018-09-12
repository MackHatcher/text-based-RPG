using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_RPG
{
    public class Fight
    {
        List<Monster> Monsters { get; set; }
        public Game game { get; set; }
        public Hero hero { get; set; }
        public Monster monster { get; set; }
        
        public Fight(Hero hero, Game game) {

            this.Monsters = new List<Monster>();
            this.hero = hero;
            this.game = game;
            this.AddMonster("Knoll", 9, 8, 20, 2);
            this.AddMonster("Zombie", 9, 8, 18, 2);
            this.AddMonster("Werewolf", 10, 12, 22, 4);
            this.AddMonster("Vampire", 12, 10, 25, 5);
            
   
        }
        
        public void AddMonster(string name, int strength, int defense, int hp, int gold) {
            var monster = new Monster(name, strength, defense, hp, hp, gold);
            this.Monsters.Add(monster);
        }
        
        public void Start() {
           
            Console.WriteLine("Please choose one of the following options:");
            Console.WriteLine("1. Fight the first monster on the list.");
            Console.WriteLine("2. Fight the last monster on the list.");
            Console.WriteLine("3. Fight the second monster on the list.");
            Console.WriteLine("4. Fight the monster with the lowest health.");
            Console.WriteLine("5. Fight the monster with the lowest Strength.");
            Console.WriteLine("6. Fight random monster.");

            var input = Console.ReadLine();
            if (input == "1")
            {
                this.monster = this.Monsters[0];
                Console.WriteLine($"You encountered a {this.monster.Name} , it has {this.monster.Strength} Strength, {this.monster.Defense} Defense and {this.monster.OriginalHP} Health Points.");
                Console.WriteLine("o=====|=================================> <=================================|=====o");
                Console.WriteLine("");
                this.Fighting();
            }
            else if (input == "2")
            {
                this.monster = this.Monsters[3];
                Console.WriteLine($"You encountered a {this.monster.Name} , it has {this.monster.Strength} Strength, {this.monster.Defense} Defense and {this.monster.OriginalHP} Health Points.");
                Console.WriteLine("o=====|=================================> <=================================|=====o");
                Console.WriteLine("");
                this.Fighting();
            } else if ( input == "3")
            {
                this.monster = this.Monsters[1];
                Console.WriteLine("o=====|=================================> <=================================|=====o");
                Console.WriteLine("");
                this.Fighting();
            }
            else if ( input == "4")
            {
                this.monster =
                (from m in Monsters
                where m.OriginalHP < 20
                select m).FirstOrDefault();
                Console.WriteLine($"You encountered a {this.monster.Name} , it has {this.monster.Strength} Strength, {this.monster.Defense} Defense and {this.monster.OriginalHP} Health Points.");
                Console.WriteLine("o=====|=================================> <=================================|=====o");
                Console.WriteLine("");
                this.Fighting();
            }
            else if ( input == "5")
            {
                this.monster =
                (from m in Monsters
                where m.Strength > 11
                select m).FirstOrDefault();
                Console.WriteLine($"You encountered a {this.monster.Name} , it has {this.monster.Strength} Strength, {this.monster.Defense} Defense and {this.monster.OriginalHP} Health Points.");
                Console.WriteLine("o=====|=================================> <=================================|=====o");
                Console.WriteLine("");
                this.Fighting();
            }
            else if (input == "6")
            {
                var rand = new Random();
                this.monster = Monsters[rand.Next(Monsters.Count)];
                Console.WriteLine($"You encountered a {this.monster.Name} , it has {this.monster.Strength} Strength, {this.monster.Defense} Defense and {this.monster.OriginalHP} Health Points.");
                Console.WriteLine("o=====|=================================> <=================================|=====o");
                Console.WriteLine("");
                this.Fighting();
            }    
        }

        public void Fighting()
        {
            //intantiate random monster as current target
            var currentlyfighting = monster;
            Console.WriteLine("It's your move! What will you do?");
            Console.WriteLine("1. Melee Attack");
            Console.WriteLine("2. Take potion");
            Console.WriteLine("3. Run Away");
            var input = Console.ReadLine();
            if (input == "1")
            {
                this.HeroTurn();
            }
            else if (input == "2")
            {
                this.TakePotion();
            }

            else if (input == "3")
            {
                Console.WriteLine("You managed to escape with your tail between your legs! What would you like to do now?");
                this.game.Main();
            }
        }

        public void HeroTurn(){
           var enemy = monster;
           var compare = hero.Strength - enemy.Defense;
           int damage;
           
           if(compare <= 0) {
               damage = 1;
               enemy.CurrentHP -= damage;
           }
           else{
               damage = compare;
               enemy.CurrentHP -= damage;
           }
           Console.WriteLine("You did " + damage + " damage! The " + enemy.Name + " has " + enemy.CurrentHP + " remaining!");
           
           if(enemy.CurrentHP <= 0){
               this.Win();
           }
           else
           {
               this.MonsterTurn();
           }           
        }

        public void TakePotion()
        {
            Console.WriteLine($"What would  you like to do?");
            Console.WriteLine($"1. Take a potion: (3) remaining.");
            Console.WriteLine($"2. Return to combat.");
            var input = Console.ReadLine();
            var player = hero;
            if (input == "1")
            {   if (player.CurrentHP < 30)
                {
                    player.CurrentHP = player.CurrentHP + 6;
                    if (player.CurrentHP > player.OriginalHP)
                    {
                        player.CurrentHP = player.OriginalHP;
                    };
                    Console.WriteLine("You have restored 6 health!");
                    Console.WriteLine("Press any key to return to combat");
                    Console.ReadLine();
                    this.Fighting();
                }
                else
                {
                    Console.WriteLine("You already fully healed! Press any key to return to combat.");
                    Console.ReadLine();
                    this.Fighting();
                }    
            }
            else if (input == "2")
            {
                this.Fighting();
            }
        }
        
        public void MonsterTurn(){
           var enemy = monster;
            var player = hero;
           int damage;
           var compare = enemy.Strength - hero.Defense;
           if(compare <= 0) {
               damage = 1;
               hero.CurrentHP -= damage;
           }
           else{
               damage = compare;
               hero.CurrentHP -= damage;
           }
           Console.WriteLine(enemy.Name + " does " + damage + " damage! You have " + hero.CurrentHP + " remaining!");
           if(hero.CurrentHP <= 0){
               this.Lose();
           }
           else
           {
               this.Fighting();
           }
        }
        
        public void Win() {
            var enemy = monster;
            var player = hero;
            Console.WriteLine($"{enemy.Name} has been defeated! Congratulations, you won the battle! You managed to loot {enemy.Gold} gold from their dead body.");
            player.Gold = player.Gold + enemy.Gold;
            game.Main();
        }
        
        public void Lose() {
            Console.WriteLine("You've been defeated! :( GAME OVER.");
            Console.ReadLine();
            return;
        }
    }
}