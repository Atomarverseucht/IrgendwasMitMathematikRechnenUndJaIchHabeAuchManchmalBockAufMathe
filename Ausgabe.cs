using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IrgendwasMitMathematikRechnenUndJaIchHabeAuchManchmalBockAufMathe
{
    public partial class Ausgabe : Form
    {
        public string rechenoperation = "0";
        public Ausgabe()
        {
            InitializeComponent();
        }

        private void btEingabe_Click(object sender, EventArgs e)
        {
            
        }

        private void Ausgabe_Load(object sender, EventArgs e)
        {
            
        }

        public void rechenAusgabe()
        { 
            switch (rechenoperation)
            {
                case "Primzahlen berechnen": primzahlen(); break;
                default: rtbAusgabe.Text = "Nicht unterstützte Rechenoperation!";
                    break;
            }
        }
        public void primzahlen()
        {
            rtbAusgabe.Text = "Primzahlen:\n";
            for (int i = 1; i < 10000; i++)
            {
                if(isPrime(i))
                {
                    rtbAusgabe.Text = rtbAusgabe.Text +", "+ i.ToString();
                }
            }
        }
        public bool isPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            var limit = Math.Ceiling(Math.Sqrt(number)); //hoisting the loop limit

            for (int i = 2; i <= limit; ++i)
                if (number % i == 0)
                    return false;
            return true;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            rechenAusgabe();
        }
    }
}
