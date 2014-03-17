using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GamePractical
{
    /// <summary>
    /// This class is responsible for creating a knight.
    /// </summary>
    class Knight : Character
    {
        /// <summary>
        /// The main constructor - initialising 
        /// the data-fields the knight will need.
        /// 
        /// Methods are inherited from the main Character class, 
        /// where the data-fields are also stored.
        /// </summary>
        /// <param name="name">The name of the knight, e.g. Barry.</param>
        /// <param name="listBox">The CheckedListBox where the knight can be added to.</param>
        public Knight(string name, CheckedListBox listBox)
            : base(name, listBox)
        {
            ///<summary>
            ///Sets the nane of a knight to the parsed in name value.
            ///</summary>
            SetName(name);

            ///<summary>
            ///Sets the weapon which the knight will use.
            ///</summary>
            SetWeapon(new Knife());

            ///<summary>
            ///Retrieve the CheckedListBox for the knight.
            ///</summary>
            GetCharacterListBox();

            ///<summary>
            ///Setting the character type of the knight, 
            ///using an enum type.
            ///</summary>
            SetCharacterType(CharacterTypes.Types.KNIGHT);
        }

        /// <summary>
        /// This method lets the knight tell people/users
        /// what type of character they are.
        /// </summary>
        /// <returns>The type of character the knight is.</returns>
        public override string DeClaim()
        {
            return "I am a Knight";
        }
    }
}
