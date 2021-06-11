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
    public partial class USER_Dashboard : UserControl
    {
        private static USER_Dashboard Userclient;
        private dbStockContext db;
        public static USER_Dashboard Instance
        {
            get
            {
                if (Userclient == null)
                {
                    Userclient = new USER_Dashboard();
                }
                return Userclient;
            }
        }
        public USER_Dashboard()
        {
            InitializeComponent();
            db = new dbStockContext();
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHeure.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToShortDateString();
        }

    }
}
