using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using excel = Microsoft.Office.Interop.Excel;
using System.Configuration;

namespace GestionStock
{
    public partial class Entree : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\GestionStock\GestionStock\Database1.mdf;Integrated Security=True");
        //String con = ConfigurationManager.ConnectionStrings["GestionStock.Properties.Settings.Database1ConnectionString"].ToString();
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        public int SelectedFournisseurValue;
        public string UserRole;
        
        public Entree()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntreeForm Eform = new EntreeForm();
            Eform.buttonModifier.Visible = false;
            Eform.ShowDialog();
        }

        private void Entree_Load(object sender, EventArgs e)
        {
            if (UserRole == "UtilisateurC")
            {
                buttonSupprimer.Enabled = false;
            }
            else if (UserRole == "UtilisateurB") {
                buttonSupprimer.Enabled = false;
            }

            con.Open();
            
            

            SqlCommand cmd3 = new SqlCommand("select Designation from [Article]", con);
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            DataTable dt3 = new DataTable();
            DataTable dt4 = new DataTable();

            da3.Fill(dt3);
            foreach (DataRow row in dt3.Rows)
            {
                string Desi = row["Designation"].ToString();
                SqlCommand cmd4 = new SqlCommand("select Designation , QuantiteEntrante , MontantFactureHT from [Entree]", con);
                SqlDataAdapter da4 = new SqlDataAdapter(cmd4);
                da4.Fill(dt4);

                double MontantTotal;
                if (dt4.Compute("SUM(MontantFactureHT)", "Designation = '" + Desi + "' ") is System.DBNull)
                {
                    MontantTotal = 0;
                }
                else
                {
                    MontantTotal = Convert.ToDouble(dt4.Compute("SUM(MontantFactureHT)", "Designation = '" + Desi + "' "));
                }

                double QteEntranteTotal;
                if (dt4.Compute("SUM(QuantiteEntrante)", "Designation = '" + Desi + "' ") is System.DBNull)
                {
                    QteEntranteTotal = 0;
                }
                else
                {
                    QteEntranteTotal = Convert.ToDouble(dt4.Compute("SUM(QuantiteEntrante)", "Designation = '" + Desi + "' "));
                }
                if (QteEntranteTotal != 0)
                {

                    double PrixUnitaireMoyen = (double)MontantTotal / (double)QteEntranteTotal;
                    PrixUnitaireMoyen = Convert.ToDouble(String.Format("{0:0.00}", PrixUnitaireMoyen));
                    SqlCommand cmd5 = new SqlCommand("update [Sortie] set PrixUnitaireMoyenHT =@p1 where Designation = '" + Desi + "' ", con);
                    cmd5.Parameters.AddWithValue("@p1", PrixUnitaireMoyen);
                    cmd5.ExecuteNonQuery();
                    SqlCommand cmd6 = new SqlCommand("update [Article] set PrixUM =@p1 where Designation = '" + Desi + "'", con);
                    cmd6.Parameters.AddWithValue("@p1", PrixUnitaireMoyen);
                    cmd6.ExecuteNonQuery();
                    SqlCommand cmd7 = new SqlCommand("update [EtatStock] set PrixUnitaireMoyen =@p1 where Designation = '" + Desi + "'", con);
                    cmd7.Parameters.AddWithValue("@p1", PrixUnitaireMoyen);
                    cmd7.ExecuteNonQuery();



                }

            }

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [Entree]", con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sda.Fill(dtbl);
            dgv.DataSource = dtbl;
            dgv.Columns["PrixUnitaireCalculeHT"].HeaderText = "Prix Unitaire BL";
            dgv.Columns["Supprime"].HeaderText = "Supprimé ?";
            con.Close();
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            EntreeForm eform = new EntreeForm();
            eform.buttonAjouter.Visible = false;
            eform.Modifier = 1;
            eform.labelTitre.Text = "Modifier une entrée";
            if (this.dgv.SelectedRows.Count > 0)
            {
                eform.SelectedID = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);
                eform.txtDesi1.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
                eform.txtDA.Text = dgv.SelectedRows[0].Cells[2].Value.ToString();
                eform.txtBL.Text = dgv.SelectedRows[0].Cells[3].Value.ToString();

                //Transfert de date de commande
                DateTime commande = DateTime.Parse(dgv.SelectedRows[0].Cells[4].Value.ToString());
                eform.txtDateCommande.Value = commande;

                //Transfert de date de reception
                DateTime reception = DateTime.Parse(dgv.SelectedRows[0].Cells[5].Value.ToString());
                eform.txtDateReception.Value = reception;

                eform.txtUnite.Text = dgv.SelectedRows[0].Cells[6].Value.ToString();

                string QEntrante = dgv.SelectedRows[0].Cells[7].Value.ToString();
                QEntrante = QEntrante.Replace(',', '.');
                eform.txtQEntrante.Text = QEntrante;
                
                string PrixUCHT = dgv.SelectedRows[0].Cells[8].Value.ToString();
                PrixUCHT = PrixUCHT.Replace(',', '.');
                eform.txtPrixUCHT.Text = PrixUCHT;

                //Transfert du data du dgv a fournisseur combobox

                
                con.Open();
                string Fournisseur = dgv.SelectedRows[0].Cells[10].Value.ToString();
                string selectQuery1 = "SELECT * FROM [Fournisseur] WHERE NomFournisseur = '" + Fournisseur + "' ";
                SqlCommand cmd1 = new SqlCommand(selectQuery1, con);
                SqlDataReader rd1 = cmd1.ExecuteReader();
                if (rd1.Read())
                {
                    string selectedValue1 = rd1.GetValue(rd1.GetOrdinal("Id")).ToString();
                    SelectedFournisseurValue = Convert.ToInt32(selectedValue1);

                }
                else
                {
                    MessageBox.Show("Erreur", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
                eform.SelectedFournisseurValue = SelectedFournisseurValue;
                eform.txtFabricant.Text = dgv.SelectedRows[0].Cells[11].Value.ToString();
                eform.txtMA.Text = dgv.SelectedRows[0].Cells[12].Value.ToString();
                eform.txtAcheteur.Text = dgv.SelectedRows[0].Cells[13].Value.ToString();
                eform.txtMP.Text = dgv.SelectedRows[0].Cells[14].Value.ToString();
                eform.labelDelai.Text = dgv.SelectedRows[0].Cells[15].Value.ToString();
                string FHabituel = dgv.SelectedRows[0].Cells[16].Value.ToString();
                if (FHabituel == "Oui")
                {
                    eform.checkHabituel.Checked = true;
                }
                else {
                    eform.checkHabituel.Checked = false;
                }
                eform.ShowDialog();

            }
            else {
                MessageBox.Show("Veuillez selectionner une ligne !", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (this.dgv.SelectedRows.Count > 0)
            {
                DialogResult res = MessageBox.Show("Vous voulez vraiment supprimer cette ligne ?", null, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (res == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    int id = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);
                    cmd.CommandText = "Delete from [Entree] where id='" + id + "'";

                    dgv.Rows.RemoveAt(this.dgv.SelectedRows[0].Index);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Entrée supprimé avec succès !");
                }



            }
            else {
                MessageBox.Show("Veuillez selectionner une ligne !", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonActualiser_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [Entree]", con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sda.Fill(dtbl);
            dgv.DataSource = dtbl;
            dgv.Columns["PrixUnitaireCalculeHT"].HeaderText = "Prix Unitaire BL";
            dgv.Columns["Supprime"].HeaderText = "Supprimé ?";
            con.Close();
        }

        private void copyAlltoClipboard()
        {
            dgv.SelectAll();
            DataObject dataObj = dgv.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void buttonExporter_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            excel.Range CR = (excel.Range)xlWorkSheet.Cells[1, 1];
            xlWorkSheet.Columns.AutoFit();
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
    }
}
