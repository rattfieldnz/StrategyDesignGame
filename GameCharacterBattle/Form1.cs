using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GamePractical
{
    public partial class Form1 : Form
    {

        //-------------------------------------------------------------------------------
        private List<Character> characters;

        GameManager game;
        public Form1()
        {
            game = new GameManager(battleCharactersListBox, gameCharacterListBox, 2);

            characters = game.GetCharacters();
            InitializeComponent();
            
            game.InitializeCharacters(battleCharactersListBox);

            game.SetWeapons();

            foreach (Character c in characters)
            {
                ListBox lb = c.GetCharacterListBox();
                lb.Items.Add(c);
                gameCharacterListBox.Items.Add(c);
            }


        }

        private void addCharacterButton_Click(object sender, EventArgs e)
        {
            string name = characterNameTextBox.Text;

            if ((characterNameTextBox.Text.Length < 1) && (!kingRadioButton.Checked ||
                    !queenRadioButton.Checked ||
                    !knightRadioButton.Checked ||
                    !trollRadioButton.Checked))
            {
                MessageBox.Show("The character's name must be more than 1 character in length, and a character type must be selected.");
            }
            else if ((characterNameTextBox.Text.Length > 1) && (!kingRadioButton.Checked &&
                    !queenRadioButton.Checked &&
                    !knightRadioButton.Checked &&
                    !trollRadioButton.Checked))
            {
                MessageBox.Show("You must select a character type.");
            }
            else
            {
                if (kingRadioButton.Checked)
                {
                    King king = new King(name, battleCharactersListBox);
                    this.characters.Add(king);
                    gameCharacterListBox.Items.Add(king);
                    battleCharactersListBox.Items.Add(king);
                    MessageBox.Show(game.SuccessfulCharacterAdd(king));
                }
                if (queenRadioButton.Checked)
                {
                    Queen queen = new Queen(name, battleCharactersListBox);
                    this.characters.Add(queen);
                    gameCharacterListBox.Items.Add(queen);
                    battleCharactersListBox.Items.Add(queen);
                    MessageBox.Show(game.SuccessfulCharacterAdd(queen));
                }
                if (knightRadioButton.Checked)
                {
                    Knight knight = new Knight(name, battleCharactersListBox);
                    this.characters.Add(knight);
                    gameCharacterListBox.Items.Add(knight);
                    battleCharactersListBox.Items.Add(knight);
                    MessageBox.Show(game.SuccessfulCharacterAdd(knight));
                }
                if (trollRadioButton.Checked)
                {
                    Troll troll = new Troll(name, battleCharactersListBox);
                    this.characters.Add(troll);
                    gameCharacterListBox.Items.Add(troll);
                    battleCharactersListBox.Items.Add(troll);
                    MessageBox.Show(game.SuccessfulCharacterAdd(troll));
                }
            }
        }

        private void battleButton_Click(object sender, EventArgs e)
        {
            game.DoBattle(battleCharactersListBox, battleListBox);
        }

        private void changeWeaponBtn_Click(object sender, EventArgs e)
        {
            StringBuilder changedWeaponMessage = new StringBuilder();

            int count = 0;

            if(gameCharacterListBox.CheckedItems.Count < 1 && (swordRadioButton.Checked || knifeRadioButton.Checked || bowRadioButton.Checked))
            {
                changedWeaponMessage.Append("You must select at least 1 character for which you want the weapon changed.");
            }
            else if (gameCharacterListBox.CheckedItems.Count < 1 && (!swordRadioButton.Checked || !knifeRadioButton.Checked || !bowRadioButton.Checked))
            {
                changedWeaponMessage.Append("You must select at least one character for which you want the weapon changed, and the weapon you wish to change to.");
            }
            else if ((gameCharacterListBox.CheckedItems.Count > 0 && !swordRadioButton.Checked) && 
                     (gameCharacterListBox.CheckedItems.Count > 0 && !knifeRadioButton.Checked) &&
                      gameCharacterListBox.CheckedItems.Count > 0 && !bowRadioButton.Checked)
            {
                changedWeaponMessage.Append("You must select a weapon for your selected character/s to change to.");
            }
            else
            {
                foreach (object itemChecked in gameCharacterListBox.CheckedItems)
                {
                    changedWeaponMessage.Append("You have changed " + ((Character)itemChecked).StateName() + "'s weapon to a ");

                    if (swordRadioButton.Checked)
                    {
                        ((Character)itemChecked).SetWeapon(new Sword());
                        changedWeaponMessage.Append(((Character)itemChecked).GetWeapon().ToString() + ".").Append("\n").ToString();
                        count++;
                    }
                    if (knifeRadioButton.Checked)
                    {
                        ((Character)itemChecked).SetWeapon(new Knife());
                        changedWeaponMessage.Append(((Character)itemChecked).GetWeapon().ToString() + ".").Append("\n").ToString();
                        count++;
                    }
                    if (bowRadioButton.Checked)
                    {
                        ((Character)itemChecked).SetWeapon(new Bow());
                        changedWeaponMessage.Append(((Character)itemChecked).GetWeapon().ToString() + ".").Append("\n").ToString();
                        count++;
                    }
                }
            }

            MessageBox.Show(changedWeaponMessage.ToString());
        }
       
    }
}
