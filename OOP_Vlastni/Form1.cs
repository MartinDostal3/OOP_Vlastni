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
            Barman brmn = new Barman("Honza", "Marek", 119);
          
            brmn.OdpracujHodiny(48);
            brmn.Nalej(110);
            MessageBox.Show(brmn.ToString());


            
           

            Manazer mngr = new Manazer("Martin", "novák", 200, 2000, 21);
            
            mngr.OdpracujHodiny(520);
            mngr.Pracuj();
            
            MessageBox.Show(mngr.ToString());


        }
    }
}
