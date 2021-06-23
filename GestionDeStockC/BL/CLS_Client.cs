using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStockC.BL
{
    class CLS_Client
    {
        private dbStockContext db = new dbStockContext();
        private Client C;//table client

        //fonction pour ajouter client dans les tables
        public bool Ajouter_Client(string Nom, string Prenom, string Adresse, string Telephone, string Email, string Ville, String Pays, string NumClient, string CodeZip, string rabais)
        {
            C = new Client();//nouveau client
            C.Nom_Client = Nom;
            C.Prenom_Client = Prenom;
            C.Adresse_Client = Adresse;
            C.Email_Client = Email;
            C.Telephone_Client = Telephone;
            C.Ville_Client = Ville;
            C.Pays_Client = Pays;
            C.Num_Client = NumClient;
            C.Code_Zip = CodeZip;
            C.Rabais = rabais;
            //verifier si client existe
            if(db.Clients.SingleOrDefault(s=>s.Nom_Client==Nom && s.Prenom_Client==Prenom)==null)// si existe pas
            {
                db.Clients.Add(C);//ajouter dans la table client
                db.SaveChanges();//enregistrer dans la base de données
                return true;
            }else//si n'existe pas dans la base de donné
            {
                return false;
            }
        }
        //fonction pour modifier client dans la base de donne        
        public void Modifier_Client(int id, string Nom, string Prenom, string Adresse, string Telephone, string Email, string Ville, String Pays, string NumClient, string CodeZip, string rabais)
        {
            C = new Client();
            C = db.Clients.SingleOrDefault(s => s.ID_Client == id);//verifier si id de client existe
            if(C != null)//existe
            {
                C.Nom_Client = Nom;
                C.Prenom_Client = Prenom;
                C.Adresse_Client = Adresse;
                C.Telephone_Client = Telephone;
                C.Email_Client = Email;
                C.Ville_Client = Ville;
                C.Pays_Client = Pays;
                C.Num_Client = NumClient;
                C.Code_Zip = CodeZip;
                C.Rabais = rabais;
                db.SaveChanges();//sauver changement dans base donnee
            }
        }
        //Foncion supprimer client
        public void Supprimer_Client(int id)
        {
            C = new Client();
            C = db.Clients.SingleOrDefault(s => s.ID_Client == id);
            if(C!=null)//existe
            {
                db.Clients.Remove(C);// pour supprimer le client
                db.SaveChanges();

            }
        }
    }
}
