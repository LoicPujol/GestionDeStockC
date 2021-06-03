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
    public partial class USER_Liste_Client : UserControl
    {
        private static USER_Liste_Client Userclient;
        private dbStockContext db;
        //creer instance pour le usercontrole
        public static USER_Liste_Client Instance
        {
            get
            {
                if(Userclient==null)
                {
                    Userclient = new USER_Liste_Client();
                }
                return Userclient;
            }
        }

        public USER_Liste_Client()
        {
            InitializeComponent();
            db = new dbStockContext();
            //desactiver textbox recherche
            txtrecherche.Enabled = false;
        }
        //ajouter des datagridview
        public void Actualisedatagrid()
        {
            db = new dbStockContext();
            dvgclient.Rows.Clear();//vider datagrid view
            foreach(var S in db.Clients)
            {
                dvgclient.Rows.Add(false, S.ID_Client, S.Nom_Client, S.Prenom_Client, S.Adresse_Client, S.Telephone_Client, S.Email_Client, S.Ville_Client, S.Pays_Client);//ajouter ligne dans datagrid
            }
        }
        //verifier combien de ligne est selectioner
        public string SelectVerif()
        {
            int Nombreligneselect = 0;
            for (int i=0;i<dvgclient.RowCount;i++)
            {
                if((bool)dvgclient.Rows[i].Cells[0].Value==true)//si ligne est selectionner
                {
                    Nombreligneselect++;//nombre ligne +1
                }
            }
            if(Nombreligneselect==0)
            {
                return "Selectionner le Client a modifier";
            }
            if (Nombreligneselect > 1)
            {
                return "Selectionner seulement 1 seul client";
            }
            return null;
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(txtrecherche.Text=="Recherche")
            {
                txtrecherche.Text = "";
                txtrecherche.ForeColor = Color.Black;
            }
        }

        private void USER_Liste_Client_Load(object sender, EventArgs e)
        {
            Actualisedatagrid();
        }

        private void btnajouteclient_Click(object sender, EventArgs e)
        {
            //afficher formulaire ajout client
            PL.FRM_Ajoute_Modifier_Client frmclient = new FRM_Ajoute_Modifier_Client(this);
            frmclient.ShowDialog();
        }

        private void btnmodifierclient_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajoute_Modifier_Client frmclient = new PL.FRM_Ajoute_Modifier_Client(this);
            if(SelectVerif()==null)
            {
                for(int i=0;i<dvgclient.RowCount;i++)
                {
                    if((bool)dvgclient.Rows[i].Cells[0].Value==true)//si le chekbox est vraie afficher les information dans le formulaire
                    {
                        frmclient.IDselect = (int)dvgclient.Rows[i].Cells[1].Value;
                        frmclient.txtNom.Text = dvgclient.Rows[i].Cells[2].Value.ToString();
                        frmclient.txtNom.ForeColor = Color.Black;
                        frmclient.txtPrenom.Text = dvgclient.Rows[i].Cells[3].Value.ToString();
                        frmclient.txtPrenom.ForeColor = Color.Black;
                        frmclient.txtAdresse.Text = dvgclient.Rows[i].Cells[4].Value.ToString();
                        frmclient.txtAdresse.ForeColor = Color.Black;
                        frmclient.txtTelephone.Text = dvgclient.Rows[i].Cells[5].Value.ToString();
                        frmclient.txtTelephone.ForeColor = Color.Black;
                        frmclient.txtEmail.Text = dvgclient.Rows[i].Cells[6].Value.ToString();
                        frmclient.txtEmail.ForeColor = Color.Black;
                        frmclient.txtVille.Text = dvgclient.Rows[i].Cells[7].Value.ToString();
                        frmclient.txtVille.ForeColor = Color.Black;
                        frmclient.txtPays.Text = dvgclient.Rows[i].Cells[8].Value.ToString();
                        frmclient.txtPays.ForeColor = Color.Black;
                    }
                }
                frmclient.lblTitre.Text = "Modifier Client";
                frmclient.btnactualiser.Visible = false;
                frmclient.ShowDialog();
            }else
            {
                MessageBox.Show(SelectVerif(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnsupprimerclient_Click(object sender, EventArgs e)
        {
            BL.CLS_Client clclient = new BL.CLS_Client();
            //pour supprimer tout les client selectionne
            int select = 0;
            for (int i = 0;i<dvgclient.Rows.Count;i++)
            {
                if((bool)dvgclient.Rows[i].Cells[0].Value==true)
                {
                    select++;//combien de ligne selectionnez
                }
            }
            if(select==0)
            {
                MessageBox.Show("aucun client selectionner", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                DialogResult R =
                MessageBox.Show("Voulez vous vraiment supprimer les clients selectionne", "Suppresion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(R==DialogResult.Yes)
                {
                    //pour supprimer toutes les client selectionner
                    for (int i = 0; i < dvgclient.Rows.Count; i++)
                    {
                        if ((bool)dvgclient.Rows[i].Cells[0].Value == true)
                        {
                            clclient.Supprimer_Client(int.Parse(dvgclient.Rows[i].Cells[1].Value.ToString()));//id client
                        }
                    }
                    //actualiser datagrid view
                    Actualisedatagrid();
                    MessageBox.Show("suppression avec succe", "suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }else
                {
                    MessageBox.Show("suppression et annule", "suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void comborecherche_SelectedIndexChanged(object sender, EventArgs e)
        {
            //actvier texbox si choix effectue
            txtrecherche.Enabled = true;
            txtrecherche.Text = "";//vider le mot cle de recherche du texbox
        }
        
        private void txtrecherche_TextChanged(object sender, EventArgs e)
        {
            db = new dbStockContext();
            var listerecherche = db.Clients.ToList();//liste de recherche = liste des clients
            if(txtrecherche.Text!="")//pas vide
            {
                switch(comborecherche.Text)
                {
                    case "Nom":
                        listerecherche=listerecherche.Where(s => s.Nom_Client.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase)!=-1).ToList();
                        break;
                    case "Prenom":
                        listerecherche = listerecherche.Where(s => s.Prenom_Client.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Telephone":
                        listerecherche = listerecherche.Where(s => s.Telephone_Client.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Email":
                        listerecherche = listerecherche.Where(s => s.Email_Client.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Ville":
                        listerecherche = listerecherche.Where(s => s.Ville_Client.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Pays":
                        listerecherche = listerecherche.Where(s => s.Pays_Client.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
        
                }
            }
            //vide datagrid
            dvgclient.Rows.Clear();
            //ajouter listerecherche dans datagridview client
            foreach(var l in listerecherche)
                {
                dvgclient.Rows.Add(false, l.ID_Client, l.Nom_Client, l.Prenom_Client, l.Adresse_Client, l.Telephone_Client, l.Email_Client, l.Ville_Client, l.Pays_Client);
                }
        }
    }
}
