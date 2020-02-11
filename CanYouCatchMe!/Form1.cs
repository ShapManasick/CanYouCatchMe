using ctf.sectalks_bne.crackme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanYouCatchMe_
{
    public partial class ThisIsHellMan : Form
    {
        public ThisIsHellMan()
        {
            InitializeComponent();
        }

        const string Thisone = "flag7{516edfc8a8c08171f7017a3ee73942e8}";
        int guesses = 5;



        private void GoodOrBad_Click



            (object sender, EventArgs e)
        {
            if


                (guesses < 1) PrintGameOver();
            var password =
            Crypto.DecryptStringAES

            ("EAAAAMXFGfJ70u16GTl7SdxOz2LSmdES2BKYYqoFm2ywR8k7dEhcUt/EwIhzNs2Ct6avSg==");
            var ThisOne =
                GessMeTheNameThat.Text;
            if (ThisOne != null && ThisOne.ToLower().Equals(password))
            {
                evil Evil = new evil();
                string x = "Success!, \n" + Crypto.DecryptStringAES("EAAAALiRHy7X28WKoSHoLhnpC9qxjk72rBTn0EkOhA1GNx4OYfwXQC0k+jTrMMamBU9moOD9eNLZ78actTLLj1yyX8Y=");
                string y =
                    Crypto.DecryptStringAES(
                        "EAAAAKzsootZHkXR1uDdjunQX0mZ4ki124NiUKH1rRUHJzQH+c3QRUzeCnIWqDV/uErigQZpXp4FFOccG0AhAxkh6oTFH/gkuhk0Y32utchRr57xUgHnEB4JLDC0OAYp64zmAg==");

                Evil.Show();
                Evil.load(y);
                MessageBox.Show(x);
                this.Hide();
               
            }
            else { 
            TryHader.Text = guesses.ToString();
            guesses--;

            MessageBox.Show
                ($"Incorrect! Please wait to try again.");

            Console.Beep(350, 250);
            Console.Beep(300, 500);
            }
        }


        private static void PrintGameOver()
        {

            MessageBox.Show(
                "You loss man !");
            Mario();
            Environment.Exit(0);
        }

       

        private static void StarWars()
        {
            Console.Beep(300, 500);
            Thread.Sleep(50);
            Console.Beep(300, 500);
            Thread.Sleep(50);
            Console.Beep(300, 500);
            Thread.Sleep(50);
            Console.Beep(250, 500);
            Thread.Sleep(50);
            Console.Beep(350, 250);
            Console.Beep(300, 500);
            Thread.Sleep(50);
            Console.Beep(250, 500);
            Thread.Sleep(50);
            Console.Beep(350, 250);
            Console.Beep(300, 500);
            Thread.Sleep(50);
            
        }

        private static void Mario()
        {
            Console.Beep(659, 125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(167);
            Console.Beep(523, 125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(784, 125);
            Thread.Sleep(375);
            Console.Beep(392, 125);
        }

private void ThingsAreThings_Click(object sender, EventArgs e)
        {

        }
    }
}
