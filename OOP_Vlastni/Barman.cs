using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Vlastni
{
    internal class Barman
    {
        public string Jmeno { get; /*private set;*/ }
        
        protected string prijmeni;
        private int pocetDrinku = 0;
        protected int odpracHodiny = 0;
        public double HodinovaMzda { get; }
        public string Prijmeni
        {
            get
            {
                return prijmeni;
            }
            set
            {
                string p = value;
                p = char.ToUpper(p[0]) + p.Substring(1);
                prijmeni = p;


            }
        }
        

        public Barman(string jmeno, string prijmeni, double hodinovaMzda)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            HodinovaMzda = hodinovaMzda;
        }

        public int GetNalito()
        {
            return pocetDrinku;
        }

        public void Nalej(int kusy)
        {
            if (pocetDrinku + kusy <= 120 ) pocetDrinku += kusy;
            else
            {
                System.Windows.Forms.MessageBox.Show("Pro dnešek máš splněnu, běž domů!");
            }
        }

        public void OdpracujHodiny(int hodiny)
        {
            if (odpracHodiny + hodiny <= 12) odpracHodiny += hodiny;
            else System.Windows.Forms.MessageBox.Show("Barman může pracovat jen dvanaáct hodin denně");

        }
        public double VypoctiMzdu()
        {
            return odpracHodiny * HodinovaMzda;
        }
        public bool Dovolena()
        {
            return odpracHodiny >= 320;
        }
        


        public override string ToString()
        {
            string maBonus = "NE, nemá nárok na dovolenou";
            if (Dovolena()) maBonus = "ANO, má nárok na dovolenou";
            string s = "Jméno: " + Jmeno
                     + "\nPříjmení: " + Prijmeni
                     + "\nOdpracované hodiny za den: " + odpracHodiny
                     + "\nHodinová mzda: " + HodinovaMzda
                     + "\nVypočtená mzda za den: " + VypoctiMzdu()
                     +"\nDnes nalito drinků: " + pocetDrinku
                     + "\nDovolená: " + maBonus;
            return s;
        }


    }
}
