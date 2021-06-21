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
    public partial class FRM_Ajoute_Date : Form
    {
        private dbStockContext db;
        public FRM_Ajoute_Date()
        {
            InitializeComponent();
            db = new dbStockContext();
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
