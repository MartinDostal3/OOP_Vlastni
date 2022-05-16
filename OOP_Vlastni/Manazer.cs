using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Vlastni
{
    internal class Manazer : Barman
    {
        private double priplatekZaVedeni = 0;
        private int papiry = 0;

        public Manazer(string jmeno, string prijmeni, double hodinovaMzda, double priplatekZaVedeni, int papiry) : base(jmeno, prijmeni, hodinovaMzda)
        {
            this.priplatekZaVedeni = priplatekZaVedeni;
            this.papiry = papiry;
            
        }

        public double PriplatekZaVedeni
        {
            get
            {
                return priplatekZaVedeni;
            }
            set
            {
                priplatekZaVedeni = value;
            }
        }

        public override double VypoctiMzdu()
        {
            if(odpracHodiny > 200)
            {
                return base.VypoctiMzdu() + 3000;
            }
            else
            {
                return base.VypoctiMzdu();
            }
            
        }
        public int Papiry { get; private set; }

        public void Pracuj()
        {


            int hotovo = 0;


            
               
                while(hotovo < papiry)
                {
                    hotovo++;
                }

          
                int zbyva = 20 - papiry;
       
           if(papiry < 20)
                System.Windows.Forms.MessageBox.Show("Manažer, vyřídil všechny teď zadané papíry! a dneska mu ještě zbývá: " + zbyva);

            else if (hotovo == papiry)
                System.Windows.Forms.MessageBox.Show("Manažer, vyřídil všechny teď zadané papíry!");
            

      



        }
        public override string ToString()
        {
            string s = string.Empty;
            s = "\nPříplatek za vedení: " + PriplatekZaVedeni;

            return base.ToString() + s;
        }


    }
}
