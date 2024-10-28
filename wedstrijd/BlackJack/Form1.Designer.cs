namespace BlackJack
{
    partial class blackjack
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
            this.dealerGetal = new System.Windows.Forms.TextBox();
            this.spelerGetal = new System.Windows.Forms.TextBox();
            this.standButton = new System.Windows.Forms.Button();
            this.hitButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.resultaat = new System.Windows.Forms.TextBox();
            this.spelerKaarten = new System.Windows.Forms.ListBox();
            this.dealerKaarten = new System.Windows.Forms.ListBox();
            this.spelerLabel = new System.Windows.Forms.Label();
            this.dealerLabel = new System.Windows.Forms.Label();
            this.blackjackLabel = new System.Windows.Forms.Label();
            this.totaalLabel1 = new System.Windows.Forms.Label();
            this.totaalLabel2 = new System.Windows.Forms.Label();
            this.gewonnenLabel = new System.Windows.Forms.Label();
            this.gelijkLabel = new System.Windows.Forms.Label();
            this.verlorenLabel = new System.Windows.Forms.Label();
            this.gewonnenAantal = new System.Windows.Forms.TextBox();
            this.gelijkAantal = new System.Windows.Forms.TextBox();
            this.verlorenAantal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dealerGetal
            // 
            this.dealerGetal.Location = new System.Drawing.Point(560, 330);
            this.dealerGetal.Name = "dealerGetal";
            this.dealerGetal.ReadOnly = true;
            this.dealerGetal.ShortcutsEnabled = false;
            this.dealerGetal.Size = new System.Drawing.Size(50, 22);
            this.dealerGetal.TabIndex = 2;
            // 
            // spelerGetal
            // 
            this.spelerGetal.Location = new System.Drawing.Point(65, 330);
            this.spelerGetal.Name = "spelerGetal";
            this.spelerGetal.ReadOnly = true;
            this.spelerGetal.Size = new System.Drawing.Size(50, 22);
            this.spelerGetal.TabIndex = 3;
            // 
            // standButton
            // 
            this.standButton.Location = new System.Drawing.Point(207, 216);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(75, 75);
            this.standButton.TabIndex = 4;
            this.standButton.Text = "Stand";
            this.standButton.UseVisualStyleBackColor = true;
            this.standButton.Click += new System.EventHandler(this.standButton_Click);
            // 
            // hitButton
            // 
            this.hitButton.Location = new System.Drawing.Point(207, 95);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(75, 75);
            this.hitButton.TabIndex = 5;
            this.hitButton.Text = "Hit";
            this.hitButton.UseVisualStyleBackColor = true;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(373, 216);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(75, 75);
            this.restartButton.TabIndex = 6;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // resultaat
            // 
            this.resultaat.Location = new System.Drawing.Point(361, 162);
            this.resultaat.Name = "resultaat";
            this.resultaat.ReadOnly = true;
            this.resultaat.Size = new System.Drawing.Size(100, 22);
            this.resultaat.TabIndex = 7;
            this.resultaat.TextChanged += new System.EventHandler(this.resultaat_TextChanged);
            // 
            // spelerKaarten
            // 
            this.spelerKaarten.FormattingEnabled = true;
            this.spelerKaarten.ItemHeight = 16;
            this.spelerKaarten.Location = new System.Drawing.Point(33, 95);
            this.spelerKaarten.Name = "spelerKaarten";
            this.spelerKaarten.Size = new System.Drawing.Size(120, 196);
            this.spelerKaarten.TabIndex = 8;
            // 
            // dealerKaarten
            // 
            this.dealerKaarten.FormattingEnabled = true;
            this.dealerKaarten.ItemHeight = 16;
            this.dealerKaarten.Location = new System.Drawing.Point(523, 95);
            this.dealerKaarten.Name = "dealerKaarten";
            this.dealerKaarten.Size = new System.Drawing.Size(120, 196);
            this.dealerKaarten.TabIndex = 9;
            // 
            // spelerLabel
            // 
            this.spelerLabel.AutoSize = true;
            this.spelerLabel.Location = new System.Drawing.Point(68, 54);
            this.spelerLabel.Name = "spelerLabel";
            this.spelerLabel.Size = new System.Drawing.Size(47, 16);
            this.spelerLabel.TabIndex = 10;
            this.spelerLabel.Text = "Speler";
            // 
            // dealerLabel
            // 
            this.dealerLabel.AutoSize = true;
            this.dealerLabel.Location = new System.Drawing.Point(557, 33);
            this.dealerLabel.Name = "dealerLabel";
            this.dealerLabel.Size = new System.Drawing.Size(48, 16);
            this.dealerLabel.TabIndex = 11;
            this.dealerLabel.Text = "Dealer";
            // 
            // blackjackLabel
            // 
            this.blackjackLabel.AutoSize = true;
            this.blackjackLabel.Location = new System.Drawing.Point(376, 111);
            this.blackjackLabel.Name = "blackjackLabel";
            this.blackjackLabel.Size = new System.Drawing.Size(65, 16);
            this.blackjackLabel.TabIndex = 12;
            this.blackjackLabel.Text = "blackjack";
            // 
            // totaalLabel1
            // 
            this.totaalLabel1.AutoSize = true;
            this.totaalLabel1.Location = new System.Drawing.Point(66, 311);
            this.totaalLabel1.Name = "totaalLabel1";
            this.totaalLabel1.Size = new System.Drawing.Size(49, 16);
            this.totaalLabel1.TabIndex = 13;
            this.totaalLabel1.Text = "Totaal:";
            // 
            // totaalLabel2
            // 
            this.totaalLabel2.AutoSize = true;
            this.totaalLabel2.Location = new System.Drawing.Point(561, 311);
            this.totaalLabel2.Name = "totaalLabel2";
            this.totaalLabel2.Size = new System.Drawing.Size(49, 16);
            this.totaalLabel2.TabIndex = 14;
            this.totaalLabel2.Text = "Totaal:";
            // 
            // gewonnenLabel
            // 
            this.gewonnenLabel.AutoSize = true;
            this.gewonnenLabel.Location = new System.Drawing.Point(196, 390);
            this.gewonnenLabel.Name = "gewonnenLabel";
            this.gewonnenLabel.Size = new System.Drawing.Size(71, 16);
            this.gewonnenLabel.TabIndex = 15;
            this.gewonnenLabel.Text = "Gewonnen";
            // 
            // gelijkLabel
            // 
            this.gelijkLabel.AutoSize = true;
            this.gelijkLabel.Location = new System.Drawing.Point(305, 390);
            this.gelijkLabel.Name = "gelijkLabel";
            this.gelijkLabel.Size = new System.Drawing.Size(67, 16);
            this.gelijkLabel.TabIndex = 16;
            this.gelijkLabel.Text = "Gelijkspel";
            // 
            // verlorenLabel
            // 
            this.verlorenLabel.AutoSize = true;
            this.verlorenLabel.Location = new System.Drawing.Point(413, 389);
            this.verlorenLabel.Name = "verlorenLabel";
            this.verlorenLabel.Size = new System.Drawing.Size(58, 16);
            this.verlorenLabel.TabIndex = 17;
            this.verlorenLabel.Text = "Verloren";
            // 
            // gewonnenAantal
            // 
            this.gewonnenAantal.Enabled = false;
            this.gewonnenAantal.Location = new System.Drawing.Point(182, 407);
            this.gewonnenAantal.Name = "gewonnenAantal";
            this.gewonnenAantal.Size = new System.Drawing.Size(100, 22);
            this.gewonnenAantal.TabIndex = 18;
            // 
            // gelijkAantal
            // 
            this.gelijkAantal.Enabled = false;
            this.gelijkAantal.Location = new System.Drawing.Point(288, 407);
            this.gelijkAantal.Name = "gelijkAantal";
            this.gelijkAantal.Size = new System.Drawing.Size(100, 22);
            this.gelijkAantal.TabIndex = 19;
            // 
            // verlorenAantal
            // 
            this.verlorenAantal.Enabled = false;
            this.verlorenAantal.Location = new System.Drawing.Point(394, 407);
            this.verlorenAantal.Name = "verlorenAantal";
            this.verlorenAantal.Size = new System.Drawing.Size(100, 22);
            this.verlorenAantal.TabIndex = 20;
            // 
            // blackjack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(682, 459);
            this.Controls.Add(this.verlorenAantal);
            this.Controls.Add(this.gelijkAantal);
            this.Controls.Add(this.gewonnenAantal);
            this.Controls.Add(this.verlorenLabel);
            this.Controls.Add(this.gelijkLabel);
            this.Controls.Add(this.gewonnenLabel);
            this.Controls.Add(this.totaalLabel2);
            this.Controls.Add(this.totaalLabel1);
            this.Controls.Add(this.blackjackLabel);
            this.Controls.Add(this.dealerLabel);
            this.Controls.Add(this.spelerLabel);
            this.Controls.Add(this.dealerKaarten);
            this.Controls.Add(this.spelerKaarten);
            this.Controls.Add(this.resultaat);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.standButton);
            this.Controls.Add(this.spelerGetal);
            this.Controls.Add(this.dealerGetal);
            this.Name = "blackjack";
            this.Text = "blackjack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox dealerGetal;
        private System.Windows.Forms.TextBox spelerGetal;
        private System.Windows.Forms.Button standButton;
        private System.Windows.Forms.Button hitButton;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.TextBox resultaat;
        private System.Windows.Forms.ListBox spelerKaarten;
        private System.Windows.Forms.ListBox dealerKaarten;
        private System.Windows.Forms.Label spelerLabel;
        private System.Windows.Forms.Label dealerLabel;
        private System.Windows.Forms.Label blackjackLabel;
        private System.Windows.Forms.Label totaalLabel1;
        private System.Windows.Forms.Label totaalLabel2;
        private System.Windows.Forms.Label gewonnenLabel;
        private System.Windows.Forms.Label gelijkLabel;
        private System.Windows.Forms.Label verlorenLabel;
        private System.Windows.Forms.TextBox gewonnenAantal;
        private System.Windows.Forms.TextBox gelijkAantal;
        private System.Windows.Forms.TextBox verlorenAantal;
    }
}

