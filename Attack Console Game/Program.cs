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

            //Perform the battle GameLoop.
            GameLoop(firstEnemy, random, player, 10, 15);

            //Check if the player was the one who died
            if (!player.IsDead)
            {
                //create the boss character
                Boss boss = new Boss();

                //Perform the GameLoop battle wit boss.
                GameLoop(boss, random, player, 25, 10);

                //Check if the player was the one who died
                if (!player.IsDead)
                {
                    //The Player won the game!~
                    Console.WriteLine("Congratulations!" + player.Name + "\n Think you can do it again?");

                }
                else
                {

                    //The game is over function.
                    GameOver();
                }

            }
            else
            {
                //The game is over.
                GameOver();
            }

        }
        /// <summary>
        /// Writes out what happens when the game is over.
        /// </summary>
        private static void GameOver()
        {

            //The player is dead,  let the user know the game is over.
            Console.WriteLine("GAME OVER!\n Try Again!");
        }


        /// <summary>
        /// The main game loop that allows the player to attack the enemy.,
        /// </summary>
        /// <param name="enemy"> The enemy the player will attack.</param>
        /// <param name="random">The random number generator used to generate random numbers.</param>
        /// <param name="player">The player that is being played as.</param>
        /// <param name="max_attack_dmg">The Maximum attack damage the enemy can deal.</param>
        /// <param name="max_player_attack_power">The max attack power the enemy has to deal.</param>
        private static void GameLoop(Enemy enemy, Random random, Player player, int max_attack_dmg, int max_player_attack_power)
        {
            //WriteOut to the console that an enemy is attacking.
            Console.WriteLine(player.Name + " ..you have encountered a " + enemy.Name + "!");




            //While the enemy and the player are not dead, repeat the while loop playable cycle.
            while (!enemy.IsDead && !player.IsDead)
            {

                //Write out to screen your options..
                Console.WriteLine("\n\nWhat would you like to do?\n\n 1.) Sword Swipe \n 2.) Sword Three Strike Attack\n 3.) Defend With Sheild\n 4.) Cast a healing spell!");

                //Store what action the player Chooses.  
                String playersAction = Console.ReadLine();



                switch (playersAction)
                {
                    case "1":
                        //write out user chose "1".
                        Console.WriteLine("You choose a sword swipe attack" + enemy.Name + "!");

                        //Apply the attack damage to the enemy  random is a c#, .net class that is pre-made.  using Next will return a value withing a specified range.
                        enemy.GetsHit(random.Next(1, max_player_attack_power));
                        break;

                    case "2":
                        //write out user chose "1".
                        Console.WriteLine("You choose sword three strike attack" + enemy.Name + "!");

                        for (int i = 0; i < 3; i++)
                        {
                            //Apply the attack damage to the enemy
                            enemy.GetsHit(random.Next(1, max_player_attack_power));
                            //check if  the enemy is  dead.
                            if (enemy.IsDead)
                            {
                                //break out of the for loop.
                                break;
                            }

                        }
                        break;

                    case "3":
                        Console.WriteLine("You choose to defend with your sheild from " + enemy.Name + "'s attack!");
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

                //Make sure the enemy is not dead
                if (!enemy.IsDead)
                {
                    //Have the enemey attack the player
                    player.GetsHit(random.Next(5, max_attack_dmg));

                }
            }
        }
    }
}
