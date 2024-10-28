namespace TVapplicatie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aanKnop = new System.Windows.Forms.RadioButton();
            this.uitKnop = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.aanOfUit = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.zenderInvoegen = new System.Windows.Forms.TextBox();
            this.voegZenderToe = new System.Windows.Forms.Button();
            this.terugButton = new System.Windows.Forms.Button();
            this.verderButton = new System.Windows.Forms.Button();
            this.zenderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.MaximumSize = new System.Drawing.Size(1333, 1231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "TV van Harry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "aan of uit";
            // 
            // aanKnop
            // 
            this.aanKnop.AutoSize = true;
            this.aanKnop.Location = new System.Drawing.Point(62, 142);
            this.aanKnop.Name = "aanKnop";
            this.aanKnop.Size = new System.Drawing.Size(51, 20);
            this.aanKnop.TabIndex = 4;
            this.aanKnop.TabStop = true;
            this.aanKnop.Text = "aan";
            this.aanKnop.UseVisualStyleBackColor = true;
            this.aanKnop.CheckedChanged += new System.EventHandler(this.aanKnop_CheckedChanged);
            // 
            // uitKnop
            // 
            this.uitKnop.AutoSize = true;
            this.uitKnop.Location = new System.Drawing.Point(62, 169);
            this.uitKnop.Name = "uitKnop";
            this.uitKnop.Size = new System.Drawing.Size(41, 20);
            this.uitKnop.TabIndex = 5;
            this.uitKnop.TabStop = true;
            this.uitKnop.Text = "uit";
            this.uitKnop.UseVisualStyleBackColor = true;
            this.uitKnop.CheckedChanged += new System.EventHandler(this.uitKnop_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(233, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 197);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // aanOfUit
            // 
            this.aanOfUit.AutoSize = true;
            this.aanOfUit.Location = new System.Drawing.Point(306, 120);
            this.aanOfUit.Name = "aanOfUit";
            this.aanOfUit.Size = new System.Drawing.Size(44, 16);
            this.aanOfUit.TabIndex = 7;
            this.aanOfUit.Text = "uhdvo";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(620, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(130, 388);
            this.listBox1.TabIndex = 8;
            // 
            // zenderInvoegen
            // 
            this.zenderInvoegen.Location = new System.Drawing.Point(385, 365);
            this.zenderInvoegen.Name = "zenderInvoegen";
            this.zenderInvoegen.Size = new System.Drawing.Size(100, 22);
            this.zenderInvoegen.TabIndex = 9;
            // 
            // voegZenderToe
            // 
            this.voegZenderToe.Location = new System.Drawing.Point(506, 364);
            this.voegZenderToe.Name = "voegZenderToe";
            this.voegZenderToe.Size = new System.Drawing.Size(75, 23);
            this.voegZenderToe.TabIndex = 10;
            this.voegZenderToe.Text = "Voeg toe";
            this.voegZenderToe.UseVisualStyleBackColor = true;
            this.voegZenderToe.Click += new System.EventHandler(this.button1_Click);
            // 
            // terugButton
            // 
            this.terugButton.Location = new System.Drawing.Point(233, 290);
            this.terugButton.Name = "terugButton";
            this.terugButton.Size = new System.Drawing.Size(75, 23);
            this.terugButton.TabIndex = 11;
            this.terugButton.Text = "terug";
            this.terugButton.UseVisualStyleBackColor = true;
            this.terugButton.Click += new System.EventHandler(this.terugButton_Click);
            // 
            // verderButton
            // 
            this.verderButton.Location = new System.Drawing.Point(351, 290);
            this.verderButton.Name = "verderButton";
            this.verderButton.Size = new System.Drawing.Size(75, 23);
            this.verderButton.TabIndex = 12;
            this.verderButton.Text = "verder";
            this.verderButton.UseVisualStyleBackColor = true;
            this.verderButton.Click += new System.EventHandler(this.verderButton_Click);
            // 
            // zenderLabel
            // 
            this.zenderLabel.AutoSize = true;
            this.zenderLabel.Location = new System.Drawing.Point(306, 146);
            this.zenderLabel.Name = "zenderLabel";
            this.zenderLabel.Size = new System.Drawing.Size(44, 16);
            this.zenderLabel.TabIndex = 14;
            this.zenderLabel.Text = "uhdvo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zenderLabel);
            this.Controls.Add(this.verderButton);
            this.Controls.Add(this.terugButton);
            this.Controls.Add(this.voegZenderToe);
            this.Controls.Add(this.zenderInvoegen);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.aanOfUit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uitKnop);
            this.Controls.Add(this.aanKnop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton aanKnop;
        private System.Windows.Forms.RadioButton uitKnop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label aanOfUit;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox zenderInvoegen;
        private System.Windows.Forms.Button voegZenderToe;
        private System.Windows.Forms.Button terugButton;
        private System.Windows.Forms.Button verderButton;
        private System.Windows.Forms.Label zenderLabel;
    }
}

