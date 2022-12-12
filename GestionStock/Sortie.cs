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

namespace GestionStock
{
    public partial class Sortie : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\GestionStock\GestionStock\Database1.mdf;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        public int SelectedMotifValue;
        public int SelectedDemandeurValue;
        public string UserRole;
        public Sortie()
        {
            InitializeComponent();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            SortieForm sortie = new SortieForm();
            sortie.buttonModifier.Visible = false;
            sortie.ShowDialog();

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            GDemandeur gdemandeur = new GDemandeur();
            gdemandeur.ShowDialog();
        }

        private void buttonMotif_Click(object sender, EventArgs e)
        {
            GMotif gmotif = new GMotif();
            gmotif.ShowDialog();
        }

        private void Sortie_Load(object sender, EventArgs e)
        {
            if (UserRole == "UtilisateurC")
            {
                buttonSupprimer.Enabled = false;
                kryptonButton2.Enabled = false;
                buttonMotif.Enabled = false;
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
            foreach (DataRow row in dt3.Rows) {
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
                if (QteEntranteTotal != 0) {

                    double PrixUnitaireMoyen = (double)MontantTotal / (double)QteEntranteTotal;
                    PrixUnitaireMoyen = Convert.ToDouble(String.Format("{0:0.00}", PrixUnitaireMoyen));
                    SqlCommand cmd5 = new SqlCommand("update [Sortie] set PrixUnitaireMoyenHT =@p1 where Designation = '"+Desi+"' ", con);
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

            SqlCommand cmd2 = new SqlCommand("update [Sortie] set ValeurSortie = QuantiteSortante * PrixUnitaireMoyenHT",con);
            cmd2.ExecuteNonQuery();
            
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [Sortie]", con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sda.Fill(dtbl);
            dgv.DataSource = dtbl;
            dgv.Columns["PrixUnitaireMoyenHT"].HeaderText = "Prix UM Pondéré";
            dgv.Columns["Supprime"].HeaderText = "Supprimé ?";
            con.Close();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd2 = new SqlCommand("update [Sortie] set ValeurSortie = QuantiteSortante * PrixUnitaireMoyenHT", con);
            cmd2.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [Sortie]", con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sda.Fill(dtbl);
            dgv.DataSource = dtbl;
            dgv.Columns["PrixUnitaireMoyenHT"].HeaderText = "Prix UM Pondéré";
            dgv.Columns["Supprime"].HeaderText = "Supprimé ?";
            con.Close();
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
                    cmd.CommandText = "Delete from [Sortie] where id='" + id + "'";

                    dgv.Rows.RemoveAt(this.dgv.SelectedRows[0].Index);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Sortie supprimé avec succès !");
                }



            }
            else
            {
                MessageBox.Show("Veuillez selectionner une ligne !", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            SortieForm sform = new SortieForm();
            sform.Modifier = 1;
            sform.buttonAjouter.Visible = false;
            sform.labelTitre.Text = "Modifier une sortie";
            if (this.dgv.SelectedRows.Count > 0) {
                sform.SelectedID = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);
                sform.txtDesi1.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
                sform.txtUnite.Text = dgv.SelectedRows[0].Cells[2].Value.ToString();
                sform.txtQSortante.Text = dgv.SelectedRows[0].Cells[3].Value.ToString();
                DateTime sortie = DateTime.Parse(dgv.SelectedRows[0].Cells[4].Value.ToString());
                sform.DateSortie.Value = sortie;

                //Transfert du data du dgv a Motif Combobox

                con.Open();
                string Motif = dgv.SelectedRows[0].Cells[5].Value.ToString();
                string selectQuery1 = "SELECT * FROM [Motif] WHERE Motif = '" + Motif + "' ";
                SqlCommand cmd1 = new SqlCommand(selectQuery1, con);
                SqlDataReader rd1 = cmd1.ExecuteReader();
                if (rd1.Read())
                {
                    string selectedValue1 = rd1.GetValue(rd1.GetOrdinal("Id")).ToString();
                    SelectedMotifValue = Convert.ToInt32(selectedValue1);

                }
                else
                {
                    MessageBox.Show("Erreur", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
                sform.SelectedMotifValue = SelectedMotifValue;
                sform.txtAffOb.Text = dgv.SelectedRows[0].Cells[6].Value.ToString();

                // Transfert du data du dgv a Demandeur Combobox

                con.Open();
                string Demandeur = dgv.SelectedRows[0].Cells[7].Value.ToString();
                string selectQuery2 = "SELECT * FROM [Demandeur] WHERE NomDemandeur = '" + Demandeur + "' ";
                SqlCommand cmd2 = new SqlCommand(selectQuery2, con);
                SqlDataReader rd2 = cmd2.ExecuteReader();
                if (rd2.Read())
                {
                    string selectedValue2 = rd2.GetValue(rd2.GetOrdinal("Id")).ToString();
                    SelectedDemandeurValue = Convert.ToInt32(selectedValue2);

                }
                else
                {
                    MessageBox.Show("Erreur", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
                sform.SelectedDemandeurValue = SelectedDemandeurValue;


                string PUMHT = dgv.SelectedRows[0].Cells[8].Value.ToString();
                PUMHT = PUMHT.Replace(',', '.');
                sform.txtPUMHT.Text = PUMHT;


                string ValeurS = dgv.SelectedRows[0].Cells[9].Value.ToString();
                ValeurS = ValeurS.Replace(',', '.');
                sform.txtValeurS.Text = ValeurS;

                sform.ShowDialog();


            }
            else
            {
                MessageBox.Show("Veuillez selectionner une ligne !", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
