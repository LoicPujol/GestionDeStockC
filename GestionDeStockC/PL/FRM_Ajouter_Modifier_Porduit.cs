﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GestionDeStockC.PL
{
    public partial class FRM_Ajouter_Modifier_Porduit : Form
    {
        private dbStockContext db;
        private UserControl UserProduit;
        public FRM_Ajouter_Modifier_Porduit(UserControl User)
        {
            InitializeComponent();
            db = new dbStockContext();
            this.UserProduit = User;
            //afficher categorie selon table dans combobox
            combocategorie.DataSource = db.Categories.ToList();
            //pour filtrer seulement les nom de categorie
            combocategorie.DisplayMember = "Nom_Categorie";//afficher les nom des categorie
            combocategorie.ValueMember = "ID_Categorie";
        }
        //test champ obligatoire
        string testoblogatoire()
        {
            if (txtNomP.Text == "" || txtNomP.Text == "Nom Produit")
            {
                return "Entrer le Nom de Produit";
            }
            if (txtQuantite.Text == "" || txtQuantite.Text == "Quantite")
            {
                return "Entrer une quantite";
            }
            if (txtPrix.Text == "" || txtPrix.Text == "Prix")
            {
                return "Entrer un prix";
            }
            if(picProduit.Image==null)
            {
                return "Entrer l'image du produit";
            }
            if(combocategorie.Text=="")
            {
                return "entrer nom categorie";
            }
            return null;
        }

        private void btnactualiser_Click(object sender, EventArgs e)
        {
            txtNomP.Text = "Nom Produit"; txtNomP.ForeColor = Color.Silver;
            txtQuantite.Text = "Quantite"; txtQuantite.ForeColor = Color.Silver;
            txtPrix.Text = "Prix"; txtPrix.ForeColor = Color.Silver;
            combocategorie.Text = ""; // ATTENTION ICI LE COMBO BOX NE SE DECHARGE PAS
            picProduit.Image = null;
        }

        private void txtNomP_Enter(object sender, EventArgs e)
        {
            if (txtNomP.Text == "Nom Produit")
            {
                txtNomP.Text = "";
                txtNomP.ForeColor = Color.Black;
            }
        }

        private void txtNomP_Leave(object sender, EventArgs e)
        {
            if (txtNomP.Text == "")
            {
                txtNomP.Text = "Nom Produit";
                txtNomP.ForeColor = Color.Silver;
            }
        }

        private void txtQuantite_Enter(object sender, EventArgs e)
        {
            if (txtQuantite.Text == "Quantite")
            {
                txtQuantite.Text = "";
                txtQuantite.ForeColor = Color.Black;
            }
        }

        private void txtQuantite_Leave(object sender, EventArgs e)
        {
            if (txtQuantite.Text == "")
            {
                txtQuantite.Text = "Quantite";
                txtQuantite.ForeColor = Color.Silver;
            }
        }

        private void txtPrix_Enter(object sender, EventArgs e)
        {
            if (txtPrix.Text == "Prix")
            {
                txtPrix.Text = "";
                txtPrix.ForeColor = Color.Black;
            }
        }

        private void txtPrix_Leave(object sender, EventArgs e)
        {
            if (txtPrix.Text == "")
            {
                txtPrix.Text = "Prix";
                txtPrix.ForeColor = Color.Silver;
            }
        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnparcourir_Click(object sender, EventArgs e)
        {
            //Afficher fichier Image
            OpenFileDialog OP = new OpenFileDialog();
            OP.Filter = "|*.JPG;*.PNG;*.GIF;*.BMP"; //pour afficher seulement les fichier type image
            if (OP.ShowDialog()==DialogResult.OK)
            {
                picProduit.Image = Image.FromFile(OP.FileName);
            }
        }

        private void txtQuantite_KeyPress(object sender, KeyPressEventArgs e)
        {
            //textbox numerique
            if (e.KeyChar < 48 || e.KeyChar > 57)//code asci des numero de tel
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void txtPrix_KeyPress(object sender, KeyPressEventArgs e)
        {
            //textbox numerique
            if (e.KeyChar < 48 || e.KeyChar > 57)//code asci des numero de tel
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
        public int IDPRODUIT;
        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            if (testoblogatoire() != null)
            {
                MessageBox.Show(testoblogatoire(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                if (lblTitre.Text == "Ajouter Produit")
                {
                    BL.CLS_Produit clproduit = new BL.CLS_Produit();
                    //convertir image en format byte
                    //ajouter system Io 
                    MemoryStream MR = new MemoryStream();
                    picProduit.Image.Save(MR, picProduit.Image.RawFormat);
                    byte[] byteimageP = MR.ToArray();//convertir image en format bye[]
                    if (clproduit.Ajouter_Produit(txtNomP.Text, int.Parse(txtQuantite.Text), txtPrix.Text, byteimageP, Convert.ToInt32(combocategorie.SelectedValue)) == true)
                    {
                        MessageBox.Show("Produit ajoute avec succe", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (UserProduit as USER_Liste_Produit).Actualiserdvg();
                    }
                    else
                    {
                        MessageBox.Show("Produit existe deja", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else //si titre n'est pas ajoute produit alors c'est une modificaton
                {
                    MemoryStream MR = new MemoryStream();
                    picProduit.Image.Save(MR, picProduit.Image.RawFormat);
                    byte[] byteimageP = MR.ToArray();//convertir image en format bye[]
                    BL.CLS_Produit cLS_Produit = new BL.CLS_Produit();
                    DialogResult RS = MessageBox.Show("Voulez vous modifier", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (RS == DialogResult.Yes)
                    {
                        cLS_Produit.Modifier_Produit(IDPRODUIT, txtNomP.Text, int.Parse(txtQuantite.Text), txtPrix.Text, byteimageP, Convert.ToInt32(combocategorie.SelectedValue));
                        MessageBox.Show("Produit modifier", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        //Actualiser datagrid
                        (UserProduit as USER_Liste_Produit).Actualiserdvg();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Modification annule", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}