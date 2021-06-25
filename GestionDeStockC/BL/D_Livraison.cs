using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStockC.BL
{
    class D_Livraison
    {
        //Sauvegarder les produits commander dans la liste avec qte
        public static List<D_Livraison> listeDetail = new List<D_Livraison>();
        public int Id { get; set; }
        public string Nom { get; set; }
        public int Quantite { get; set; }

    }
}
