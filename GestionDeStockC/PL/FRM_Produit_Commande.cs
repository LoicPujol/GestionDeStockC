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
    public partial class FRM_Produit_Commande : Form
    {
        public Form frmdetail;
        public FRM_Produit_Commande(Form frm)
        {
            InitializeComponent();
            frmdetail = frm;
        }

        private void txtquantite_KeyPress(object sender, KeyPressEventArgs e)
        {
            //text seulement caractere numerique
            if(!char.IsDigit(e.KeyChar) && e.KeyChar!=8)
            {
                e.Handled = true;
            }
        }

        private void txtremise_KeyPress(object sender, KeyPressEventArgs e)
        {
            //text seulement caractere numerique
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtquantite_TextChanged(object sender, EventArgs e)
        {
            
            if(txtquantite.Text!="")//pas vide
            {
                int quantite = int.Parse(txtquantite.Text);
                int prix = int.Parse(lblprix.Text);
                if(int.Parse(txtquantite.Text)>int.Parse(lblstock.Text))
                {
                    MessageBox.Show("Il n'y a seulement " + int.Parse(lblstock.Text) + " danqs le stock", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //vider textquantite si trop
                    txtquantite.Text = "";
                    txttotal.Text = lblprix.Text;
                }
                else
                {
                    txttotal.Text = (quantite * prix).ToString();
                }
                //calcul total
                
            }else
            {
                txttotal.Text = lblprix.Text;
            }
            
        }

        private void txtremise_TextChanged(object sender, EventArgs e)
        {
            if(txtremise.Text!="")
            {
                int quantite;
                if(txtquantite.Text!="")
                {
                    quantite = int.Parse(txtquantite.Text);
                }else
                {
                    quantite = 1;
                }
                int prix = int.Parse(lblprix.Text);
                int total = quantite * prix;
                int remise = int.Parse(txtremise.Text);
                txttotal.Text = (total - (total * remise / 100)).ToString();
            }else
            {
                int quantite;
                if (txtquantite.Text !="")
                {
                    quantite = int.Parse(txtquantite.Text);
                }
                else
                {
                    quantite = 1;
                }
                int prix = int.Parse(lblprix.Text);
                txttotal.Text = (quantite * prix).ToString();

            }
        }

        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            if (txtquantite.Text == "")
            {
                MessageBox.Show("Saisir une quantite", "Produit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Ajouter produit dans datagrid commande
                BL.D_Commande DETAIL = new BL.D_Commande
                {
                    Id = int.Parse(lblid.Text),
                    Nom = lblnom.Text,
                    Quantite = int.Parse(txtquantite.Text),
                    Prix = lblprix.Text,
                    Remise = txtremise.Text,
                    Total = txttotal.Text
                };
                //Ajouter dans liste detail commande
                if (grpproduit.Text == "Vendre Produit")
                {
                    if (BL.D_Commande.listeDetail.SingleOrDefault(s => s.Id == DETAIL.Id) != null)
                    {
                        MessageBox.Show("Produit deja ajoute dans commande", "Produit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        BL.D_Commande.listeDetail.Add(DETAIL);
                    }
                } else
                {
                    //Modifier dans liste avec recherche d'index
                    int index = BL.D_Commande.listeDetail.FindIndex(s => s.Id == int.Parse(lblid.Text));
                    BL.D_Commande.listeDetail[index] = DETAIL;
                }
                //Ajouter dans liste detail affectation

                BL.D_Affectation DetailDestinataire = new BL.D_Affectation
                {
                    Id_Client = int.Parse(txtIdClientAffect.Text),
                    Id_Produit = int.Parse(lblid.Text),
                    Quantite = int.Parse(txtquantite.Text),
                };
                if (grpproduit.Text == "Vendre Produit")
                {
                    if (BL.D_Affectation.listeDetail.SingleOrDefault(s => s.Id_Produit == DetailDestinataire.Id_Produit) != null)
                    {
                        MessageBox.Show("Produit deja ajoute dans commande", "Produit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    } else
                    {
                        BL.D_Affectation.listeDetail.Add(DetailDestinataire);
                    }
                }
                else
                {
                    //Modifier dans liste avec recherche d'index
                    int index = BL.D_Affectation.listeDetail.FindIndex(s => s.Id_Produit == int.Parse(lblid.Text));
                    BL.D_Affectation.listeDetail[index] = DetailDestinataire;
                }
                //fin ajout table affectation

                //Ajouter dans detail expedition
                BL.D_Affectation DetailExpediteur = new BL.D_Affectation
                {
                    Id_Client = int.Parse(txtIdExpediteur.Text),
                    Id_Produit = int.Parse(lblid.Text),
                    Quantite = int.Parse(txtquantite.Text),
                };
                if (grpproduit.Text == "Vendre Produit")
                {
                    if (BL.D_Affectation.listeDetailExpedition.SingleOrDefault(s => s.Id_Produit == DetailExpediteur.Id_Produit) != null)
                    {
                        MessageBox.Show("Produit deja ajoute dans commande", "Produit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        BL.D_Affectation.listeDetailExpedition.Add(DetailExpediteur);
                    }
                }
                else
                {
                    //Modifier dans liste avec recherche d'index
                    int index = BL.D_Affectation.listeDetailExpedition.FindIndex(s => s.Id_Produit == int.Parse(lblid.Text));
                    BL.D_Affectation.listeDetailExpedition[index] = DetailExpediteur;
                }
                //fin detail expedition
                (frmdetail as FRM_Detail_Commande).Actualiser_Detail_Commande();
                this.Close();
            }
        }
    }
}
