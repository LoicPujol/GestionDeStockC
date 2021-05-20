using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStockC.BL
{
    class CLS_Categorie
    {
        private dbStockContext db = new dbStockContext();
        private Categorie cat;//table categorie

        //fonction pour ajouter categorie dans les tables
        public bool Ajouter_Categorie(string NomCat)
        {
            cat = new Categorie();//nouveau categorie
            cat.Nom_Categorie = NomCat;
            //verifier si client existe
            if (db.Categories.SingleOrDefault(s => s.Nom_Categorie == NomCat) == null)// si existe pas
            {
                db.Categories.Add(cat);//ajouter dans la table client
                db.SaveChanges();//enregistrer dans la base de données
                return true;
            }
            else//si n'existe pas dans la base de donné
            {
                return false;
            }
        }
        //modifier categorie
        public void Modifier_Categorie(int idcat, string Nom)
        {
            cat = new Categorie();
            cat = db.Categories.SingleOrDefault(s => s.ID_Categorie == idcat);//verifier si id de client existe
            if (cat != null)//existe
            {
                cat.Nom_Categorie = Nom;
                db.SaveChanges();//sauver changement dans base donnee
            }
        }
        //supprimer categorie
        public void Supprimer_Categorie(int idcat)
        {
            cat = new Categorie();
            cat = db.Categories.SingleOrDefault(s => s.ID_Categorie == idcat);
            if (cat != null)
            {
                db.Categories.Remove(cat);
                db.SaveChanges();
            }
        }
    }
}
