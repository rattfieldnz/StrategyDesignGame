using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GamePractical
{
    /// <summary>
    /// This is the main class for character creation.
    /// </summary>
    abstract class Character
    {
        /// <summary>
        /// A public data-field which tells the GameManager
        /// which type of character the character is.
        /// </summary>
        public CharacterTypes.Types characterType;

        /// <summary>
        /// A data-field for storing the character's name.
        /// </summary>
        private string name;

        /// <summary>
        /// A data-field for storing the character's weapon.
        /// </summary>
        private IWeapon weapon;

        /// <summary>
        /// A data-field for storing the CheckedListBox where the 
        /// character can be added to.
        /// </summary>
        private CheckedListBox listBox;

        /// <summary>
        /// The Character constructor - responsible for initialising
        /// the character's data-fields/properties.
        /// </summary>
        /// <param name="name">The character's name, e.g. Fred.</param>
        /// <param name="listBox">The CheckedListBox where the character can be added to.</param>
        public Character(string name, CheckedListBox listBox)
        {
            this.name = name;
            this.listBox = listBox;
        }

        /// <summary>
        /// This method retrieves the CheckedListBox where the 
        /// character has been added to.
        /// </summary>
        /// <returns>The CheckedListBox that the character has been added to.</returns>
        public ListBox GetCharacterListBox()
        {
            return this.listBox;
        }

        /// <summary>
        /// This method sets the character's CheckedListBox,
        /// according to the one parsed in the constructor.
        /// </summary>
        /// <param name="listBox">The CheckedListBox the character can be added to.</param>
        public void SetCharacterListBox(CheckedListBox listBox)
        {
            this.listBox = listBox;
        }

        /// <summary>
        /// This method sets the weapon the character will use.
        /// </summary>
        /// <param name="weapon">The character's weapon.</param>
        public void SetWeapon(IWeapon weapon)
        {
            this.weapon = weapon;
        }

        /// <summary>
        /// This method returns the weapon the character 
        /// is currently assigned.
        /// </summary>
        /// <returns>The character's weapon.</returns>
        public IWeapon GetWeapon()
        {
            return this.weapon;
        }

        /// <summary>
        /// This method returns the name of the character.
        /// </summary>
        /// <returns>The character's name.</returns>
        public string StateName()
        {
            return this.name;
        }

        /// <summary>
        /// This method sets the character's name, 
        /// according to the value parsed in the 
        /// constructor.
        /// </summary>
        /// <param name="name">The character's name.</param>
        public void SetName(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// This method sets the type of a character, using
        /// an enum list of character types.
        /// </summary>
        /// <param name="type">The character's type.</param>
        public void SetCharacterType(CharacterTypes.Types type)
        {
            ///<summary>
            ///The switch statement will assign the character a type, 
            ///according to the character enum type parsed in the method.
            switch (type)
            {
                case CharacterTypes.Types.KING:
                    this.characterType = CharacterTypes.Types.KING;
                break;

                case CharacterTypes.Types.QUEEN:
                    this.characterType = CharacterTypes.Types.QUEEN;
                break;

                case CharacterTypes.Types.KNIGHT:
                    this.characterType = CharacterTypes.Types.KNIGHT;
                break;

                case CharacterTypes.Types.TROLL:
                this.characterType = CharacterTypes.Types.TROLL;
                break;
            }
        }

        /// <summary>
        /// An abstract method that is created and used 
        /// by characters inheriting this main
        /// character class.
        /// </summary>
        /// <returns>A string telling people/users the type of the character.</returns>
        public abstract string DeClaim();

        /// <summary>
        /// This method returns the name of the character.
        /// </summary>
        /// <returns>The character's name.</returns>
        public override string ToString()
        {
            return StateName();
        }
    }
}
