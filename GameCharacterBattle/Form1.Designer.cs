namespace GamePractical
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trollRadioButton = new System.Windows.Forms.RadioButton();
            this.knightRadioButton = new System.Windows.Forms.RadioButton();
            this.queenRadioButton = new System.Windows.Forms.RadioButton();
            this.kingRadioButton = new System.Windows.Forms.RadioButton();
            this.characterNameTextBox = new System.Windows.Forms.TextBox();
            this.addCharacterButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.battleButton = new System.Windows.Forms.Button();
            this.battleCharactersListBox = new System.Windows.Forms.CheckedListBox();
            this.battleListBox = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bowRadioButton = new System.Windows.Forms.RadioButton();
            this.knifeRadioButton = new System.Windows.Forms.RadioButton();
            this.swordRadioButton = new System.Windows.Forms.RadioButton();
            this.gameCharacterListBox = new System.Windows.Forms.CheckedListBox();
            this.changeWeaponBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.characterNameTextBox);
            this.panel1.Controls.Add(this.addCharacterButton);
            this.panel1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 169);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trollRadioButton);
            this.groupBox1.Controls.Add(this.knightRadioButton);
            this.groupBox1.Controls.Add(this.queenRadioButton);
            this.groupBox1.Controls.Add(this.kingRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(272, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 138);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Character Type";
            // 
            // trollRadioButton
            // 
            this.trollRadioButton.AutoSize = true;
            this.trollRadioButton.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trollRadioButton.Location = new System.Drawing.Point(13, 103);
            this.trollRadioButton.Name = "trollRadioButton";
            this.trollRadioButton.Size = new System.Drawing.Size(67, 25);
            this.trollRadioButton.TabIndex = 3;
            this.trollRadioButton.TabStop = true;
            this.trollRadioButton.Text = "Troll";
            this.trollRadioButton.UseVisualStyleBackColor = true;
            // 
            // knightRadioButton
            // 
            this.knightRadioButton.AutoSize = true;
            this.knightRadioButton.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knightRadioButton.Location = new System.Drawing.Point(13, 78);
            this.knightRadioButton.Name = "knightRadioButton";
            this.knightRadioButton.Size = new System.Drawing.Size(89, 25);
            this.knightRadioButton.TabIndex = 2;
            this.knightRadioButton.TabStop = true;
            this.knightRadioButton.Text = "Knight";
            this.knightRadioButton.UseVisualStyleBackColor = true;
            // 
            // queenRadioButton
            // 
            this.queenRadioButton.AutoSize = true;
            this.queenRadioButton.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queenRadioButton.Location = new System.Drawing.Point(13, 53);
            this.queenRadioButton.Name = "queenRadioButton";
            this.queenRadioButton.Size = new System.Drawing.Size(80, 25);
            this.queenRadioButton.TabIndex = 1;
            this.queenRadioButton.TabStop = true;
            this.queenRadioButton.Text = "Queen";
            this.queenRadioButton.UseVisualStyleBackColor = true;
            // 
            // kingRadioButton
            // 
            this.kingRadioButton.AutoSize = true;
            this.kingRadioButton.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kingRadioButton.Location = new System.Drawing.Point(13, 28);
            this.kingRadioButton.Name = "kingRadioButton";
            this.kingRadioButton.Size = new System.Drawing.Size(71, 25);
            this.kingRadioButton.TabIndex = 0;
            this.kingRadioButton.TabStop = true;
            this.kingRadioButton.Text = "King";
            this.kingRadioButton.UseVisualStyleBackColor = true;
            // 
            // characterNameTextBox
            // 
            this.characterNameTextBox.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterNameTextBox.Location = new System.Drawing.Point(73, 79);
            this.characterNameTextBox.Name = "characterNameTextBox";
            this.characterNameTextBox.Size = new System.Drawing.Size(164, 29);
            this.characterNameTextBox.TabIndex = 9;
            // 
            // addCharacterButton
            // 
            this.addCharacterButton.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCharacterButton.Location = new System.Drawing.Point(20, 18);
            this.addCharacterButton.Name = "addCharacterButton";
            this.addCharacterButton.Size = new System.Drawing.Size(215, 32);
            this.addCharacterButton.TabIndex = 8;
            this.addCharacterButton.Text = "Create New Character";
            this.addCharacterButton.UseVisualStyleBackColor = true;
            this.addCharacterButton.Click += new System.EventHandler(this.addCharacterButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.battleButton);
            this.panel2.Controls.Add(this.battleCharactersListBox);
            this.panel2.Controls.Add(this.battleListBox);
            this.panel2.Location = new System.Drawing.Point(12, 196);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 338);
            this.panel2.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "To Battle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Choose Two Combatants";
            // 
            // battleButton
            // 
            this.battleButton.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.battleButton.Location = new System.Drawing.Point(222, 34);
            this.battleButton.Margin = new System.Windows.Forms.Padding(2);
            this.battleButton.Name = "battleButton";
            this.battleButton.Size = new System.Drawing.Size(218, 35);
            this.battleButton.TabIndex = 22;
            this.battleButton.Text = "Battle!";
            this.battleButton.UseVisualStyleBackColor = true;
            this.battleButton.Click += new System.EventHandler(this.battleButton_Click);
            // 
            // battleCharactersListBox
            // 
            this.battleCharactersListBox.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.battleCharactersListBox.FormattingEnabled = true;
            this.battleCharactersListBox.Location = new System.Drawing.Point(11, 80);
            this.battleCharactersListBox.Margin = new System.Windows.Forms.Padding(2);
            this.battleCharactersListBox.Name = "battleCharactersListBox";
            this.battleCharactersListBox.Size = new System.Drawing.Size(201, 244);
            this.battleCharactersListBox.TabIndex = 21;
            // 
            // battleListBox
            // 
            this.battleListBox.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.battleListBox.FormattingEnabled = true;
            this.battleListBox.ItemHeight = 21;
            this.battleListBox.Location = new System.Drawing.Point(222, 80);
            this.battleListBox.Margin = new System.Windows.Forms.Padding(2);
            this.battleListBox.Name = "battleListBox";
            this.battleListBox.Size = new System.Drawing.Size(222, 235);
            this.battleListBox.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.gameCharacterListBox);
            this.panel3.Controls.Add(this.changeWeaponBtn);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(483, 9);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 524);
            this.panel3.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bowRadioButton);
            this.groupBox2.Controls.Add(this.knifeRadioButton);
            this.groupBox2.Controls.Add(this.swordRadioButton);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 334);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(161, 107);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Weapon";
            // 
            // bowRadioButton
            // 
            this.bowRadioButton.AutoSize = true;
            this.bowRadioButton.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bowRadioButton.Location = new System.Drawing.Point(13, 78);
            this.bowRadioButton.Name = "bowRadioButton";
            this.bowRadioButton.Size = new System.Drawing.Size(65, 25);
            this.bowRadioButton.TabIndex = 2;
            this.bowRadioButton.TabStop = true;
            this.bowRadioButton.Text = "Bow";
            this.bowRadioButton.UseVisualStyleBackColor = true;
            // 
            // knifeRadioButton
            // 
            this.knifeRadioButton.AutoSize = true;
            this.knifeRadioButton.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knifeRadioButton.Location = new System.Drawing.Point(13, 53);
            this.knifeRadioButton.Name = "knifeRadioButton";
            this.knifeRadioButton.Size = new System.Drawing.Size(77, 25);
            this.knifeRadioButton.TabIndex = 1;
            this.knifeRadioButton.TabStop = true;
            this.knifeRadioButton.Text = "Knife";
            this.knifeRadioButton.UseVisualStyleBackColor = true;
            // 
            // swordRadioButton
            // 
            this.swordRadioButton.AutoSize = true;
            this.swordRadioButton.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swordRadioButton.Location = new System.Drawing.Point(13, 28);
            this.swordRadioButton.Name = "swordRadioButton";
            this.swordRadioButton.Size = new System.Drawing.Size(81, 25);
            this.swordRadioButton.TabIndex = 0;
            this.swordRadioButton.TabStop = true;
            this.swordRadioButton.Text = "Sword";
            this.swordRadioButton.UseVisualStyleBackColor = true;
            // 
            // gameCharacterListBox
            // 
            this.gameCharacterListBox.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameCharacterListBox.FormattingEnabled = true;
            this.gameCharacterListBox.Location = new System.Drawing.Point(16, 44);
            this.gameCharacterListBox.Margin = new System.Windows.Forms.Padding(2);
            this.gameCharacterListBox.Name = "gameCharacterListBox";
            this.gameCharacterListBox.Size = new System.Drawing.Size(201, 244);
            this.gameCharacterListBox.TabIndex = 27;
            // 
            // changeWeaponBtn
            // 
            this.changeWeaponBtn.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeWeaponBtn.Location = new System.Drawing.Point(16, 479);
            this.changeWeaponBtn.Margin = new System.Windows.Forms.Padding(2);
            this.changeWeaponBtn.Name = "changeWeaponBtn";
            this.changeWeaponBtn.Size = new System.Drawing.Size(200, 35);
            this.changeWeaponBtn.TabIndex = 25;
            this.changeWeaponBtn.Text = "Change Weapon";
            this.changeWeaponBtn.UseVisualStyleBackColor = true;
            this.changeWeaponBtn.Click += new System.EventHandler(this.changeWeaponBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 25;
            this.label4.Text = "Character";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 551);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Battle";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton trollRadioButton;
        private System.Windows.Forms.RadioButton knightRadioButton;
        private System.Windows.Forms.RadioButton queenRadioButton;
        private System.Windows.Forms.RadioButton kingRadioButton;
        private System.Windows.Forms.TextBox characterNameTextBox;
        private System.Windows.Forms.Button addCharacterButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button battleButton;
        private System.Windows.Forms.CheckedListBox battleCharactersListBox;
        private System.Windows.Forms.ListBox battleListBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button changeWeaponBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox gameCharacterListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton bowRadioButton;
        private System.Windows.Forms.RadioButton knifeRadioButton;
        private System.Windows.Forms.RadioButton swordRadioButton;
    }
}

