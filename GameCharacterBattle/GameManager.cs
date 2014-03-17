using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GamePractical
{
    /// <summary>
    /// This is the class responsible for handling 
    /// game-related activities.
    /// </summary>
    class GameManager
    {
        /// <summary>
        /// A list of characters used in the game.
        /// </summary>
        private List<Character> characters;

        /// <summary>
        /// A CheckedListBox where characters can
        /// be added.
        /// </summary>
        private CheckedListBox charactersListBox; 

        /// <summary>
        /// A ListBox where the game battle results 
        /// will be shown.
        /// </summary>
        private ListBox battleResults;

        /// <summary>
        /// A data-field defining the number of characters 
        /// in a given battle (default is set to 2);
        /// </summary>
        private int noOfPlayersInBattle = 2;

        /// <summary>
        /// The GameManager constructor - responsible for 
        /// initialising data-fields needed by a game 
        /// manager object.
        /// </summary>
        /// <param name="charactersListBox">A CheckedListBox to hold game characters.</param>
        /// <param name="battleResults">A ListBox to display the game's battle results.</param>
        /// <param name="noOfPlayersInBattle">The number of players which can be in a battle.</param>
        public GameManager(CheckedListBox charactersListBox, ListBox battleResults, int noOfPlayersInBattle)
        {
            ///<summary>
            ///Initialising the list of game characters
            ///</summary>
            this.characters = new List<Character>();

            ///<summary>
            ///Initialising the CheckedListBox the characters 
            ///will be added to.
            ///</summary>
            this.charactersListBox = charactersListBox;

            ///<summary>
            ///Initialising the ListBox which will display 
            ///the game battle results.
            ///</summary>
            this.battleResults = battleResults;

            ///<summary>
            ///Initialising the number of characters 
            ///permitted in the game battle.
            ///</summary>
            this.noOfPlayersInBattle = noOfPlayersInBattle;
        }

        /// <summary>
        /// This method will return the list of characters
        /// currently in the game.
        /// </summary>
        /// <returns>A list of the game's characters.</returns>
        public List<Character> GetCharacters()
        {
            return this.characters;
        }

        /// <summary>
        /// This method sets the initial weapon for 
        /// each character currently in the game, 
        /// according to their character type.
        /// </summary>
        public void SetWeapons()
        {
            ///<summary>
            ///Iterate though each character in the 
            ///character list, and assign a weapon 
            ///according to their character type.
            foreach (Character c in characters)
            {
                switch (c.characterType)
                {
                    case CharacterTypes.Types.KING:
                        c.SetWeapon(new Sword());
                        break;

                    case CharacterTypes.Types.QUEEN:
                        c.SetWeapon(new Bow());
                        break;

                    case CharacterTypes.Types.TROLL:
                        c.SetWeapon(new Bow());
                        break;

                    case CharacterTypes.Types.KNIGHT:
                        c.SetWeapon(new Knife());
                        break;
                }
            }
        }

        /// <summary>
        /// This method initialises the game with a default
        /// set of characters
        /// </summary>
        /// <param name="listbox">The CheckedListBox the characters will be added to.</param>
        public void InitializeCharacters(CheckedListBox listbox)
        {
            characters.Add(new King("Stewie", listbox));
            characters.Add(new Queen("Meg", listbox));
            characters.Add(new Knight("Lancelot", listbox));
            characters.Add(new Knight("Irving", listbox));
            characters.Add(new Troll("Grumpy", listbox));
        }

        /// <summary>
        /// This message is responsible for showing that a character
        /// has successfully been added to the game.
        /// </summary>
        /// <param name="character">The character which is added.</param>
        /// <returns>A success message indicating the character has been added to the game.</returns>
        public string SuccessfulCharacterAdd(Character character)
        {
            ///<summary>
            ///Prepare the success message using a StringBuilder, 
            ///pre-determiend message text, and the name of the
            ///character.
            StringBuilder success = new StringBuilder();
            success.Append("You have successfully added a new character to the game.\nTheir name is ").Append(character.StateName());

            //Append text to the success message indicating the character's type, 
            //according the their character enum type.
            switch (character.characterType)
            {
                case CharacterTypes.Types.KING:
                    success.Append(", and they are a king.");
                    break;
                case CharacterTypes.Types.QUEEN:
                    success.Append(", and they are a queen.");
                    break;
                case CharacterTypes.Types.KNIGHT:
                    success.Append(", and they are a knight.");
                    break;
                case CharacterTypes.Types.TROLL:
                    success.Append(", and they are a troll.");
                    break;
            }

            //Rreturn the completed success message with the previous information.
            return success.ToString();

        }

        /// <summary>
        /// This method is responsible for carrying out a given battle, between
        /// a given set of characters, in a current game.
        /// </summary>
        /// <param name="battleCharactersListBox">The CheckedListBox of characters to select for the battle.</param>
        /// <param name="battleResults">The ListBox to display the battle results.</param>
        public void DoBattle(CheckedListBox battleCharactersListBox, ListBox battleResults)
        {
            ///<summary>
            ///Clear any previous battle results
            ///</summary>
            battleResults.Items.Clear();

            ///<summary>
            ///Checking whether any characters have been selected for the battle, 
            ///and the amount of characters is equal to the number of participants 
            ///parsed in to the GameManager constructor.
            if (battleCharactersListBox.CheckedItems.Count > noOfPlayersInBattle ||
                battleCharactersListBox.CheckedItems.Count < noOfPlayersInBattle ||
                battleCharactersListBox.CheckedItems.Count == 0)
            {
                //If the above condition fails, inform the user/player
                MessageBox.Show("You must select only " + noOfPlayersInBattle + " characters for this battle.");
            }
            else
            {
                //Display the battle results to the form, in the pre-determined ListBox.
                //http://msdn.microsoft.com/en-us/library/system.windows.forms.checkedlistbox.items(v=vs.110).aspx
                foreach (object itemChecked in battleCharactersListBox.CheckedItems)
                {
                    battleResults.Items.Add("*************************");
                    battleResults.Items.Add("My name is " + ((Character)itemChecked).StateName() + "!");
                    battleResults.Items.Add(((Character)itemChecked).DeClaim() + "!");
                    battleResults.Items.Add(((Character)itemChecked).GetWeapon().Attack() + "!");
                    battleResults.Items.Add("*************************");

                }
            }
        }
    }
}
