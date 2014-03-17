using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

///<summary>
///This is the main interface that each created weapon will implement</summary>
///
namespace GamePractical
{
    interface IWeapon
    {
        /// <summary>
        /// This method is used to say what is being done with the weapon
        /// e.g. 'I stab with my sword'.
        /// </summary>
        /// <returns>The weapon's attack message.</returns>
        string Attack();

        /// <summary>
        /// This method simply returns the name of the weapon
        /// </summary>
        /// <returns>The name of the weapon.</returns>
        string ToString();
    }
}
