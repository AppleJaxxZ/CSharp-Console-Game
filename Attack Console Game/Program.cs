using System;

namespace Attack_Console_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create and store the random class
            Random random = new Random();


            //Output the text asking the player for their name.
             Console.WriteLine("What is your name?\n");

            //Create the player character and store his name.
            Player player = new Player()
            {
                Name = Console.ReadLine()
            };

            //Let the player know his name.
            Console.WriteLine("\nThank you for entering your name, " + player.Name + ".\n");


            //Create a variable to track the first enemy.
            Enemy firstEnemy = new Enemy("Undead Lich");

            //WriteOut to the console that an enemy is attacking.
            Console.WriteLine(player.Name + " ..you have encountered a " + firstEnemy.Name + "!");


       

            //While the first enemyand the player are not dead, repeat the while loop playable cycle.
            while (!firstEnemy.IsDead && !player.IsDead)
            {

                //Write out to screen your options..
                Console.WriteLine("\n\nWhat would you like to do?\n\n 1.) Sword Swipe \n 2.) Sword Three Strike Attack\n 3.) Defend With Sheild\n 4.) Cast a healing spell!");
                
                //Store what action the player Chooses.  
                String playersAction = Console.ReadLine();



                switch(playersAction)
                {
                    case "1":
                        //write out user chose "1".
                        Console.WriteLine("You choose a sword swipe attack" + firstEnemy.Name + "!");

                        //Apply the attack damage to the enemy  random is a c#, .net class that is pre-made.  using Next will return a value withing a specified range.
                        firstEnemy.GetsHit(random.Next(1, 15));
                        break;

                    case "2":
                        //write out user chose "1".
                        Console.WriteLine("You choose sword three strike attack" + firstEnemy.Name + "!");

                        for (int i = 0; i < 3; i++)
                        {
                            //Apply the attack damage to the enemy
                            firstEnemy.GetsHit(random.Next(1, 15));
                        }
                        break;

                    case "3":
                        Console.WriteLine("You choose to defend with your sheild from " + firstEnemy.Name + "'s attack!");
                        //set that the player is guarding.
                        player.IsGuarding = true;
                        break;

                    case "4":
                        //write out you chose chose number 4.
                        Console.WriteLine("You choose to heal yourself!");
                        //Heal the player a random amount
                        player.Heal(random.Next(1, 15));
                        break;

                    default:
                        Console.WriteLine("You chose to do something else.");
                        break;


                }

                //Have the enemey attack the player
                player.GetsHit(random.Next(5, 8));
            }


        }
    }
}
