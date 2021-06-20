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
        /// This is the default constructor
        /// </summary>
        public Player()
        {
            //Set health to a value of 100
            Health = 100;
        }

    }
}
