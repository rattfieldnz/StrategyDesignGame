using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GamePractical
{
    /// <summary>
    /// This class is responsible for creating a king.
    /// </summary>
    class King: Character
    {
        /// <summary>
        /// The main constructor - initialising 
        /// the data-fields the king will need.
        /// 
        /// Methods are inherited from the main Character class, 
        /// where the data-fields are also stored.
        /// </summary>
        /// <param name="name">The name of the king, e.g. Bob.</param>
        /// <param name="listBox">The CheckedListBox where the knight can be added to.</param>
        public King(string name, CheckedListBox listBox)
            : base(name, listBox)
        {
            ///<summary>
            ///Sets the nane of a king to the parsed in name value.
            ///</summary>
            SetName(name);

            ///<summary>
            ///Sets the weapon which the king will use.
            ///</summary>
            SetWeapon(new Sword());

            ///<summary>
            ///Retrieve the CheckedListBox for the king.
            ///</summary>
            GetCharacterListBox();

            ///<summary>
            ///Setting the character type of the king, 
            ///using an enum type.
            ///</summary>
            SetCharacterType(CharacterTypes.Types.KING);
        }

        /// <summary>
        /// This method lets the king tell people/users
        /// what type of character they are.
        /// </summary>
        /// <returns>The type of character the king is.</returns>
        public override string DeClaim()
        {
            return "I am a King";
        }

    }
}
