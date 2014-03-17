using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GamePractical
{
    /// <summary>
    /// This is the interface responsible
    /// for how a weapon is used.
    /// </summary>
    interface IWeaponBehaviour
    {
        /// <summary>
        /// This method tells how a weapon will be used.
        /// </summary>
        /// <returns>How the weapon will be used.</returns>
        string UseWeapon();
    }
}
