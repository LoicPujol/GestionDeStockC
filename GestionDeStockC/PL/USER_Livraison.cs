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
    public partial class USER_Livraison : UserControl
    {
        private static USER_Livraison Userclient;
        private dbStockContext db;
        public static USER_Livraison Instance
        {
            get
            {
                if (Userclient == null)
                {
                    Userclient = new USER_Livraison();
                }
                return Userclient;
            }
        }
        public USER_Livraison()
        {
            InitializeComponent();
            db = new dbStockContext();
        }
    }
}
