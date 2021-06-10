using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace GestionDeStockC.PL
{
    public partial class FRM_Ajoute_Modifier_Client : Form
    {
        private UserControl usclient;
        public FRM_Ajoute_Modifier_Client(UserControl userC)
        {
            InitializeComponent();
            this.usclient = userC;
        }

        //les champs obligatoire
        string testoblogatoire()
        {
            if(txtNom.Text == "" || txtNom.Text == "Nom de Client")
            {
                return "Entrer le Nom de Client";
            }
            if (txtPrenom.Text == "" || txtPrenom.Text == "Prenom de Client")
            {
                return "Entrer le Prenom de Client";
            }
            if (txtAdresse.Text == "" || txtAdresse.Text == "Adresse Client")
            {
                return "Entrer l'adresse de Client";
            }
            if (txtTelephone.Text == "" || txtTelephone.Text == "Telephone Client")
            {
                return "Entrer le telephone de Client";
            }
            if (txtEmail.Text == "" || txtEmail.Text == "Email Client")
            {
                return "Entrer le Email de Client";
            }
            if (txtPays.Text == "" || txtPays.Text == "Pays Client")
            {
                return "Entrer le Pays de Client";
            }
            if (txtVille.Text == "" || txtVille.Text == "Ville Client")
            {
                return "Entrer la ville de Client";
            }
            //verifier si email valide
            if (txtEmail.Text != "" || txtEmail.Text != "Email Client")
            {
                try
                {
                    new MailAddress(txtEmail.Text);//pour verifier si email valide

                } catch (Exception e)
                {
                    return ("Email non valide");
                }
            }
            return null;
        }

        private void txtNom_Enter(object sender, EventArgs e)
        {
            if(txtNom.Text=="Nom de Client")
            {
                txtNom.Text = "";
                txtNom.ForeColor = Color.Black;
            }
        }
        private void txtNom_Leave(object sender, EventArgs e)
        {
            if (txtNom.Text == "")
            {
                txtNom.Text = "Nom de Client";
                txtNom.ForeColor = Color.Silver;
            }

        }

        private void txtPrenom_Enter(object sender, EventArgs e)
        {
            if (txtPrenom.Text == "Prenom de Client")
            {
                txtPrenom.Text = "";
                txtPrenom.ForeColor = Color.Black;
            }
        }

        private void txtPrenom_Leave(object sender, EventArgs e)
        {
            if (txtPrenom.Text == "")
            {
                txtPrenom.Text = "Prenom de Client";
                txtPrenom.ForeColor = Color.Silver;
            }
        }

        private void txtAdresse_Enter(object sender, EventArgs e)
        {
            if (txtAdresse.Text == "Adresse Client")
            {
                txtAdresse.Text = "";
                txtAdresse.ForeColor = Color.Black;
            }
        }

        private void txtAdresse_Leave(object sender, EventArgs e)
        {
            if (txtAdresse.Text == "")
            {
                txtAdresse.Text = "Adresse Client";
                txtAdresse.ForeColor = Color.Silver;
            }
        }

        private void txtTelephone_Enter(object sender, EventArgs e)
        {
            if (txtTelephone.Text == "Telephone Client")
            {
                txtTelephone.Text = "";
                txtTelephone.ForeColor = Color.Black;
            }
        }

        private void txtTelephone_Leave(object sender, EventArgs e)
        {
            if (txtTelephone.Text == "")
            {
                txtTelephone.Text = "Telephone Client";
                txtTelephone.ForeColor = Color.Silver;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email Client")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email Client";
                txtEmail.ForeColor = Color.Silver;
            }
        }

        private void txtPays_Enter(object sender, EventArgs e)
        {
            if (txtPays.Text == "Pays Client")
            {
                txtPays.Text = "";
                txtPays.ForeColor = Color.Black;
            }
        }

        private void txtPays_Leave(object sender, EventArgs e)
        {
            if (txtPays.Text == "")
            {
                txtPays.Text = "Pays Client";
                txtPays.ForeColor = Color.Silver;
            }
        }

        private void txtVille_Enter(object sender, EventArgs e)
        {
            if (txtVille.Text == "Ville Client")
            {
                txtVille.Text = "";
                txtVille.ForeColor = Color.Black;
            }
        }

        private void txtVille_Leave(object sender, EventArgs e)
        {
            if (txtVille.Text == "")
            {
                txtVille.Text = "Ville Client";
                txtVille.ForeColor = Color.Silver;
            }
        }
        private void btnquitter_Click(object sender, EventArgs e)
        {
            Close();//Quitter le formulaire de saisie
        }

        private void txtTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //textbox numerique
            if(e.KeyChar<48 || e.KeyChar>57)//code asci des numero de tel
            {
                e.Handled = true;
            }
            if(e.KeyChar==8)
            {
                e.Handled = false;
            }
        }
        public int IDselect;
        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            if(testoblogatoire()!=null)
            {
                MessageBox.Show(testoblogatoire(),"Obligatoire",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }else
            if(lblTitre.Text=="Ajouter Client")
            {
                BL.CLS_Client clclient = new BL.CLS_Client();
                if(clclient.Ajouter_Client(txtNom.Text,txtPrenom.Text,txtAdresse.Text,txtTelephone.Text,txtEmail.Text,txtVille.Text,txtPays.Text)==true)
                {
                    MessageBox.Show("Client ajouté avec succés", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (usclient as USER_Liste_Client).Actualisedatagrid();
                    Close();
                }
                else
                {
                    MessageBox.Show("Nom et prénom éxistent déja", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else //si lblTitre=Modifier client
            {
                BL.CLS_Client clclient = new BL.CLS_Client();
                DialogResult R = MessageBox.Show("Voulez vous vraiment modifier ce client", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(R==DialogResult.Yes)
                {
                    clclient.Modifier_Client(IDselect, txtNom.Text, txtPrenom.Text, txtAdresse.Text, txtTelephone.Text, txtEmail.Text, txtVille.Text, txtPays.Text);
                    //pour actualiser datzgrid wiev
                    (usclient as USER_Liste_Client).Actualisedatagrid();
                    MessageBox.Show("Client modifie avec succe","Modification",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    Close();
                }
                else
                {
                    MessageBox.Show("Modification est annule", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
        }

        private void btnactualiser_Click(object sender, EventArgs e)
        {
            txtNom.Text = "Nom de Client"; txtNom.ForeColor = Color.Silver;
            txtPrenom.Text = "Prenom de Client"; txtPrenom.ForeColor = Color.Silver;
            txtAdresse.Text = "Adresse Client"; txtAdresse.ForeColor = Color.Silver;
            txtTelephone.Text = "Telephone Client"; txtTelephone.ForeColor = Color.Silver;
            txtEmail.Text = "Email Client"; txtEmail.ForeColor = Color.Silver;
            txtPays.Text = "Pays Client"; txtPays.ForeColor = Color.Silver;
            txtVille.Text = "Ville Client"; txtVille.ForeColor = Color.Silver;
        }

    }
}
