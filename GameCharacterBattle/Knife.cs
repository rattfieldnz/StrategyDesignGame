using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GamePractical
{
    /// <summary>
    /// This class creates a knife, 
    /// implementing behaviours from 
    /// the IWeapon and IWeaponBehaviour 
    /// interfaces.
    /// </summary>
    class Knife: IWeapon, IWeaponBehaviour
    {
        /// <summary>
        /// This method returns the name of an action
        /// which is associated with a knife.
        /// </summary>
        /// <returns>The knife's verb/action message.</returns>
        public string UseWeapon()
        {
            return "stab";
        }

        /// <summary>
        /// This method returns a message saying how the knife
        /// will be used
        /// </summary>
        /// <returns>A message saying how the knife is used.</returns>
        public string Attack()
        {
            return "I " + UseWeapon() + " with my " + ToString();
        }

        /// <summary>
        /// This method simply returns the name of the weapon, i.e knife.
        /// </summary>
        /// <returns>The weapon's name.</returns>
        public override string ToString()
        {
            return "knife";
        }
    }
}
