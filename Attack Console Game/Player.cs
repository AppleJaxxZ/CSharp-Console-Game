using System;
using System.Collections.Generic;
using System.Text;

namespace Attack_Console_Game
{

    /// <summary>
    /// this class represents the playable character.
    /// </summary>
    public class Player
    {
        /// <summary>
        /// This represents the players health values.
        /// </summary>
        public int Health { get; set; }

        /// <summary>
        /// The Name Of the player.
        /// </summary>

        public string Name { get; set; }


        /// <summary>
        /// Determines if the player is dead.
        /// </summary>
        public bool IsDead { get; set; }




        /// <summary>
        /// This is the default constructor
        /// </summary>
        public Player()
        {
            //Set health to a value of 100
            Health = 100;
        }


        /// <summary>
        /// this gets called when the player is hit
        /// </summary>
        /// <param name="hit_value"><The ammount of damage the player will take/param>
        public void GetsHit(int hit_value)
        {
            //Subtract the hit value from the health.
            Health = Health - hit_value;

            //Write out that the player got hit.
            Console.WriteLine("You were hit for " + hit_value + " damage! You now have " + Health + " " +
                "left!");

            //check if the player is dead.
            if (Health <= 0)
            {
                //The enemy is dead.
                Die();

            }

        }

        /// <summary>
        /// Called when the player is supposed to die.
        /// </summary>
        private void Die()
        {
            //Write to the console that the player is dead.
            Console.WriteLine(Name + "...you are dead..");

            //Set the boolean that the player has died.
            IsDead = true;

        }


    }
}
