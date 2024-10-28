//Leerdoelen die hierinstaan:

//    variabele
//    type int, string
//    conditional statements
//    if ... else
    
//    Array
//    method
//    leesbaarheid / onderhoudbaarheid



using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TVapplicatie
{
    public partial class Form1 : Form
    {
        int i = 3;
        string[] zenderArray = new string[1000];
        int huidigeZender = 1;
        int aantalZendersInArray = 2;

        public Form1()
        {
            InitializeComponent();
            main();
        }

        private void main()
        {
            zenderArray[0] = "NPO1";
            zenderArray[1] = "NPO2";
            zenderArray[2] = "NPO3";
            listBox1.DataSource = zenderArray;
            veranderHuidigeZender(0);
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(zenderInvoegen.Text))
            {
                if (i < zenderArray.Length)
                {
                    zenderArray[i] = zenderInvoegen.Text;
                    i++;
                    aantalZendersInArray++;
                    UpdateListBox();
                    zenderInvoegen.Clear();
                }
                else
                {
                    MessageBox.Show("Zender lijst zit vol");
                }
            }
            else
            {
                MessageBox.Show("Voeg een valide zender toe");
            }
        }
        
        private void veranderHuidigeZender(int zenderNr)
        {

            zenderLabel.Text = zenderArray[zenderNr];

        }

        private void UpdateListBox()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = zenderArray.Where(z => !string.IsNullOrEmpty(z)).ToArray();
        }

        private void terugButton_Click(object sender, EventArgs e)
        {
            huidigeZender--;
            if (huidigeZender < 0)
            {
                veranderHuidigeZender(aantalZendersInArray);
                huidigeZender = aantalZendersInArray;
            }
            else
            {
                veranderHuidigeZender(huidigeZender);
            }
        }

        private void verderButton_Click(object sender, EventArgs e)
        {
            if (huidigeZender >= aantalZendersInArray)
            {
                veranderHuidigeZender(0);
                huidigeZender = 0;
            }
            else
            {
                huidigeZender++;
                veranderHuidigeZender(huidigeZender);
            }
        }
        private void aanKnop_CheckedChanged(object sender, EventArgs e)
        {
            aanOfUit.Text = "aan";
        }

        private void uitKnop_CheckedChanged(object sender, EventArgs e)
        {
            aanOfUit.Text = "uit";
        }
    }
}
