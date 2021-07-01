using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStockC.BL
{
    class CLS_Produit
    {
        private dbStockContext db = new dbStockContext();
        private Produit PR;
        //ajouter produit
        public bool Ajouter_Produit(string NomP, string alerte, string prix, byte[] imageP, int idcategorie, int idtype,string dateCtrl, string inventaire, string Serie, string tarifachat, string poids, string marge)//image pour sauvegarder dand base de donne doit etre au format byte
        {
            PR = new Produit();
            PR.Nom_Produit = NomP;
            PR.Stock_Alerte = alerte;
            PR.Prix_Produit = prix;
            PR.Image_Produit = imageP;
            PR.ID_Categorie = idcategorie;
            PR.ID_Type = idtype;
            PR.Date_Controle = dateCtrl;
            PR.NumInventaire = inventaire;
            PR.N_Serie = Serie;
            PR.Tarif_Achat = tarifachat;
            PR.Poids = poids;
            PR.Marge = marge;
            //verifier si le produit existe
            if (db.Produits.SingleOrDefault(a => a.NumInventaire.ToString() == inventaire.ToString()) == null)//n'existe pas
            {
                db.Produits.Add(PR);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        //Modifier  Produit
        public void Modifier_Produit(int IDP, string NomP, string alerte, string prix, byte[] imageP, int idcategorie, int idtype, string dateCtrl, string inventaire, string Serie, string tarifachat, string poids, string marge)
        {
            PR = new Produit();
            PR = db.Produits.SingleOrDefault(s => s.ID_Produit == IDP);//verifier si id de client existe
            if (PR != null)//existe
            {
                PR.Nom_Produit = NomP;
                PR.Stock_Alerte = alerte;
                PR.Prix_Produit = prix;
                PR.Image_Produit = imageP;
                PR.ID_Categorie = idcategorie;
                PR.ID_Type = idtype;
                PR.Date_Controle = dateCtrl;
                PR.NumInventaire = inventaire;
                PR.N_Serie = Serie;
                PR.Tarif_Achat = tarifachat;
                PR.Poids = poids;
                PR.Marge = marge;
                db.SaveChanges();//sauver changement dans base donnee
            }
        }
        /**
        //Modifier stock produit
        public void Modifier_Stock_Produit(int id, int quantite)//verilfier que le produit existe
        {
            PR = new Produit();
            PR = db.Produits.SingleOrDefault(s => s.ID_Produit == id);
            if (PR != null)//existe
            {
                PR.Quantité_Produit = quantite;
                db.SaveChanges();
            }
        }
        **/
            //Supprimer produit
        public void Supprimer_Produit(int id)
        {
            PR = new Produit();
            PR = db.Produits.SingleOrDefault(s => s.ID_Produit == id);
            if (PR != null)//existe
            {
                db.Produits.Remove(PR);// pour supprimer le client
                db.SaveChanges();
            }
        
        }
    }
}
