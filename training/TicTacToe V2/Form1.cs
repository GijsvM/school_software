
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
        bool winnaar = false;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Tic Tac Toe";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void plekAanSpelerKoppelen(int vakjeNr, String speler)
        {
            String[] vakjeArray = { "leeg", "plek1", "plek2", "plek3", "plek4", "plek5", "plek6", "plek7", "plek8", "plek9" };
            String vakjeSelecteren = vakjeArray[vakjeNr];
            switch(vakjeSelecteren)
            {
                case "plek1":
                    plek1.Enabled = false;
                    plek1.Text = speler;
                    break;
                case "plek2":
                    plek2.Enabled = false;
                    plek2.Text = speler;
                    break;
                case "plek3":
                    plek3.Enabled = false;
                    plek3.Text = speler;
                    break;
                case "plek4":
                    plek4.Enabled = false;
                    plek4.Text = speler;
                    break;
                case "plek5":
                    plek5.Enabled = false;
                    plek5.Text = speler;
                    break;
                case "plek6":
                    plek6.Enabled = false;
                    plek6.Text = speler;
                    break;
                case "plek7":
                    plek7.Enabled = false;
                    plek7.Text = speler;
                    break;
                case "plek8":
                    plek8.Enabled = false;
                    plek8.Text = speler;
                    break;
                case "plek9":
                    plek9.Enabled = false;
                    plek9.Text = speler;
                    break;
            }
            spelerBeurt();
            AI();
        }
        
        private void AI()
        {
            checkForWin();
            if (beurt <= 1)
            {
                if (plek9.Enabled == true)
                {
                    plekAanSpelerKoppelen(9, "O");
                }
                else if (plek3.Enabled == true)
                {
                    plekAanSpelerKoppelen(3,"O");
                }
                
            }
            if (beurt >= 2)
            {
                block();
            }
            checkForWin();
        }
        private void block()
        {
            {
                if (Speler_heeft_1 && Speler_heeft_2 && plek3.Enabled)
                {
                    plekAanSpelerKoppelen(3, "O");
                }
                else if (Speler_heeft_2 && Speler_heeft_3 && plek1.Enabled)
                {
                    plekAanSpelerKoppelen(1,"O");
                }
                else if (Speler_heeft_1 && Speler_heeft_3 && plek2.Enabled)
                {
                    plekAanSpelerKoppelen(2,"O");
                }
                else if (Speler_heeft_4 && Speler_heeft_5 && plek6.Enabled)
                {
                    plekAanSpelerKoppelen(6,"O");
                }
                else if (Speler_heeft_6 && Speler_heeft_5 && plek4.Enabled)
                {
                    plekAanSpelerKoppelen(4, "O");
                }
                else if (Speler_heeft_6 && Speler_heeft_4 && plek5.Enabled)
                {
                    plekAanSpelerKoppelen(5, "O");
                }
                else if (Speler_heeft_8 && Speler_heeft_9 && plek7.Enabled)
                {
                    plekAanSpelerKoppelen(7, "O");
                }
                else if (Speler_heeft_7 && Speler_heeft_9 && plek8.Enabled)
                {
                    plekAanSpelerKoppelen(8, "O");
                }
                else if (Speler_heeft_8 && Speler_heeft_7 && plek9.Enabled)
                {
                    plekAanSpelerKoppelen(9, "O");
                }
                else if (Speler_heeft_1 && Speler_heeft_4 && plek7.Enabled)
                {
                    plekAanSpelerKoppelen(7, "O");
                }
                else if (Speler_heeft_1 && Speler_heeft_7 && plek4.Enabled)
                {
                    plekAanSpelerKoppelen(4, "O");
                }
                else if (Speler_heeft_4 && Speler_heeft_7 && plek1.Enabled)
                {
                    plekAanSpelerKoppelen(1, "O");
                }
                else if (Speler_heeft_2 && Speler_heeft_5 && plek8.Enabled)
                {
                    plekAanSpelerKoppelen(8, "O");
                }
                else if (Speler_heeft_2 && Speler_heeft_8 && plek5.Enabled)
                {
                    plekAanSpelerKoppelen(5, "O");
                }
                else if (Speler_heeft_8 && Speler_heeft_5 && plek2.Enabled)
                {
                    plekAanSpelerKoppelen(2, "O");
                }
                else if (Speler_heeft_3 && Speler_heeft_6 && plek9.Enabled)
                {
                    plekAanSpelerKoppelen(9, "O");
                }
                else if (Speler_heeft_6 && Speler_heeft_9 && plek3.Enabled)
                {
                    plekAanSpelerKoppelen(3, "O");
                }
                else if (Speler_heeft_3 && Speler_heeft_9 && plek6.Enabled)
                {
                    plekAanSpelerKoppelen(6, "O");
                }
                else if (Speler_heeft_1 && Speler_heeft_5 && plek9.Enabled)
                {
                    plekAanSpelerKoppelen(9, "O");
                }
                else if (Speler_heeft_1 && Speler_heeft_9 && plek5.Enabled)
                {
                    plekAanSpelerKoppelen(5, "O");
                }
                else if (Speler_heeft_9 && Speler_heeft_5 && plek1.Enabled)
                {
                    plekAanSpelerKoppelen(1, "O");
                }
                else if (Speler_heeft_3 && Speler_heeft_5 && plek7.Enabled)
                {
                    plekAanSpelerKoppelen(7, "O");
                }
                else if (Speler_heeft_3 && Speler_heeft_7 && plek5.Enabled)
                {
                    plekAanSpelerKoppelen(5, "O");
                }
                else if (Speler_heeft_5 && Speler_heeft_7 && plek3.Enabled)
                {
                    plekAanSpelerKoppelen(3, "O");
                }
            }
        }
        private void spelerBeurt()
            {
            beurt++;
            checkForWin();
            string beurtS = beurt + "";
            textBox1.Text = beurtS;
            }
        private void checkForWin()
        {
            
        }
        private void AIWint()
                {
                   
                    winnaar = true;
            textBox1.Text = "Je hebt verloren";
        }
        private void spelerWint()
        {
          
            winnaar = true;

            textBox1.Text = "Je hebt gewonnen";

        }
        private void gelijkSpel()
        {

            textBox1.Text = "Gelijk spel";
            
        }
        private void init()
        {
            
            plek1.Enabled = true;
            plek2.Enabled = true;
            plek3.Enabled = true;
            plek4.Enabled = true;
            plek5.Enabled = true;
            plek6.Enabled = true;
            plek7.Enabled = true;
            plek8.Enabled = true;
            plek9.Enabled = true;
            plek1.Text = "";
            plek2.Text = "";
            plek3.Text = "";
            plek4.Text = "";
            plek5.Text = "";
            plek6.Text = "";
            plek7.Text = "";
            plek8.Text = "";
            plek9.Text = "";
            Speler_heeft_1 = false;
            Speler_heeft_2 = false;
            Speler_heeft_3 = false;
            Speler_heeft_4 = false;
            Speler_heeft_5 = false;
            Speler_heeft_6 = false;
            Speler_heeft_7 = false;
            Speler_heeft_8 = false;
            Speler_heeft_9 = false;
            AI_heeft_1 = false; 
            AI_heeft_2 = false; 
            AI_heeft_3 = false;
            AI_heeft_4 = false;
            AI_heeft_5 = false;
            AI_heeft_6 = false;
            AI_heeft_7 = false;
            AI_heeft_8 = false;
            AI_heeft_9 = false;
            winnaar = false;
            beurt = 0;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            init();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void plek1_Click(object sender, EventArgs e)
        {
            plekAanSpelerKoppelen(1, "X");
        }

        private void plek2_Click(object sender, EventArgs e)
        {
            plekAanSpelerKoppelen(2, "X");
        }

        private void plek3_Click(object sender, EventArgs e)
        {
            plekAanSpelerKoppelen(3, "X");
        }

        private void plek4_Click(object sender, EventArgs e)
        {
            plekAanSpelerKoppelen(4, "X");
        }

        private void plek5_Click(object sender, EventArgs e)
        {
            plekAanSpelerKoppelen(5, "X");
        }

        private void plek6_Click(object sender, EventArgs e)
        {
            plekAanSpelerKoppelen(6, "X");
        }

        private void plek7_Click(object sender, EventArgs e)
        {
            plekAanSpelerKoppelen(7, "X");
        }

        private void plek8_Click(object sender, EventArgs e)
        {
            plekAanSpelerKoppelen(8, "X");
        }

        private void plek9_Click(object sender, EventArgs e)
        {
            plekAanSpelerKoppelen(9, "X");
        }
    } }