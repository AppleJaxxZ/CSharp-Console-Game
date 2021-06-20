using System;
using System.Collections.Generic;
using System.Text;

namespace Attack_Console_Game
{

    /// <summary>
    /// Representing base elements of an enemy.
    /// </summary>
   public class Enemy
    {

        /// <summary>
        /// THe health of the enemy.
        /// </summary>
        public int Health { get; set; }


        /// <summary>
        /// The name of the enemey.
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// Determines if the enemy is dead.
        /// </summary>
        public bool IsDead { get; set; }


        /// <summary>
        /// THe default constructor.
        /// </summary>
        /// <param name="name"> The name im giving the enemey.</param>
        public Enemy(string name)
        {
            //Set the enemies health.
            Health = 100;

            //Set the enemy name;



        }

        /// <summary>
        /// this gets called when the enemey is hit
        /// </summary>
        /// <param name="hit_value"><The ammount of damage the enemy will take/param>
        public void GetsHit(int hit_value)
        {
            //Subtract the hit value from the health.
            Health = Health - hit_value;

            //Write out that the enemy got hit.
            Console.WriteLine(Name + " was hit for " + hit_value + " damage! He now has " + Health + " " +
                "left!");

            //check if the enemy is dead.
            if (Health <= 0)
            {
                //The enemy is dead.
                Die();

            }

        }
        /// <summary>
        /// Called when the enemy is supposed to die.
        /// </summary>
        private void Die()
        {
            //Write to the console that the enemy is dead.
            Console.WriteLine(Name + " has died.");

            //Set the boolean that the enemy has died.
            IsDead = true;

        }



    }
}
