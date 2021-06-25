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
            dvgDetailCommande.ClearSelection();
        }
        //Fonction remplir datagrid Produit
        public void RemplirdvgProduit()
        {
            if (txtIdExp.Text.ToString() != "")
            {
                dvgProduit.Columns[8].DefaultCellStyle.Format = "dd/MM/yyyy";
                db = new dbStockContext();
                dvgProduit.Rows.Clear();
                var listerecherche = db.Affectations.ToList();//liste de recherche = liste des affectations

                Produit Prod = new Produit();
                Produit CatProd = new Produit();
                Produit TypProd = new Produit();
                Produit DateCtrl = new Produit();
                Categorie Nomcat = new Categorie();
                Type NomType = new Type();
                Client Clt = new Client();
                foreach (var l in listerecherche)
                {
                    Clt = db.Clients.SingleOrDefault(s => s.ID_Client == l.ID_Client);
                    Prod = db.Produits.SingleOrDefault(s => s.ID_Produit == l.ID_Produit);
                    CatProd = db.Produits.SingleOrDefault(s => s.ID_Produit == l.ID_Produit);
                    Nomcat = db.Categories.SingleOrDefault(s => s.ID_Categorie == CatProd.ID_Categorie);
                    TypProd = db.Produits.SingleOrDefault(s => s.ID_Produit == l.ID_Produit);
                    NomType = db.Types.SingleOrDefault(s => s.ID_Type == TypProd.ID_Type);
                    DateCtrl = db.Produits.SingleOrDefault(s => s.ID_Produit == l.ID_Produit);

                    dvgProduit.Rows.Add(l.ID_Client, l.ID_Produit, Nomcat.Nom_Categorie, NomType.Nom_Type, Prod.NumInventaire, Prod.Nom_Produit, l.Quantite_affectee, Prod.Prix_Produit, DateCtrl.Date_Controle);
                }
                foreach (System.Windows.Forms.DataGridViewRow r in dvgProduit.Rows)
                {
                    if ((r.Cells[0].Value).ToString().ToUpper().Contains(txtIdExp.Text.ToString().ToUpper()))
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
                if (txtrechercheInvProd.Text.ToString() != "")
                {
                    foreach (System.Windows.Forms.DataGridViewRow r in dvgProduit.Rows)
                    {
                        if ((r.Cells[4].Value).ToString().ToUpper().Contains(txtrechercheInvProd.Text.ToString().ToUpper()))
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
                        if ((r.Cells[5].Value).ToString().ToUpper().Contains(txtrechercheNom.Text.ToString().ToUpper()))
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
                        if ((r.Cells[2].Value).ToString().ToUpper().Contains(combocategorie.Text.ToString().ToUpper()))
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
                        if ((r.Cells[3].Value).ToString().ToUpper().Contains(combotype.Text.ToString().ToUpper()))
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
            }
        dvgProduit.ClearSelection();
        }
   
        private void FRM_Detail_Commande_Load(object sender, EventArgs e)
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
            if ((txtNomExp.Text == "") || (txtNomDest.Text == ""))
            {
                MessageBox.Show("Saisir client", "Ajouter produit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FRM_Produit_Commande frmp = new FRM_Produit_Commande(this);
                //si stock vide
                if ((int)dvgProduit.CurrentRow.Cells[6].Value == 0)
                {
                    MessageBox.Show("Stock vide", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //afficher les info de larticle
                    frmp.txtIdClientAffect.Text = IDCLIENT.ToString();
                    frmp.txtIdExpediteur.Text = IDEXPEDITEUR.ToString();
                    frmp.txtIdProduit.Text = dvgProduit.CurrentRow.Cells[1].Value.ToString();
                    frmp.lblInv.Text = dvgProduit.CurrentRow.Cells[4].Value.ToString();
                    frmp.lblnom.Text = dvgProduit.CurrentRow.Cells[5].Value.ToString();
                    frmp.lblstock.Text = dvgProduit.CurrentRow.Cells[6].Value.ToString();
                    frmp.lblprix.Text = dvgProduit.CurrentRow.Cells[7].Value.ToString();
                    frmp.txtremise.Text = txtRemise.Text;
                    if (dvgProduit.CurrentRow.Cells[3].Value.ToString () == "Unitaire")
                    {
                        frmp.txtquantite.Text = "1";
                        frmp.txtquantite.Enabled = false;
                    }
                    else
                    {
                        frmp.txtquantite.Enabled = true;
                    }
                    int prix;
                    int remise;
                    string tarif;
                    if (dvgProduit.CurrentRow.Cells[7].Value.ToString() != "")
                    {
                        prix = Convert.ToInt32(dvgProduit.CurrentRow.Cells[7].Value);
                            if (txtRemise.Text != "")
                            {
                            remise = int.Parse(txtRemise.Text);
                            }
                            else
                            {
                            remise = 0;
                            }
                            tarif = (prix - (prix * remise / 100)).ToString();
                    }
                    else
                    {
                        tarif = "";
                    }
                    frmp.txttotal.Text = tarif;
                    frmp.ShowDialog();
                }
            }
        }
        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Produit_Commande frm = new FRM_Produit_Commande(this);
            Produit PR = new Produit();
            Affectation QteAff = new Affectation();
            if(dvgDetailCommande.CurrentRow!=null)
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
            if (dvgDetailCommande.Rows.Count != 0)
            {
                MessageBox.Show("Un changement de destinataire annulera la commande en cour.", "Expediteur", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            if (txtIdExp.Text == "")
            {
                MessageBox.Show("Selectionner expediteur", "Expediteur", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                PL.FRM_Client_Commande frmC = new FRM_Client_Commande();
                frmC.txtID.Text = IDEXPEDITEUR.ToString();
                frmC.ShowDialog();
                //afficher les info de client
                if ((frmC.dvgclient.CurrentRow != null) && (frmC.dvgclient.Rows.Count != 0))
                {
                    IDCLIENT = (int)frmC.dvgclient.CurrentRow.Cells[0].Value; //on recupere l'ID client pour le mettre en variable puis utiliser a l'enregistrement de la commande
                    txtNomDest.Text = frmC.dvgclient.CurrentRow.Cells[2].Value.ToString();
                    txtRemise.Text = frmC.dvgclient.CurrentRow.Cells[5].Value.ToString();
                }
            }

        }
        public int IDEXPEDITEUR;
        private void btnExp_Click(object sender, EventArgs e)
        {
            if (dvgDetailCommande.Rows.Count != 0)
            {
                MessageBox.Show("Un changement de d'expediteur annulera la commande en cour.", "Expediteur", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            PL.FRM_Client_Commande frmC = new FRM_Client_Commande();
                    frmC.txtID.Text = IDCLIENT.ToString();
                    frmC.ShowDialog();
                    //afficher les info de client
                    if ((frmC.dvgclient.CurrentRow != null) && (frmC.dvgclient.Rows.Count != 0))
                    {
                        IDEXPEDITEUR = (int)frmC.dvgclient.CurrentRow.Cells[0].Value; //on recupere l'ID client pour le mettre en variable puis utiliser a l'enregistrement de la commande
                        txtNomExp.Text = frmC.dvgclient.CurrentRow.Cells[2].Value.ToString();
                        txtIdExp.Text = frmC.dvgclient.CurrentRow.Cells[0].Value.ToString();
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

        private void txtNomExp_TextChanged(object sender, EventArgs e)
        {
            RemplirdvgProduit();
            dvgDetailCommande.Rows.Clear();
            BL.D_Commande.listeDetail.Clear();
            BL.D_Affectation.listeDetail.Clear();
            BL.D_Affectation.listeDetailExpedition.Clear();
        }

        private void txtNomDest_TextChanged(object sender, EventArgs e)
        {
            RemplirdvgProduit();
            dvgDetailCommande.Rows.Clear();
            BL.D_Commande.listeDetail.Clear();
            BL.D_Affectation.listeDetail.Clear();
            BL.D_Affectation.listeDetailExpedition.Clear();
        }

    }
}
