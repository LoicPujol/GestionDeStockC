using System;
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
            combocategorie.SelectedIndex = -1;

            //afficher type selon table dans combobox
            combotype.DataSource = db.Types.ToList();
            //pour filtrer seulement les nom de categorie
            combotype.DisplayMember = "Nom_Type";//afficher les nom des categorie
            combotype.ValueMember = "ID_Type";
            combotype.SelectedIndex = -1;
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
            if (picProduit.Image == null)
            {
                return "Entrer l'image du produit";
            }
            if (combocategorie.Text == "")
            {
                return "entrer nom categorie";
            }
            if (combotype.Text == "")
            {
                return "entrer nom type";
            }
            return null;
        }
        private void btnactualiser_Click(object sender, EventArgs e)
        {
            txtNomP.Text = "Nom Produit"; txtNomP.ForeColor = Color.Silver;
            txtQuantite.Text = "Quantite"; txtQuantite.ForeColor = Color.Silver;
            txtPrix.Text = "Prix"; txtPrix.ForeColor = Color.Silver;
            txtPrix.Text = "Stock Alerte"; txtPrix.ForeColor = Color.Silver;
            combocategorie.SelectedIndex = -1;
            combotype.SelectedIndex = -1;
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
            if (OP.ShowDialog() == DialogResult.OK)
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
            }
            else
            {
                if (lblTitre.Text == "Ajouter Produit")
                {
                    BL.CLS_Produit clproduit = new BL.CLS_Produit();
                    //convertir image en format byte
                    //ajouter system Io 
                    MemoryStream MR = new MemoryStream();
                    picProduit.Image.Save(MR, picProduit.Image.RawFormat);
                    byte[] byteimageP = MR.ToArray();//convertir image en format bye[]
                                                     //DateTime NewDate = new DateTime();

                    
                    if (clproduit.Ajouter_Produit(txtNomP.Text, int.Parse(txtQuantite.Text), int.Parse(txtStockAlerte.Text), txtPrix.Text, byteimageP, Convert.ToInt32(combocategorie.SelectedValue), Convert.ToInt32(combotype.SelectedValue),txtDateCtrl.Text, txtInventaireProd.Text) == true)
                    {
                        MessageBox.Show("Produit ajoute avec succe", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (UserProduit as USER_Liste_Produit).Actualiserdvg();
                        Close();
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
                        
                           cLS_Produit.Modifier_Produit(IDPRODUIT, txtNomP.Text, int.Parse(txtQuantite.Text), int.Parse(txtStockAlerte.Text), txtPrix.Text, byteimageP, Convert.ToInt32(combocategorie.SelectedValue), Convert.ToInt32(combotype.SelectedValue),txtDateCtrl.Text, txtInventaireProd.Text);
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
        private void txtStockAlerte_Enter(object sender, EventArgs e)
        {
            if (txtStockAlerte.Text == "Stock Alerte")
            {
                txtStockAlerte.Text = "";
                txtStockAlerte.ForeColor = Color.Black;
            }
        }
        private void txtStockAlerte_Leave(object sender, EventArgs e)
        {
            if (txtStockAlerte.Text == "")
            {
                txtStockAlerte.Text = "Stock Alerte";
                txtStockAlerte.ForeColor = Color.Silver;
            }
        }
        private void txtStockAlerte_KeyPress(object sender, KeyPressEventArgs e)
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
        private void combotype_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (combotype.Text == "Unitaire")
            {
                grpDateCtrl.Visible = true;
                txtQuantite.Enabled = false;
                txtQuantite.Text = "1";
            }
            if (combotype.Text == "Lot")
            {
                grpDateCtrl.Visible = false;
                txtQuantite.Enabled = true;
                txtQuantite.Text = "Quantite";
            }
            if (combotype.Text == "Consomable")
            {
                grpDateCtrl.Visible = false;
                txtQuantite.Enabled = true;
                txtQuantite.Text = "Quantite";
            }
        }
        private void checkDate_Click(object sender, EventArgs e)
        {
            if (checkDate.Checked)
            {
                btnDate.Visible = true;
                txtDateCtrl.Visible = true;
            }
            else
                btnDate.Visible = false;
                txtDateCtrl.Visible = false;
                txtDateCtrl.Text = "";
            }
        private void txtInventaireProd_Enter(object sender, EventArgs e)
        {
            if (txtInventaireProd.Text == "N° Inventaire")
            {
                txtInventaireProd.Text = "";
                txtInventaireProd.ForeColor = Color.Black;
            }
        }
        private void txtInventaireProd_Leave(object sender, EventArgs e)
        {
            if (txtInventaireProd.Text == "")
            {
                txtInventaireProd.Text = "N° Inventaire";
                txtInventaireProd.ForeColor = Color.Silver;
            }

        }
        private void btnIncrementer_Click(object sender, EventArgs e)
        {
            var Inventaire = db.Produits;
            int i = 100;
            MessageBox.Show("base" + i.ToString());

            foreach (var l in Inventaire)
            {
                if (i.ToString() == l.NumInventaire.ToString())
                {
                    i = i + 1;
                    MessageBox.Show("ID" + l.NumInventaire.ToString());
                    MessageBox.Show("base + 1" + i.ToString());
                }
                else
                {
                    MessageBox.Show("ID" + l.NumInventaire.ToString());
                    break;
                }
            }
        }
        private void btnDate_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajoute_Date frmDate = new PL.FRM_Ajoute_Date();
            frmDate.ShowDialog();
            txtDateCtrl.Visible = true;
            txtDateCtrl.Text = frmDate.dateCtrl.Value.ToString("dd/MM/yyyy");
        }
    }
}
