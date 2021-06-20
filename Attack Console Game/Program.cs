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
            var firstEnemy = new Enemy("Undead Lich");

            //WriteOut to the console that an enemy is attacking.
            Console.WriteLine(player.Name + " ..you have encountered a " + firstEnemy.Name + "!");


       

            //While the first enemy is NOT dead, repeat the while loop playable cycle.
            while (!firstEnemy.IsDead)
            {

                //Write out to screen your options..
                Console.WriteLine("\n\nWhat would you like to do?\n\n 1.) Sword Swipe \n 2.) Sword Lunge Attack\n 3.) Defend With Sheild\n 4.) Try to Retreat!");

                //Store what action the player Chooses.  
                String playersAction = Console.ReadLine();


                //Check what action the player chose.
                if (playersAction == "1")
                {
                    //write out user chose "1".
                    Console.WriteLine("You choose a sword swipe attack!");

                    //Apply the attack damage to the enemy  random is a c#, .net class that is pre-made.  using Next will return a value withing a specified range.
                    firstEnemy.GetsHit(random.Next(1, 15));
                }
                else if (playersAction == "2")
                {
                    //write out user chose "1".
                    Console.WriteLine("You choose sword lunge attack!");

                }
                else if (playersAction == "3")
                {
                    Console.WriteLine("You choose to defend with your sheild!");

                }
                else if (playersAction == "4")
                {
                    Console.WriteLine("You choose to try and retreat!");

                }
                else
                {
                    Console.WriteLine("You chose to do something else.");
                }
            }


        }
    }
}
