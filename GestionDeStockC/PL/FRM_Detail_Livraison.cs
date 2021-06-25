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
    public partial class FRM_Detail_Livraison : Form
    {
        private UserControl userLivraison;
        private dbStockContext db;
        public FRM_Detail_Livraison(UserControl user)
        {
            InitializeComponent();
            db = new dbStockContext();
            userLivraison = user;
        }
        public void Actualiser_Detail_Livraison()
        {
            dvgDetailLivraison.Rows.Clear();
            foreach (var L in BL.D_Livraison.listeDetail)
            {
                dvgDetailLivraison.Rows.Add(L.Id, L.Nom, L.Quantite);
            }
            dvgDetailLivraison.ClearSelection();
        }



        //Fonction remplir datagrid Produit
        public void RemplirdvgProduit()
        {
                db = new dbStockContext();
                dvgProduit.Rows.Clear();
                var listerecherche = db.Produits.ToList();//liste de recherche = liste des affectations

                Categorie Nomcat = new Categorie();
                Type NomType = new Type();
                Affectation StockUnitaire = new Affectation();
            foreach (var l in listerecherche)
            {
                Nomcat = db.Categories.SingleOrDefault(s => s.ID_Categorie == l.ID_Categorie);
                NomType = db.Types.SingleOrDefault(s => s.ID_Type == l.ID_Type);
                if (l.ID_Type.ToString() != "3")
                {
                    if (db.Affectations.SingleOrDefault(s => s.ID_Client == IDDEST && s.ID_Produit == l.ID_Produit) != null)
                    {
                        StockUnitaire = db.Affectations.SingleOrDefault(s => s.ID_Client == IDDEST && s.ID_Produit == l.ID_Produit);
                        dvgProduit.Rows.Add(l.ID_Produit, Nomcat.Nom_Categorie, NomType.Nom_Type, l.NumInventaire, l.Nom_Produit, StockUnitaire.Quantite_affectee);
                    }
                    else
                    {
                        StockUnitaire = null;
                        dvgProduit.Rows.Add(l.ID_Produit, Nomcat.Nom_Categorie, NomType.Nom_Type, l.NumInventaire, l.Nom_Produit, StockUnitaire);
                    }
                }
                else
                {
                    if (db.Affectations.SingleOrDefault(s => s.ID_Produit == l.ID_Produit) != null)
                    {
                        StockUnitaire = db.Affectations.SingleOrDefault(s => s.ID_Produit == l.ID_Produit);
                        dvgProduit.Rows.Add(l.ID_Produit, Nomcat.Nom_Categorie, NomType.Nom_Type, l.NumInventaire, l.Nom_Produit, StockUnitaire.Quantite_affectee);
                    }
                    else
                    {
                        StockUnitaire = null;
                        dvgProduit.Rows.Add(l.ID_Produit, Nomcat.Nom_Categorie, NomType.Nom_Type, l.NumInventaire, l.Nom_Produit, StockUnitaire);
                    }
                }
                if (txtrechercheInvProd.Text.ToString() != "")
                {
                    foreach (System.Windows.Forms.DataGridViewRow r in dvgProduit.Rows)
                    {
                        if ((r.Cells[3].Value).ToString().ToUpper().Contains(txtrechercheInvProd.Text.ToString().ToUpper()))
                        {
                            //dvgAffectationProduit.Rows[r.Index].Visible = true;
                            //dvgAffectationProduit.Rows[r.Index].Selected = true;
                        }
                        else
                        {
                            dvgProduit.CurrentCell = null;
                            dvgProduit.Rows[r.Index].Visible = false;
                        }
                    }
                }
                if (txtrechercheNom.Text.ToString() != "")
                {
                    foreach (System.Windows.Forms.DataGridViewRow r in dvgProduit.Rows)
                    {
                        if ((r.Cells[4].Value).ToString().ToUpper().Contains(txtrechercheNom.Text.ToString().ToUpper()))
                        {
                            //dvgAffectationProduit.Rows[r.Index].Visible = true;
                            //dvgAffectationProduit.Rows[r.Index].Selected = true;
                        }
                        else
                        {
                            dvgProduit.CurrentCell = null;
                            dvgProduit.Rows[r.Index].Visible = false;
                        }
                    }
                }
                if (combocategorie.SelectedItem != null)
                {
                    foreach (System.Windows.Forms.DataGridViewRow r in dvgProduit.Rows)
                    {
                        if ((r.Cells[1].Value).ToString().ToUpper().Contains(combocategorie.Text.ToString().ToUpper()))
                        {
                            //dvgAffectationProduit.Rows[r.Index].Visible = true;
                            //dvgAffectationProduit.Rows[r.Index].Selected = true;
                        }
                        else
                        {
                            dvgProduit.CurrentCell = null;
                            dvgProduit.Rows[r.Index].Visible = false;
                        }
                    }
                }
                if (combotype.SelectedItem != null)
                {
                    foreach (System.Windows.Forms.DataGridViewRow r in dvgProduit.Rows)
                    {
                        if ((r.Cells[2].Value).ToString().ToUpper().Contains(combotype.Text.ToString().ToUpper()))
                        {
                            //dvgAffectationProduit.Rows[r.Index].Visible = true;
                            //dvgAffectationProduit.Rows[r.Index].Selected = true;
                        }
                        else
                        {
                            dvgProduit.CurrentCell = null;
                            dvgProduit.Rows[r.Index].Visible = false;
                        }
                    }
                }

                dvgProduit.ClearSelection();
            }
        }

        private void FRM_Detail_Livraison_Load(object sender, EventArgs e)
        {
            //afficher categorie selon table dans combobox
            combocategorie.DataSource = db.Categories.ToList();
            combocategorie.DisplayMember = "Nom_Categorie";
            combocategorie.ValueMember = "ID_Categorie";
            combocategorie.SelectedIndex = -1;

            //afficher type selon table dans combobox
            combotype.DataSource = db.Types.ToList();
            combotype.DisplayMember = "Nom_Type";
            combotype.ValueMember = "ID_Type";
            combotype.SelectedIndex = -1;
            //RemplirdvgProduit();
        }
        
        private void dvgProduit_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txtNomDest.Text == "")
            {
                MessageBox.Show("Saisir destinataire", "Ajouter produit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //MessageBox.Show(dvgProduit.CurrentRow.Cells[5].Value.ToString());
                if (dvgProduit.CurrentRow.Cells[2].Value.ToString() == "Unitaire" && dvgProduit.CurrentRow.Cells[5].Value != null)
                {
                    MessageBox.Show("Il n'est pas possible de saisir une quantite supperieur a 1 pour un Unitaire.", "Ajouter produit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    FRM_Produit_Livraison frmp = new FRM_Produit_Livraison(this);
                    //afficher les info de larticle
                    frmp.txtIdClientAffect.Text = IDDEST.ToString();
                    frmp.txtIdProduit.Text = dvgProduit.CurrentRow.Cells[0].Value.ToString();
                    frmp.lblInv.Text = dvgProduit.CurrentRow.Cells[3].Value.ToString();
                    frmp.lblnom.Text = dvgProduit.CurrentRow.Cells[4].Value.ToString();
                    //frmp.lblstock.Text = dvgProduit.CurrentRow.Cells[5].Value.ToString();
                    if (dvgProduit.CurrentRow.Cells[2].Value.ToString() == "Unitaire")
                    {
                        frmp.txtquantite.Text = "1";
                        frmp.txtquantite.Enabled = false;
                    }
                    frmp.ShowDialog();
                }
            }
        }
        /**private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Produit_Commande frm = new FRM_Produit_Commande(this);
            Produit PR = new Produit();
            Affectation QteAff = new Affectation();
            if (dvgDetailCommande.CurrentRow != null)
            {
                frm.lblTitre.Text = "Modifier Produit";
                frm.txtIdClientAffect.Text = IDCLIENT.ToString();
                frm.txtIdExpediteur.Text = IDEXPEDITEUR.ToString();
                frm.txtIdProduit.Text = dvgDetailCommande.CurrentRow.Cells[0].Value.ToString();
                frm.lblnom.Text = dvgDetailCommande.CurrentRow.Cells[1].Value.ToString();
                ////Importer le stock de produit depuis le datagrid produit//////
                int IDEX = IDEXPEDITEUR;
                int IDPROD = int.Parse(dvgDetailCommande.CurrentRow.Cells[0].Value.ToString());
                QteAff = db.Affectations.Single(s => s.ID_Client == IDEX && s.ID_Produit == IDPROD);
                frm.lblstock.Text = QteAff.Quantite_affectee.ToString();
                ////Importer inventaire de produit depuis le datagrid produit//////
                int IDP = int.Parse(dvgDetailCommande.CurrentRow.Cells[0].Value.ToString());
                PR = db.Produits.Single(s => s.ID_Produit == IDP);
                frm.lblInv.Text = PR.NumInventaire.ToString(); ;
                frm.lblprix.Text = dvgDetailCommande.CurrentRow.Cells[3].Value.ToString();
                frm.txtquantite.Text = dvgDetailCommande.CurrentRow.Cells[2].Value.ToString();
                frm.txtremise.Text = dvgDetailCommande.CurrentRow.Cells[4].Value.ToString();
                frm.txttotal.Text = dvgDetailCommande.CurrentRow.Cells[5].Value.ToString();
                frm.ShowDialog();
            }
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dvgDetailCommande.CurrentRow != null)
            {
                //supprimer ligne selectionne dans datagrid commande + sur les 3 listedetail
                int index = BL.D_Commande.listeDetail.FindIndex(s => s.Id == int.Parse(dvgDetailCommande.CurrentRow.Cells[0].Value.ToString()));
                BL.D_Commande.listeDetail.RemoveAt(index);
                BL.D_Affectation.listeDetail.RemoveAt(index);
                BL.D_Affectation.listeDetailExpedition.RemoveAt(index);

                Actualiser_Detail_Commande();
            }
        }**/
        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            BL.CLS_Livraison_Detail clslivraison = new BL.CLS_Livraison_Detail();
            if (dvgDetailLivraison.Rows.Count == 0)//si vide
            {
                MessageBox.Show("Ajouter un article dans la livraison", "Enregistrer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtNomDest.Text == "")
                {
                    MessageBox.Show("Ajouter un client dans la livraison", "Enregistrer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //enregistrer commande
                    clslivraison.Ajouter_Livraison(Livraisondate.Value, IDDEST, txtNomFournisseur.Text, txtNumDocument.Text);

                    //enregistrer liste detail commande dans les tables
                    foreach (var LD in BL.D_Livraison.listeDetail)
                    {
                        clslivraison.Ajouter_Detail(LD.Id, LD.Nom, LD.Quantite);
                    }
                    //enregistrer detail affectations
                    foreach (var LD in BL.D_Affectation.listeDetail)
                    {
                        clslivraison.Ajouter_Affectation(LD.Id_Client, LD.Id_Produit, LD.Quantite);
                    }

                   (userLivraison as USER_Liste_Livraison).Actualisedatagrid();
                    BL.D_Commande.listeDetail.Clear();
                    BL.D_Affectation.listeDetail.Clear();
                    Close();
                    MessageBox.Show("Ajouter ajoute", "Enregistrer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        public int IDDEST;
        private void btnDst_Click(object sender, EventArgs e)
        {
            if (dvgDetailLivraison.Rows.Count != 0)
            {
                MessageBox.Show("Un changement de destinataire annulera la commande en cour.", "Expediteur", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                PL.FRM_Client_Commande frmC = new FRM_Client_Commande();
                frmC.ShowDialog();
                //afficher les info de client
                if ((frmC.dvgclient.CurrentRow != null) && (frmC.dvgclient.Rows.Count != 0))
                {
                    IDDEST = (int)frmC.dvgclient.CurrentRow.Cells[0].Value; //on recupere l'ID client pour le mettre en variable puis utiliser a l'enregistrement de la commande
                    txtNomDest.Text = frmC.dvgclient.CurrentRow.Cells[2].Value.ToString();
                    txtIdDest.Text = frmC.dvgclient.CurrentRow.Cells[0].Value.ToString();
                }
            }
        }
        private void btnSupCombo_Click(object sender, EventArgs e)
        {
            combocategorie.SelectedIndex = -1;
            combotype.SelectedIndex = -1;
            RemplirdvgProduit();
        }
        private void combocategorie_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RemplirdvgProduit();
        }
        private void combotype_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RemplirdvgProduit();
        }
        private void txtrechercheInvProd_TextChanged(object sender, EventArgs e)
        {
            RemplirdvgProduit();
        }
        private void txtrechercheNom_TextChanged(object sender, EventArgs e)
        {
            RemplirdvgProduit();
        }
        private void txtNomDest_TextChanged(object sender, EventArgs e)
        {
            RemplirdvgProduit();
            dvgDetailLivraison.Rows.Clear();
            BL.D_Livraison.listeDetail.Clear();
            BL.D_Affectation.listeDetail.Clear();
        }
    }
}
