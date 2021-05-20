using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStockC.BL
{
    class CLS_Commande_Detail
    {
        private dbStockContext db = new dbStockContext();
        private Commande clscmd;
        private Details_Commande clsD;
        public int IDCommande;
        //Sauvegarder commande
        public void Ajouter_Commande(DateTime datecommande, int Idclient, string totalht, string tva, string totalttc)
        {
            clscmd = new Commande();
            clscmd.DATE_Commande = datecommande;
            clscmd.ID_Client = Idclient;
            clscmd.Total_HT = totalht;
            clscmd.TVA = tva;
            clscmd.Total_TTC = totalttc;
            db.Commandes.Add(clscmd);
            db.SaveChanges();
            IDCommande = clscmd.ID_Commande;//numero de commande ajoute
        }
        //Alimenter detail commande
        public void Ajouter_Detail(int idproduit, string nomproduit, int quantite, string prix, string remise, string total)
        {
            clsD = new Details_Commande();
            clsD.ID_Commande = IDCommande;
            clsD.ID_Produit = idproduit;
            clsD.Nom_Produit = nomproduit;
            clsD.Quantite = quantite;
            clsD.Prix = prix;
            clsD.Remise = remise;
            clsD.Total = total;
            db.Details_Commande.Add(clsD);
            db.SaveChanges();
        }
    }
}
