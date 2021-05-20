using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeStockC.PL
{
    public partial class FORM_De_Test : Form
    {
        public FORM_De_Test()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            BL.CLS_Produit CLS_Produit = new BL.CLS_Produit();
            CLS_Produit.Modifier_Stock_Produit(int.Parse(txtID.Text), int.Parse(txtQte.Text));

        }
    }
}
