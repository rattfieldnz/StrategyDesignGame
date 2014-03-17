using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GamePractical
{
    /// <summary>
    /// This class is responsible for creating a troll.
    /// </summary>
    class Troll : Character
    {
        /// <summary>
        /// The main constructor - initialising 
        /// the data-fields the troll will need.
        /// 
        /// Methods are inherited from the main Character class, 
        /// where the data-fields are also stored.
        /// </summary>
        /// <param name="name">The name of the troll, e.g. Fred.</param>
        /// <param name="listBox">The CheckedListBox where the troll can be added to.</param>
        public Troll(string name, CheckedListBox listBox)
            : base(name, listBox)
        {
            ///<summary>
            ///Sets the nane of a troll to the parsed in name value.
            ///</summary>
            SetName(name);

            ///<summary>
            ///Sets the weapon which the troll will use.
            ///</summary>
            SetWeapon(new Bow());

            ///<summary>
            ///Retrieve the CheckedListBox for the troll.
            ///</summary>
            GetCharacterListBox();

            ///<summary>
            ///Setting the character type of the troll, 
            ///using an enum type.
            ///</summary>
            SetCharacterType(CharacterTypes.Types.TROLL);
        }

        /// <summary>
        /// This method lets the troll tell people/users
        /// what type of character they are.
        /// </summary>
        /// <returns>The type of character the troll is.</returns>
        public override string DeClaim()
        {
            return "I am a Troll";
        }
    }
}
