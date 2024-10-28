using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Windows.Forms;


namespace BlackJack
{
    public partial class blackjack : Form
    {
        string[] kaartenHart = new string[13];
        string[] kaartenRuit = new string[13];
        string[] kaartenSchop = new string[13];
        string[] kaartenKlaver = new string[13];
        int spelerTotaal;
        int dealerTotaal;
        bool stand = false;
        bool bust = false;
        string winnaar;
        string winnaarPotje;
        int gewonnen;
        int gelijkspel;
        int verloren;
        int aantalAasSpeler;
        int aantalAasDealer;
        List<string> spelerKaartLijst = new List<string>();
        List<string> dealerKaartLijst = new List<string>();

        public blackjack()
        {
            InitializeComponent();
           
            string[] waardes = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "K", "Q", "A" };
            for (int i = 0; i < waardes.Length; i++)
            {
                kaartenHart.SetValue(waardes[i], i);
                kaartenKlaver.SetValue(waardes[i], i);
                kaartenRuit.SetValue(waardes[i], i);
                kaartenSchop.SetValue(waardes[i], i);
            }

            startSpel();
        }
        public void startSpel()
        {
            spelerKaarten.DataSource = spelerKaartLijst;
            dealerKaarten.DataSource = dealerKaartLijst;
            krijgKaarten("speler");
            krijgKaarten("speler");
            krijgKaarten("dealer");
            if (stand || bust)
            {
                krijgKaarten("dealer");
            }
            
        }
        public void krijgKaarten(string wie)
        {
            string kaart = "";
            bool kaartPakken = true;
            string kleur = "";

            while (kaartPakken)
            {
                int kleurRandom = new Random().Next(1, 5);
                int kaartRandom = new Random().Next(0, 13);

                switch (kleurRandom)
                {
                    case 1:
                        kaart = kaartenHart[kaartRandom];
                        kleur = "Harten";
                        if (kaart == "")
                        {
                            break;
                        }
                        else
                        {
                            kaartenHart[kaartRandom] = "";
                            kaartPakken = false;
                            break;
                        }
                    case 2:
                        kaart = kaartenRuit[kaartRandom];
                        kleur = "Ruiten";
                        if (kaart == "")
                        {
                            break;
                        }
                        else
                        {
                            kaartenRuit[kaartRandom] = "";
                            kaartPakken = false;
                            break;
                        }
                    case 3:
                        kaart = kaartenSchop[kaartRandom];
                        kleur = "Schoppen";
                        if (kaart == "")
                        {
                            break;
                        }
                        else
                        {
                            
                        kaartenSchop[kaartRandom] = "";
                            kaartPakken = false;
                            break;
                        }
                    case 4:
                        kaart = kaartenKlaver[kaartRandom];
                        kleur = "Klaveren";
                        if (kaart == "")
                        {
                            break;
                        }
                        else
                        {
                            kaartenKlaver[kaartRandom] = "";
                            kaartPakken = false;
                            break;
                        }
                    
                }

            }
            if (wie == "speler")
            {
                spelerKaartLijst.Add(kleur + " " + kaart);
                addToTotaal(wie, kaart);
                
            }
            else
            {
                dealerKaartLijst.Add(kleur + " " + kaart);
                addToTotaal(wie, kaart);
                
            }
            updateViews();
            checkBustStand();

        }
        private void addToTotaal(string wie, string nummer)
        {
            if (wie == "speler")
            {
                switch (nummer)
                {
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                    case "10":
                        spelerTotaal += Int32.Parse(nummer);
                        break;

                    case "J":
                    case "Q":
                    case "K":
                        spelerTotaal += 10;
                        break;
                    case "A":
                        spelerTotaal += 11;
                        aantalAasSpeler += 1;
                        break;
                }
            }
            else
            {
                switch (nummer)
                {
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                    case "10":
                        dealerTotaal += Int32.Parse(nummer);
                        break;
                    case "J":
                    case "Q": 
                    case "K":
                        dealerTotaal += 10;
                        break;
                    case "A":
                        dealerTotaal += 11;
                        aantalAasDealer++;
                        break;
                }
            }
            
        }
            private void checkBustStand()
        {
            if (spelerTotaal > 21)
            {
                if (aantalAasSpeler > 0) {
                    spelerTotaal -= 10;
                    aantalAasSpeler--;
                    updateViews();
                } 
                else {

                    bust = true;
                    hitButton.Enabled = false;
                    standButton.Enabled = false;
                    resultaat.Text = "Busted";
                    checkForWinner();
                }
            }
            while ((stand == true))
            {
                hitButton.Enabled = false;
                standButton.Enabled = false;
                if (dealerTotaal < 17)
                {
                    krijgKaarten("dealer");
                    break;
                }
                else if (dealerTotaal > 21 && aantalAasDealer > 0)
                {
                    dealerTotaal -= 10;
                    aantalAasDealer--;
                    updateViews();
                }
                else
                {
                    winnaarPotje = checkForWinner();
                    break;
                }
            }
        }
        private void updateViews()
        {
            spelerGetal.Text = spelerTotaal.ToString();
            dealerGetal.Text = dealerTotaal.ToString();
            dealerKaarten.DataSource = null;
            dealerKaarten.DataSource = dealerKaartLijst;
            spelerKaarten.DataSource = null;
            spelerKaarten.DataSource = spelerKaartLijst;
            resultaat.Text = winnaar;

        }
        private string checkForWinner()
        {
            if((dealerTotaal > 21) || (spelerTotaal > dealerTotaal && !bust))
            {
                
                winnaar = "speler";
                resultaat.Text = winnaar + " wint";
                gewonnen++;
                return winnaar;

            }
            else if(spelerTotaal == dealerTotaal){
                winnaar = "Gelijkspel";
                resultaat.Text = winnaar;
                gelijkspel++;
                return winnaar;

            }
            else if (bust)
            {
                winnaar = "dealer";
                resultaat.Text = winnaar + " wint";
                verloren++;
                return winnaar;
            }
            else
            {
                winnaar = "dealer";
                resultaat.Text = winnaar + " wint";
                verloren++;
                return winnaar;
            }
        }

        private void standButton_Click(object sender, EventArgs e)
        {
            stand = true;
            checkBustStand();
        }

        private void resultaat_TextChanged(object sender, EventArgs e)
        {

        }

        private void hitButton_Click(object sender, EventArgs e)
        {
            krijgKaarten("speler");
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            string gelukt = init(43576980.5467);

        }

        private string init(double id)
        {
            if (id == 43576980.5467)
            {
                string[] waardes = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "K", "Q", "A" };
                for (int i = 0; i < waardes.Length; i++)
                {
                    kaartenHart.SetValue(waardes[i], i);
                    kaartenKlaver.SetValue(waardes[i], i);
                    kaartenRuit.SetValue(waardes[i], i);
                    kaartenSchop.SetValue(waardes[i], i);
                }
                spelerTotaal = 0;
                dealerTotaal = 0;
                stand = false;
                bust = false;
                winnaar = "";
                winnaarPotje = "";
                aantalAasSpeler = 0;
                aantalAasDealer = 0;
                updateViews();
                hitButton.Enabled = true;
                standButton.Enabled = true;
                dealerKaartLijst.Clear();
                spelerKaartLijst.Clear();
                gewonnenAantal.Text = gewonnen + "";
                gelijkAantal.Text = gelijkspel + "";
                verlorenAantal.Text = verloren + "";
                startSpel();
                return "gelukt";
            }
            else
            {
                return "nee";
            }
        }
    }
}