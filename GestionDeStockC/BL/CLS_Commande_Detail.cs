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
        private Affectation clsA;
        private Affectation clsE;
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
        public void Ajouter_Affectation(int client, int produit, int quantite)
        {
            clsA = new Affectation();
            clsA.ID_Client = client;
            clsA.ID_Produit = produit;

            if (db.Affectations.SingleOrDefault(s => s.ID_Client == client && s.ID_Produit == produit) == null)// si existe pas
            {
                clsA.Quantite_affectee = quantite;
                db.Affectations.Add(clsA);
                db.SaveChanges();
            }
            else
            {
                clsA = db.Affectations.SingleOrDefault(s => s.ID_Client == client && s.ID_Produit == produit);
                clsA.Quantite_affectee = clsA.Quantite_affectee + quantite;
                db.SaveChanges();

            }
            
        }
        public void Ajouter_Expedition(int client, int produit, int quantite)
        {
            clsE = new Affectation();
            clsE.ID_Client = client;
            clsE.ID_Produit = produit;
            clsE = db.Affectations.SingleOrDefault(s => s.ID_Client == client && s.ID_Produit == produit);
            if (clsE != null)
            //if (db.Affectations.SingleOrDefault(s => s.ID_Client == client && s.ID_Produit == produit) != null)// si existe pas
            {
                clsE.Quantite_affectee = clsE.Quantite_affectee - quantite;
                db.SaveChanges();
            }
        }
    }
}
