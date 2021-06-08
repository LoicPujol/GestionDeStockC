using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStockC.BL
{
    class D_Affectation
    {
        //Sauvegarder les produits commander dans la liste avec qte
        public static List<D_Affectation> listeDetail = new List<D_Affectation>();
        public static List<D_Affectation> listeDetailExpedition = new List<D_Affectation>();
        public int Id_Client { get; set; }
        public int Id_Produit { get; set; }
        public int Quantite { get; set; }
       
    }
}
