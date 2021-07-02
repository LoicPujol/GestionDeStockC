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

    public partial class FRM_Ajoute_Modifier_Categorie : Form
    {
        private UserControl usercat;
        public FRM_Ajoute_Modifier_Categorie(UserControl usercategorie)
        {
            InitializeComponent();
            this.usercat = usercategorie;
        }
        public FRM_Ajoute_Modifier_Categorie()
        {
            InitializeComponent();
        }

        private void txtNom_Enter(object sender, EventArgs e)
        {
            if (txtNom.Text == "Nom de Categorie")
            {
                txtNom.Text = "";
                txtNom.ForeColor = Color.Black;
            }
        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            Close();//Quitter le formulaire de saisie
        }
        public int idcategorie;
        private void btnenregistrer_Click(object sender, EventArgs e)
        {

            BL.CLS_Categorie clcat = new BL.CLS_Categorie();
            if (txtNom.Text == "" || txtNom.Text == "Nom de Categorie")
            { 
                MessageBox.Show("Entrer un nom de Categorie", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                if (lblTitre.Text == "Ajouter Categorie")
                {
                    if (clcat.Ajouter_Categorie(txtNom.Text) == false)
                    {
                        MessageBox.Show("La catégorie éxsiste déja", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Catégorie ajoutée", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (usercat as USER_Liste_Categorie).Actualisedatagrid();
                        Close();
                    }
                }
                if(lblTitre.Text == "Modifier Categorie")
                {
                    DialogResult DR=MessageBox.Show("Voulez vous modifier la catégorie?", "Modifier", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DR == DialogResult.Yes)
                    {
                        clcat.Modifier_Categorie(idcategorie, txtNom.Text);
                        MessageBox.Show("Catégorie modifiée", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        //actualiser datagrid
                        (usercat as USER_Liste_Categorie).Actualisedatagrid();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Modification annulée", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            
        }
    }
}
