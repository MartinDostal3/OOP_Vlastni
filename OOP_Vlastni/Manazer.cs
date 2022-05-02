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

        public int Papiry { get; private set; }

        public void Pracuj(int hotovo)
        {
            
         
            hotovo = 0;


            
               
                while(hotovo < papiry)
                {
                    hotovo++;
                }

          
                int zbyva = 20 - papiry;
       
           if(papiry < 20)
                System.Windows.Forms.MessageBox.Show("Manažer, vyřídil všechny teď zadané papíry! a dneska mu ještě zbývá: " + zbyva);

            else if (hotovo == papiry)
                System.Windows.Forms.MessageBox.Show("Manažer, vyřídil všechny teď zadané papíry!");
            

            /*int neudelano = 20 - hotovo;
            System.Windows.Forms.MessageBox.Show("Manažerovi zbývá vyřídit: " + neudelano + " papírů.");*/



        }
       

    }
}
