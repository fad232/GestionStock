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
    public partial class ListeAr : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\GestionStock\GestionStock\Database1.mdf;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        
        public int SelectedID;
        public int SelectedClassValue;
        public int SelectedFamilleValue;
        public int SelectedSFamilleValue;
        public int SelectedFournisseurValue;
        public string UserRole;
        
        


        public ListeAr()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            ArticleForm form = new ArticleForm();
            form.buttonModifier.Visible = false;
            Form2 form2 = new Form2();
            form2.Hide();
            
            form.Show();

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [Article]", con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sda.Fill(dtbl);
            dgv.DataSource = dtbl;
            dgv.Columns["PrixUM"].HeaderText = "Prix UM Pondéré";
            dgv.Columns["SFamille"].HeaderText = "Sous Famille";
            dgv.Columns["PO"].HeaderText = "Pièce obsolète ?";
            dgv.Columns["PrixUA"].HeaderText = "Prix Unitaire Achat";
            dgv.Columns["StockI"].HeaderText = "Stock Initial";
            dgv.Columns["PrixUA2"].HeaderText = "Prix Unitaire Achat 2";

            con.Close();
        }

        private void ListeAr_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            if (UserRole == "UtilisateurC")
            {
                button3.Enabled = false;
                kryptonButton3.Enabled = false;
                kryptonButton4.Enabled = false;
                buttonGFournisseur.Enabled = false;
            }
            else if (UserRole == "UtilisateurB") {
                button3.Enabled = false;
            }
            
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [Article]", con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sda.Fill(dtbl);
            dgv.DataSource = dtbl;
            dgv.Columns["PrixUM"].HeaderText = "Prix UM Pondéré";
            dgv.Columns["SFamille"].HeaderText = "Sous Famille";
            dgv.Columns["PO"].HeaderText = "Pièce obsolète ?";
            dgv.Columns["PrixUA"].HeaderText = "Prix Unitaire Achat";
            dgv.Columns["StockI"].HeaderText = "Stock Initial";
            dgv.Columns["PrixUA2"].HeaderText = "Prix Unitaire Achat 2";

            con.Close();
        }

        private void copyAlltoClipboard()
        {
            dgv.SelectAll();
            DataObject dataObj = dgv.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.dgv.SelectedRows.Count > 0)
            {
                DialogResult res = MessageBox.Show("Vous voulez vraiment supprimer cette ligne ?", null, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (res == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    int id = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);
                    
                    string Desi = dgv.SelectedRows[0].Cells[4].Value.ToString();
                    cmd.CommandText = "Delete from [Article] where id='" + id + "'";
                    dgv.Rows.RemoveAt(this.dgv.SelectedRows[0].Index);
                    cmd.ExecuteNonQuery();

                    SqlCommand cmd2 = new SqlCommand("Delete from [EtatStock] where Designation = '" + Desi + "' ", con);
                    cmd2.ExecuteNonQuery();

                    SqlCommand cmd3 = new SqlCommand("update [Entree] set Supprime = 'Oui' where Designation = '"+Desi+"'", con);
                    cmd3.ExecuteNonQuery();

                    SqlCommand cmd4 = new SqlCommand("update [Sortie] set Supprime = 'Oui' where Designation = '" + Desi + "'", con);
                    cmd4.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Article supprimé avec succès !");
                }



            }
            else {
                MessageBox.Show("Veuillez selectionner une ligne !", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArticleForm aform = new ArticleForm();
            aform.Modifier = 1;
            aform.labelTitre.Text = "Modifier un article";
            aform.buttonAjouter.Visible = false;
            aform.txtDesi.ReadOnly = true;
            if (this.dgv.SelectedRows.Count > 0)
            {

                aform.SelectedID = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);
                aform.txtCara.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();

                //Transfert de data du dgv au combobox Famille

                con.Open();
                string Famille = dgv.SelectedRows[0].Cells[2].Value.ToString();
                string selectQuery1 = "SELECT * FROM [Famille] WHERE NomFamille = '" + Famille + "' ";
                SqlCommand cmd1 = new SqlCommand(selectQuery1, con);
                SqlDataReader rd1 = cmd1.ExecuteReader();
                if (rd1.Read())
                {
                    string selectedValue1 = rd1.GetValue(rd1.GetOrdinal("Id")).ToString();
                    SelectedFamilleValue = Convert.ToInt32(selectedValue1);

                }
                else
                {
                    MessageBox.Show("Erreur",null,MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                con.Close();
                aform.SelectedFamilleValue = SelectedFamilleValue;

                //Transfert du data du dgv au combobox Sous Famille

                con.Open();
                string SFamille = dgv.SelectedRows[0].Cells[3].Value.ToString();
                string selectQuery2 = "SELECT * FROM [SousFamille] WHERE NomSFamille = '" + SFamille + "' ";
                SqlCommand cmd2 = new SqlCommand(selectQuery2, con);
                SqlDataReader rd2 = cmd2.ExecuteReader();
                if (rd2.Read())
                {
                    string selectedValue2 = rd2.GetValue(rd2.GetOrdinal("Id")).ToString();
                    SelectedSFamilleValue = Convert.ToInt32(selectedValue2);

                }
                else
                {
                    MessageBox.Show("Erreur", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
                aform.SelectedSFamilleValue = SelectedSFamilleValue;


                aform.txtDesi.Text = dgv.SelectedRows[0].Cells[4].Value.ToString();
                aform.oldDesi = dgv.SelectedRows[0].Cells[4].Value.ToString();
                string PO = dgv.SelectedRows[0].Cells[5].Value.ToString();
                if (PO == "Oui")
                {
                    aform.checkPO.Checked = true;
                }
                else
                {
                    aform.checkPO.Checked = false;
                }
                aform.txtStockMin.Text = dgv.SelectedRows[0].Cells[6].Value.ToString();
                aform.txtZone.Text = dgv.SelectedRows[0].Cells[7].Value.ToString();
                aform.txtArmoire.Text = dgv.SelectedRows[0].Cells[8].Value.ToString();
                aform.txtColonne.Text = dgv.SelectedRows[0].Cells[9].Value.ToString();
                aform.txtEtage.Text = dgv.SelectedRows[0].Cells[10].Value.ToString();

                //Transfert du data du dgv au txtbox classement

                con.Open();
                string Class = dgv.SelectedRows[0].Cells[11].Value.ToString();

                string selectQuery = "SELECT * FROM [Classement] WHERE NomClassement= '" + Class + "' ";
                SqlCommand cmd = new SqlCommand(selectQuery, con);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    string selectedValue = rd.GetValue(rd.GetOrdinal("Id")).ToString();
                    SelectedClassValue = Convert.ToInt32(selectedValue);

                }
                else
                {
                    MessageBox.Show("Erreur", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
                aform.SelectedClassValue = SelectedClassValue;
                aform.txtUnite.Text = dgv.SelectedRows[0].Cells[12].Value.ToString();

                string PrixUA = dgv.SelectedRows[0].Cells[13].Value.ToString();
                PrixUA = PrixUA.Replace(',', '.');
                aform.txtPrixUA.Text = PrixUA;

                string PrixUM = dgv.SelectedRows[0].Cells[14].Value.ToString();
                PrixUM = PrixUM.Replace(',', '.');
                aform.txtPrixUM.Text = PrixUM;
                
                aform.txtStockI.Text = dgv.SelectedRows[0].Cells[15].Value.ToString();

                DateTime date = DateTime.Parse(dgv.SelectedRows[0].Cells[16].Value.ToString());
                aform.dateTimePicker1.Value = date;

                //Transfert de data du dgv au combobox Fournisseur
                con.Open();
                string Fournisseur = dgv.SelectedRows[0].Cells[17].Value.ToString();

                string selectQuery3 = "SELECT * FROM [Fournisseur] WHERE NomFournisseur= '" + Fournisseur + "' ";
                SqlCommand cmd3 = new SqlCommand(selectQuery3, con);
                SqlDataReader rd3 = cmd3.ExecuteReader();
                if (rd3.Read())
                {
                    string selectedValue3 = rd3.GetValue(rd3.GetOrdinal("Id")).ToString();
                    SelectedFournisseurValue = Convert.ToInt32(selectedValue3);

                }
                else
                {
                    MessageBox.Show("Erreur", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
                aform.SelectedFournisseurValue = SelectedFournisseurValue;
                //aform.txtFournisseur.Text = dgv.SelectedRows[0].Cells[17].Value.ToString();
                aform.txtFabricant.Text = dgv.SelectedRows[0].Cells[18].Value.ToString();
                aform.txtFournisseur2.Text = dgv.SelectedRows[0].Cells[19].Value.ToString();
                aform.txtFabricant2.Text = dgv.SelectedRows[0].Cells[20].Value.ToString();

                string PrixUA2 = dgv.SelectedRows[0].Cells[21].Value.ToString();
                PrixUA2 = PrixUA2.Replace(',', '.');
                aform.txtPrixUA2.Text = PrixUA2;

                aform.txtMA.Text = dgv.SelectedRows[0].Cells[22].Value.ToString();
                aform.txtAcheteur.Text = dgv.SelectedRows[0].Cells[23].Value.ToString();
                aform.txtMP2.SelectedItem = dgv.SelectedRows[0].Cells[24].Value.ToString();
                aform.ShowDialog();
            }
            else {
                MessageBox.Show("Veuillez selectionner une ligne !", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }

        public void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgv.Rows[e.RowIndex].Cells[0].Value != null)
            //{
                
            //    SelectedID = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[0].Value);
            //}
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            GFamille Fform = new GFamille();
            Fform.ShowDialog();
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            GSFamille SFform = new GSFamille();
            SFform.ShowDialog();
        }

        private void buttonGFournisseur_Click(object sender, EventArgs e)
        {
            GFournisseur GFform = new GFournisseur();
            GFform.ShowDialog();
        }
       
    }
}
