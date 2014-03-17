using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GamePractical
{
    /// <summary>
    /// This class creates a bow, 
    /// implementing behaviours from 
    /// the IWeapon and IWeaponBehaviour 
    /// interfaces.
    /// </summary>
    class Bow : IWeapon, IWeaponBehaviour
    {
        /// <summary>
        /// This method returns the name of an action
        /// which is associated with a bow.
        /// </summary>
        /// <returns>The bow's verb/action message.</returns>
        public string UseWeapon()
        {
            return "shoot";
        }

        /// <summary>
        /// This method returns a message saying how the bow
        /// will be used
        /// </summary>
        /// <returns>A message saying how the bow is used.</returns>
        public string Attack()
        {
            return "I " + UseWeapon() + " with my " + ToString();
        }

        /// <summary>
        /// This method simply returns the name of the weapon, i.e bow.
        /// </summary>
        /// <returns>The weapon's name.</returns>
        public override string ToString()
        {
            return "bow";
        }
    }
}
