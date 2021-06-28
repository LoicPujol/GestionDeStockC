using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

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
                dvgclient.Rows.Add(S.ID_Client, S.Num_Client, S.Nom_Client, S.Prenom_Client, S.Rabais, S.Adresse_Client, S.Code_Zip, S.Ville_Client, S.Pays_Client, S.Telephone_Client, S.Email_Client);//ajouter ligne dans datagrid
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

                if ((dvgclient.CurrentRow != null) || (dvgclient.Rows.Count != 0))
                {
                        frmclient.txtNom.Text = dvgclient.CurrentRow.Cells[2].Value.ToString();
                        frmclient.txtPrenom.Text = dvgclient.CurrentRow.Cells[3].Value.ToString();
                        frmclient.txtAdresse.Text = dvgclient.CurrentRow.Cells[5].Value.ToString();
                        frmclient.txtTelephone.Text = dvgclient.CurrentRow.Cells[9].Value.ToString();
                        frmclient.txtEmail.Text = dvgclient.CurrentRow.Cells[10].Value.ToString();
                        frmclient.txtVille.Text = dvgclient.CurrentRow.Cells[7].Value.ToString();
                        frmclient.txtPays.Text = dvgclient.CurrentRow.Cells[8].Value.ToString();
                        frmclient.lblTitre.Text = "Modifier Client";
                        frmclient.txtNumClient.Text = dvgclient.CurrentRow.Cells[1].Value.ToString();
                        frmclient.txtNumClient.ForeColor = Color.Silver;
                        frmclient.txtNumClient.Enabled = false;
                        frmclient.txtZip.Text = dvgclient.CurrentRow.Cells[6].Value.ToString();
                        frmclient.txtRabais.Text = dvgclient.CurrentRow.Cells[4].Value.ToString();
                        frmclient.ShowDialog();
                }else
                {
                MessageBox.Show("Aucun client selectionnee", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        private void btnsupprimerclient_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("Voulez vous vraiment supprimer un client", "Suppresion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (R == DialogResult.Yes)
            {
                BL.CLS_Client clclient = new BL.CLS_Client();
                if ((dvgclient.CurrentRow != null) || (dvgclient.Rows.Count != 0))
                {
                    int idselect = (int)dvgclient.CurrentRow.Cells[0].Value;// id de la ligne cocher
                    int NbreProd = db.Affectations.Count(s => s.ID_Client == idselect);
                    if (NbreProd == 0)
                    {
                        clclient.Supprimer_Client(idselect);
                        Actualisedatagrid();
                        MessageBox.Show("suppression avec succe", "suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        DialogResult PDR = MessageBox.Show("Il y a " + NbreProd + " affectatins pour ce produit vous ne pouvez pas le supprimer", "Supprime", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("suppression et annule", "suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            dvgclient.Rows.Clear();
            foreach(var l in listerecherche)
                {
                dvgclient.Rows.Add(l.ID_Client, l.Num_Client, l.Nom_Client, l.Prenom_Client, l.Rabais, l.Adresse_Client, l.Code_Zip, l.Ville_Client, l.Pays_Client, l.Telephone_Client, l.Email_Client);//ajouter ligne dans datagrid
            }
            dvgclient.ClearSelection();
        }
        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajoute_Modifier_Client frmclient = new PL.FRM_Ajoute_Modifier_Client(this);
            Client CL = new Client();
            if (dvgclient.CurrentRow != null)
            { 
                        frmclient.IDselect = (int)dvgclient.CurrentRow.Cells[1].Value;
                        frmclient.txtNom.Text = dvgclient.CurrentRow.Cells[2].Value.ToString();
                        frmclient.txtNom.ForeColor = Color.Black;
                        frmclient.txtPrenom.Text = dvgclient.CurrentRow.Cells[3].Value.ToString();
                        frmclient.txtPrenom.ForeColor = Color.Black;
                        frmclient.txtAdresse.Text = dvgclient.CurrentRow.Cells[4].Value.ToString();
                        frmclient.txtAdresse.ForeColor = Color.Black;
                        frmclient.txtTelephone.Text = dvgclient.CurrentRow.Cells[5].Value.ToString();
                        frmclient.txtTelephone.ForeColor = Color.Black;
                        frmclient.txtEmail.Text = dvgclient.CurrentRow.Cells[6].Value.ToString();
                        frmclient.txtEmail.ForeColor = Color.Black;
                        frmclient.txtVille.Text = dvgclient.CurrentRow.Cells[7].Value.ToString();
                        frmclient.txtVille.ForeColor = Color.Black;
                        frmclient.txtPays.Text = dvgclient.CurrentRow.Cells[8].Value.ToString();
                        frmclient.txtPays.ForeColor = Color.Black;
                        frmclient.lblTitre.Text = "Modifier Client";
                        frmclient.ShowDialog();
            }
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog SDF = new SaveFileDialog() { Filter = "Excel Workbook |*xlsx", ValidateNames = true })//filtrer seulement fichier excel
            {
                if (SDF.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    //Les noms des colones :
                    ws.Cells[1, 1] = "Numero Client";
                    ws.Cells[1, 2] = "Nom Client";
                    ws.Cells[1, 3] = "Prenom Client";
                    ws.Cells[1, 4] = "Rabais";
                    ws.Cells[1, 5] = "Adresse";
                    ws.Cells[1, 6] = "Code Zip";
                    ws.Cells[1, 7] = "Ville";
                    ws.Cells[1, 8] = "Pays";
                    ws.Cells[1, 9] = "Numero de telephone";
                    ws.Cells[1, 10] = "Mail";

                    //liste des produits
                    var ListeClient = db.Clients.ToList();
                    int i = 2;
                    foreach (var L in ListeClient)
                    {
                        ws.Cells[i, 1] = L.Num_Client;
                        ws.Cells[i, 2] = L.Nom_Client;
                        ws.Cells[i, 3] = L.Prenom_Client;
                        ws.Cells[i, 4] = L.Rabais;
                        ws.Cells[i, 5] = L.Adresse_Client;
                        ws.Cells[i, 6] = L.Code_Zip;
                        ws.Cells[i, 7] = L.Ville_Client;
                        ws.Cells[i, 8] = L.Pays_Client;
                        ws.Cells[i, 9] = L.Telephone_Client;
                        ws.Cells[i, 10] = L.Email_Client;
                        
                        i++;
                    }
                    //Mise en forme de l'excel
                    ws.Range["A1:J1"].Interior.Color = Color.Blue;
                    ws.Range["A1:J1"].Font.Color = Color.White;
                    ws.Range["A1:J1"].Font.Size = 15;
                    ws.Range["A:J"].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    ws.Range["A1:J1"].ColumnWidth = 16;



                    //Fermer classeur
                    wb.SaveAs(SDF.FileName);
                    app.Quit();
                    MessageBox.Show("Sauvegarde ok", "Excel", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }
    }
}
