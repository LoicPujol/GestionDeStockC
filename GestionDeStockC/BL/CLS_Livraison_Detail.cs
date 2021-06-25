using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStockC.BL
{
    class CLS_Livraison_Detail
    {
        private dbStockContext db = new dbStockContext();
        private Livraison clslivc;
        private Details_Livraison clsD;
        private Affectation clsA;
        public int IDLivraison;
        //Sauvegarder commande
        public void Ajouter_Livraison(DateTime dateLivraison, int Idclient, string Fournisseur, string Document)
        {
            clslivc = new Livraison();
            clslivc.Date_Livraison = dateLivraison;
            clslivc.ID_Client = Idclient;
            clslivc.Fournisseur = Fournisseur;
            clslivc.Num_Document = Document;
            db.Livraisons.Add(clslivc);
            db.SaveChanges();
            IDLivraison = clslivc.ID_Livraison;//numero de commande ajoute
        }
        //Alimenter detail commande
        public void Ajouter_Detail(int idproduit, string nomproduit, int quantite)
        {
            clsD = new Details_Livraison();
            clsD.ID_Livraison = IDLivraison;
            clsD.ID_Produit = idproduit;
            clsD.Nom_Produit = nomproduit;
            clsD.Quantite = quantite;
            db.Details_Livraison.Add(clsD);
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
     }
}