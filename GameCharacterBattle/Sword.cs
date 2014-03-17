using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GamePractical
{
    /// <summary>
    /// This class creates a sword, 
    /// implementing behaviours from 
    /// the IWeapon and IWeaponBehaviour 
    /// interfaces.
    /// </summary>
    class Sword: IWeapon, IWeaponBehaviour
    {
        /// <summary>
        /// This method returns the name of an action
        /// which is associated with a sword.
        /// </summary>
        /// <returns>The sword's verb/action message.</returns>
        public String UseWeapon()
        {
            return "slice";
        }

        /// <summary>
        /// This method returns a message saying how the bow
        /// will be used
        /// </summary>
        /// <returns>A message saying how the bow is used.</returns>
        public String Attack()
        {
            return "I " + UseWeapon() + " with my " + ToString();
        }

        /// <summary>
        /// This method simply returns the name of the weapon, i.e sword.
        /// </summary>
        /// <returns>The weapon's name.</returns>
        public override string ToString()
        {
            return "sword";
        }
    }
}
