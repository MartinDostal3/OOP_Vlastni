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
        
        public Manazer(string jmeno, string prijmeni, double hodinovaMzda, double priplatekZaVedeni) : base(jmeno, prijmeni, hodinovaMzda)
        {
            this.priplatekZaVedeni = priplatekZaVedeni;

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
    }
}
