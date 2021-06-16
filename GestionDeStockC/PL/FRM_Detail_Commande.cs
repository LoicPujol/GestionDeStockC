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
    public partial class FRM_Detail_Commande : Form
    {
        private UserControl userCommande;
        private dbStockContext db;
        public FRM_Detail_Commande(UserControl user)
        {
            InitializeComponent();
            db = new dbStockContext();
            userCommande = user;
        }
        //Remplir datagrid commande depuis la liste des produits
        public void Actualiser_Detail_Commande()
        {
            //Calcul total HT et TTC
            float Totalht=0,TVA=0,TotalTTC;
            if(txttva.Text!="")
            {
                TVA = float.Parse(txttva.Text);
            }
            dvgDetailCommande.Rows.Clear();
            foreach(var L in BL.D_Commande.listeDetail)
            {
                dvgDetailCommande.Rows.Add(L.Id, L.Nom, L.Quantite, L.Prix, L.Remise, L.Total);
                Totalht = Totalht + float.Parse(L.Total);
            }
            txttotalht.Text = Totalht.ToString();
            TotalTTC = (Totalht + (Totalht * TVA / 100));
            txttotalttc.Text = TotalTTC.ToString();
        }
        //Fonction remplir datagrid Produit
        public void RemplirdvgProduit()
        {
            dvgProduit.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
            db = new dbStockContext();
            Categorie cat = new Categorie();
            Type typ = new Type();
            foreach (var l in db.Produits)
            {
                cat = db.Categories.SingleOrDefault(s => s.ID_Categorie == l.ID_Categorie);
                typ = db.Types.SingleOrDefault(s => s.ID_Type == l.ID_Type);
                dvgProduit.Rows.Add(l.ID_Produit, cat.Nom_Categorie, typ.Nom_Type, l.NumInventaire, l.Nom_Produit, l.Quantité_Produit, l.Prix_Produit, l.Date_Controle);
            }
            dvgProduit.ClearSelection();
        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            Close();
            BL.D_Commande.listeDetail.Clear();
        }

        private void FRM_Detail_Commande_Load(object sender, EventArgs e)
        {
            RemplirdvgProduit();
        }

        private void dvgProduit_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FRM_Produit_Commande frmp = new FRM_Produit_Commande(this);
            //si stock vide
            if ((int)dvgProduit.CurrentRow.Cells[5].Value == 0)
            {
                MessageBox.Show("Stock vide", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //afficher les info de larticle
                frmp.txtIdClientAffect.Text = IDCLIENT.ToString();
                frmp.txtIdExpediteur.Text = IDEXPEDITEUR.ToString();
                frmp.txtIdProduit.Text = dvgProduit.CurrentRow.Cells[0].Value.ToString();
                frmp.lblInv.Text = dvgProduit.CurrentRow.Cells[3].Value.ToString();
                frmp.lblnom.Text = dvgProduit.CurrentRow.Cells[4].Value.ToString();
                frmp.lblstock.Text = dvgProduit.CurrentRow.Cells[5].Value.ToString();
                frmp.lblprix.Text = dvgProduit.CurrentRow.Cells[3].Value.ToString();
                frmp.txttotal.Text = dvgProduit.CurrentRow.Cells[3].Value.ToString();
                frmp.ShowDialog();
            }
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Produit_Commande frm = new FRM_Produit_Commande(this);
            Produit PR = new Produit();
            if(dvgDetailCommande.CurrentRow!=null)
            {
                frm.grpproduit.Text = "Modifier Produit";
                frm.txtIdClientAffect.Text = IDCLIENT.ToString();
                frm.txtIdExpediteur.Text = IDEXPEDITEUR.ToString();
                frm.txtIdProduit.Text = dvgDetailCommande.CurrentRow.Cells[0].Value.ToString();
                frm.lblnom.Text = dvgDetailCommande.CurrentRow.Cells[1].Value.ToString();
                ////Importer le stock de produit depuis le datagrid produit//////
                int IDP = int.Parse(dvgDetailCommande.CurrentRow.Cells[0].Value.ToString());
                PR = db.Produits.Single(s => s.ID_Produit == IDP);
                frm.lblstock.Text = PR.Quantité_Produit.ToString();
                ////Importer inventaire de produit depuis le datagrid produit//////
                frm.lblInv.Text = PR.NumInventaire.ToString(); ;
                ////////////////////////////////////////////////////////////////
                frm.lblprix.Text = dvgDetailCommande.CurrentRow.Cells[3].Value.ToString();
                frm.txtquantite.Text = dvgDetailCommande.CurrentRow.Cells[2].Value.ToString();
                frm.txtremise.Text = dvgDetailCommande.CurrentRow.Cells[4].Value.ToString();
                frm.txttotal.Text = dvgDetailCommande.CurrentRow.Cells[5].Value.ToString();
                frm.ShowDialog();
            }
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dvgDetailCommande.CurrentRow!=null)
            {
                //supprimer ligne selectionne dans datagrid commande + sur les 3 listedetail
                int index = BL.D_Commande.listeDetail.FindIndex(s => s.Id == int.Parse(dvgDetailCommande.CurrentRow.Cells[0].Value.ToString()));
                BL.D_Commande.listeDetail.RemoveAt(index);
                BL.D_Affectation.listeDetail.RemoveAt(index);
                BL.D_Affectation.listeDetailExpedition.RemoveAt(index);

                Actualiser_Detail_Commande();
            }
        }

        private void txttva_TextChanged(object sender, EventArgs e)
        {
            Actualiser_Detail_Commande();
        }

    private void btnenregistrer_Click(object sender, EventArgs e)
        {
            BL.CLS_Commande_Detail clscommande = new BL.CLS_Commande_Detail();
            if(dvgDetailCommande.Rows.Count==0)//si vide
            {
                MessageBox.Show("Ajouter un article dans la commande", "Enregistrer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                if(txtNomDest.Text=="")
                {
                    MessageBox.Show("Ajouter un client dans la commande", "Enregistrer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else
                {
                    //enregistrer commande
                    clscommande.Ajouter_Commande(commandedate.Value, IDCLIENT, txttotalht.Text, txttva.Text, txttotalttc.Text);
                    
                    //enregistrer liste detail commande dans les tables
                    foreach(var LD in BL.D_Commande.listeDetail)
                    {
                        clscommande.Ajouter_Detail(LD.Id, LD.Nom, LD.Quantite, LD.Prix, LD.Remise, LD.Total);
                    }
                    
                    //enregistrer detail affectations
                    foreach (var LD in BL.D_Affectation.listeDetail)
                    {
                        clscommande.Ajouter_Affectation(LD.Id_Client,LD.Id_Produit, LD.Quantite);
                    }
                    //enregistrer detail expedition (modification stock)
                    foreach (var LD in BL.D_Affectation.listeDetailExpedition)
                    {
                        clscommande.Ajouter_Expedition(LD.Id_Client, LD.Id_Produit, LD.Quantite);
                    }
                    (userCommande as USER_Liste_Commande).Actualisedatagrid();
                    BL.D_Commande.listeDetail.Clear();
                    BL.D_Affectation.listeDetail.Clear();
                    BL.D_Affectation.listeDetailExpedition.Clear();
                    Close();
                    MessageBox.Show("Ajouter ajoute", "Enregistrer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            }
        public int IDCLIENT;
        private void btnDst_Click(object sender, EventArgs e)
        {
            PL.FRM_Client_Commande frmC = new FRM_Client_Commande();
            frmC.ShowDialog();
            //afficher les info de client

            IDCLIENT = (int)frmC.dvgclient.CurrentRow.Cells[0].Value; //on recupere l'ID client pour le mettre en variable puis utiliser a l'enregistrement de la commande
            txtNomDest.Text = frmC.dvgclient.CurrentRow.Cells[1].Value.ToString();
            txtPrenomDest.Text = frmC.dvgclient.CurrentRow.Cells[2].Value.ToString();
        }
        public int IDEXPEDITEUR;
        private void btnExp_Click(object sender, EventArgs e)
        {
            PL.FRM_Client_Commande frmC = new FRM_Client_Commande();
            frmC.ShowDialog();
            //afficher les info de client

            IDEXPEDITEUR = (int)frmC.dvgclient.CurrentRow.Cells[0].Value; //on recupere l'ID client pour le mettre en variable puis utiliser a l'enregistrement de la commande
            txtNomExp.Text = frmC.dvgclient.CurrentRow.Cells[1].Value.ToString();
            txtPrenomExp.Text = frmC.dvgclient.CurrentRow.Cells[2].Value.ToString();
        }
                
    }
}
