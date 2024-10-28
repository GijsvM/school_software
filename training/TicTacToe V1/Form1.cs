
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolBoxOpdracht1
{
    public partial class Form1 : Form
    {

        bool Speler_heeft_1 = false;
        bool Speler_heeft_2 = false;
        bool Speler_heeft_3 = false;
        bool Speler_heeft_4 = false;
        bool Speler_heeft_5 = false;
        bool Speler_heeft_6 = false;
        bool Speler_heeft_7 = false;
        bool Speler_heeft_8 = false;
        bool Speler_heeft_9 = false;

        bool AI_heeft_1 = false;
        bool AI_heeft_2 = false;
        bool AI_heeft_3 = false;
        bool AI_heeft_4 = false;
        bool AI_heeft_5 = false;
        bool AI_heeft_6 = false;
        bool AI_heeft_7 = false;
        bool AI_heeft_8 = false;
        bool AI_heeft_9 = false;
        int beurt = 1;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Tic Tac Toe";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void plek1X(object sender, EventArgs e)
        {
            plek1.Enabled = false;
            plek1.Text = "X";
            Speler_heeft_1 = true;
            AI();
        }
        private void plek2X(object sender, EventArgs e)
        {
            plek2.Enabled = false;
            plek2.Text = "X";
            Speler_heeft_2 = true;
            AI();
        }
        private void plek3X(object sender, EventArgs e)
        {
            plek3.Enabled = false;
            plek3.Text = "X";
            Speler_heeft_3 = true;
            AI();
        }
        private void plek4X(object sender, EventArgs e)
        {
            plek4.Enabled = false;
            plek4.Text = "X";
            Speler_heeft_4 = true;
            AI();
        }
        private void plek5X(object sender, EventArgs e)
        {
            plek5.Enabled = false;
            plek5.Text = "X";
            Speler_heeft_5 = true;
            AI();
        }
        private void plek6X(object sender, EventArgs e)
        {
            plek6.Enabled = false;
            plek6.Text = "X";
            Speler_heeft_6 = true;
            AI();
        }
        private void plek7X(object sender, EventArgs e)
        {
            plek7.Enabled = false;
            plek7.Text = "X";
            Speler_heeft_7 = true;
            AI();
        }
        private void plek8X(object sender, EventArgs e)
        {
            plek8.Enabled = false;
            plek8.Text = "X";
            Speler_heeft_8 = true;
            AI();
        }
        private void plek9X(object sender, EventArgs e)
        {
            plek9.Enabled = false;
            plek9.Text = "X";
            Speler_heeft_9 = true;
            AI();
        }

        //het algoritme pakt een plek:
        private void plek1O()
        {
            plek1.Enabled = false;
            plek1.Text = "O";
            AI_heeft_1 = true;
            speler();
        }
        private void plek2O()
        {
            plek2.Enabled = false;
            plek2.Text = "O";
            AI_heeft_2 = true;
            speler();
        }
        private void plek3O()
        {
            plek3.Enabled = false;
            plek3.Text = "O";
            AI_heeft_3 = true;
            speler();
        }
        private void plek4O()
        {
            plek4.Enabled = false;
            plek4.Text = "O";
            AI_heeft_4 = true;
            speler();
        }
        private void plek5O()
        {
            plek5.Enabled = false;
            plek5.Text = "O";
            AI_heeft_5 = true;
            speler();
        }
        private void plek6O()
        {
            plek6.Enabled = false;
            plek6.Text = "O";
            AI_heeft_6 = true;
            speler();
        }
        private void plek7O()
        {
            plek7.Enabled = false;
            plek7.Text = "O";
            AI_heeft_7 = true;
            speler();
        }
        private void plek8O()
        {
            plek8.Enabled = false;
            plek8.Text = "O";
            AI_heeft_8 = true;
            speler();
        }
        private void plek9O()
        {
            plek9.Enabled = false;
            plek9.Text = "O";
            AI_heeft_9 = true;
            speler();
        }

        private void AI()
        {
            checkForWin();

            if (beurt == 1)
            {
                if (plek9.Enabled == true)
                {
                    plek9O();
                }
                else if (plek3.Enabled == true)
                {
                    plek3O();
                }
                else if (plek7.Enabled == true)
                {
                    plek7O();
                }
                else if (plek1.Enabled == true)
                {
                    plek1O();
                }
            }
            if (beurt >= 2)
            {
                if(Speler_heeft_1 && Speler_heeft_2 && plek3.Enabled)
                {
                    plek3O();
                }
                else if(Speler_heeft_2 && Speler_heeft_3 && plek1.Enabled)
                {
                    plek1O();
                }
                else if (Speler_heeft_1 && Speler_heeft_3 && plek2.Enabled)
                {
                    plek2O();
                }
                else if (Speler_heeft_4 && Speler_heeft_5 && plek6.Enabled)
                {
                    plek6O();
                }
                else if (Speler_heeft_6 && Speler_heeft_5 && plek4.Enabled)
                {
                    plek4O();
                }
                else if (Speler_heeft_6 && Speler_heeft_4 && plek5.Enabled)
                {
                    plek5O();
                }
                else if (Speler_heeft_8 && Speler_heeft_9 && plek7.Enabled)
                {
                    plek7O();
                }
                else if (Speler_heeft_7 && Speler_heeft_9 && plek8.Enabled)
                {
                    plek8O();
                }
                else if (Speler_heeft_8 && Speler_heeft_7 && plek9.Enabled)
                {
                    plek9O();
                }
                else if (Speler_heeft_1 && Speler_heeft_4 && plek7.Enabled)
                {
                    plek7O();
                }
                else if (Speler_heeft_1 && Speler_heeft_7 && plek4.Enabled)
                {
                    plek4O();
                }
                else if (Speler_heeft_4 && Speler_heeft_7 && plek1.Enabled)
                {
                    plek1O();
                }
                else if (Speler_heeft_2 && Speler_heeft_5 && plek8.Enabled)
                {
                    plek8O();
                }
                else if (Speler_heeft_2 && Speler_heeft_8 && plek5.Enabled)
                {
                    plek5O();
                }
                else if (Speler_heeft_8 && Speler_heeft_5 && plek2.Enabled)
                {
                    plek2O();
                }
                else if (Speler_heeft_3 && Speler_heeft_6 && plek9.Enabled)
                {
                    plek9O();
                }
                else if (Speler_heeft_6 && Speler_heeft_9 && plek3.Enabled)
                {
                    plek3O();
                }
                else if (Speler_heeft_3 && Speler_heeft_9 && plek6.Enabled)
                {
                    plek6O();
                }
                else if (Speler_heeft_1 && Speler_heeft_5 && plek9.Enabled)
                {
                    plek9O();
                }
                else if (Speler_heeft_1 && Speler_heeft_9 && plek5.Enabled)
                {
                    plek5O();
                }
                else if (Speler_heeft_9 && Speler_heeft_5 && plek1.Enabled)
                {
                    plek1O();
                }
                else if (Speler_heeft_3 && Speler_heeft_5 && plek7.Enabled)
                {
                    plek7O();
                }
                else if (Speler_heeft_3 && Speler_heeft_7 && plek5.Enabled)
                {
                    plek5O();
                }
                else if (Speler_heeft_5 && Speler_heeft_7 && plek3.Enabled)
                {
                    plek3O();
                }
            }

            


            checkForWin();
        }
        private void speler()
            {
            beurt++;
            checkForWin();

            }
        private void checkForWin()
        {
            if ((Speler_heeft_1 == true) && (Speler_heeft_2 == true) && (Speler_heeft_3 == true) ){
                spelerWint();
                }
            else if ((Speler_heeft_4 == true) && (Speler_heeft_5 == true) && (Speler_heeft_6 == true))
            {
                spelerWint();
            }
            else if ((Speler_heeft_7 == true) && (Speler_heeft_8 == true) && (Speler_heeft_9 == true))
            {
                spelerWint();
            }
            else if ((Speler_heeft_1 == true) && (Speler_heeft_4 == true) && (Speler_heeft_7 == true))
            {
                spelerWint();
            }
            else if ((Speler_heeft_2 == true) && (Speler_heeft_5 == true) && (Speler_heeft_8 == true))
            {
                spelerWint();
            }
            else if ((Speler_heeft_3 == true) && (Speler_heeft_6 == true) && (Speler_heeft_9 == true))
            {
                spelerWint();
            }
            else if ((Speler_heeft_1 == true) && (Speler_heeft_5 == true) && (Speler_heeft_9 == true))
            {
                spelerWint();
            }
            else if ((Speler_heeft_3 == true) && (Speler_heeft_5 == true) && (Speler_heeft_7 == true))
            {
                spelerWint();
            }
            else if ((AI_heeft_1 == true) && (AI_heeft_2 == true) && (AI_heeft_3 == true))
            {
                AIWint();
            }
            else if ((AI_heeft_4 == true) && (AI_heeft_5 == true) && (AI_heeft_6 == true))
            {
                AIWint();
            }
            else if ((AI_heeft_7 == true) && (AI_heeft_8 == true) && (AI_heeft_9 == true))
            {
                AIWint();
            }
            else if ((AI_heeft_1 == true) && (AI_heeft_4 == true) && (AI_heeft_7 == true))
            {
                AIWint();
            }
            else if ((AI_heeft_2 == true) && (AI_heeft_5 == true) && (AI_heeft_8 == true))
            {
                AIWint();
            }
            else if ((AI_heeft_3 == true) && (AI_heeft_6 == true) && (AI_heeft_9 == true))
            {
                AIWint();
            }
            else if ((AI_heeft_1 == true) && (AI_heeft_5 == true) && (AI_heeft_9 == true))
            {
                AIWint();
            }
            else if ((AI_heeft_3 == true) && (AI_heeft_5 == true) && (AI_heeft_7 == true))
            {
                AIWint();
            }
            else if(!plek1.Enabled && !plek2.Enabled && !plek3.Enabled && !plek4.Enabled && !plek5.Enabled && !plek6.Enabled && !plek7.Enabled && !plek8.Enabled && !plek9.Enabled)
            {
                gelijkSpel();
            }


        }
        private void spelerWint()
        {
            DialogResult dialogResult = MessageBox.Show("Je hebt gewonnen, wil je opnieuw spelen?", "Gewonnen", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Restart();
            }
            else
            {
                Application.Exit();
            }
        }
        private void gelijkSpel()
        {
            DialogResult dialogResult = MessageBox.Show("Het is gelijkspel, wil je opnieuw spelen?", "Gelijkspel", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Restart();
            }
            else
            {
                Application.Exit();
            }
        }
        private void AIWint()
        {
            DialogResult dialogResult = MessageBox.Show("Je hebt verloren, wil je opnieuw spelen?", "Verloren", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Restart();
            }
            else
            {
                Application.Exit();
            }
        }
    } }

