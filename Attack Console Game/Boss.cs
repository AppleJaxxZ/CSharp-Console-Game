using System;
using System.Collections.Generic;
using System.Text;

namespace Attack_Console_Game
{

    /// <summary>
    /// Represents the Boss in the game.
    /// </summary>
  public class Boss : Enemy
    {

        /// <summary>
        /// The default constructor.
        /// </summary>
        public Boss() : base("Big Boss")
        {
            //Set the health to be a higher value.
            Health = 150;

            //Set Boss Name.
            Name = "Big Boss";
                
        }
        
    }
}
