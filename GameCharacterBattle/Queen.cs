using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GamePractical
{
    /// <summary>
    /// This class is responsible for creating a queen.
    /// </summary>
    class Queen : Character
    {
        /// <summary>
        /// The main constructor - initialising 
        /// the data-fields the troll will need.
        /// 
        /// Methods are inherited from the main Character class, 
        /// where the data-fields are also stored.
        /// </summary>
        /// <param name="name">The name of the queen, e.g. Megan.</param>
        /// <param name="listBox">The CheckedListBox where the queen can be added to.</param>
        public Queen(string name, CheckedListBox listBox)
            : base(name, listBox)
        {
            ///<summary>
            ///Sets the nane of a queen to the parsed in name value.
            ///</summary>
            SetName(name);

            ///<summary>
            ///Sets the weapon which the queen will use.
            ///</summary>
            SetWeapon(new Bow());

            ///<summary>
            ///Retrieve the CheckedListBox for the queen.
            ///</summary>
            GetCharacterListBox();

            ///<summary>
            ///Setting the character type of the queen, 
            ///using an enum type.
            ///</summary>
            SetCharacterType(CharacterTypes.Types.QUEEN);
        }

        /// <summary>
        /// This method lets the queen tell people/users
        /// what type of character they are.
        /// </summary>
        /// <returns>The type of character the queen is.</returns>
        public override string DeClaim()
        {
            return "I am a Queen";
        }
    }
}
