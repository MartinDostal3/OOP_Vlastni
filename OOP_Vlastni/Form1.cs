using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Vlastni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Barman brmn = new Barman("Honza", "Marek", 125);
            MessageBox.Show(brmn.ToString());
            brmn.OdpracujHodiny(11);
          
            
            brmn.Nalej(20);
            MessageBox.Show(brmn.ToString());

            Manazer mngr = new Manazer("Martin", "novák", 200, 2000);
            mngr.OdpracujHodiny(2);
            MessageBox.Show(mngr.ToString());


        }
    }
}
