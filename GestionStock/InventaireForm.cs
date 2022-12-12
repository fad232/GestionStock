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

namespace GestionStock
{
    public partial class InventaireForm : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\GestionStock\GestionStock\Database1.mdf;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        public int SelectedID;
        public InventaireForm()
        {
            InitializeComponent();
        }

        private void InventaireForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Designation FROM [Article] ", con);
            SqlDataReader reader = cmd.ExecuteReader();
            AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                MyCollection.Add(reader.GetString(0));
            }


            txtDesi1.AutoCompleteCustomSource = MyCollection;
            con.Close();
        }

        private void buttonRecherche_Click(object sender, EventArgs e)
        {
            if (txtDesi1.Text == "")
            {
                MessageBox.Show("Veuillez remplir le champs Designation", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                con.Open();
                string Desi = txtDesi1.Text.ToString();

                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "SELECT * FROM [Article] WHERE Designation = '" + Desi + "' ";
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Cette désignation n'existe pas dans la liste des articles !", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string selectQuery = "SELECT * FROM [Article] WHERE Designation = '" + Desi + "' ";
                    SqlCommand cmd = new SqlCommand(selectQuery, con);
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {
                        textCara.Text = rd.GetValue(rd.GetOrdinal("Caracteristique")).ToString();
                        textFamille.Text = rd.GetValue(rd.GetOrdinal("Famille")).ToString();
                        textSousFamille.Text = rd.GetValue(rd.GetOrdinal("SFamille")).ToString();
                        


                        

                    }
                    else
                    {
                        MessageBox.Show("Erreur de recherche!", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                con.Close();
            }
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            string RI = textRI.Text.ToString();
            string Desi = txtDesi1.Text.ToString();
            string Cara = textCara.Text.ToString();
            int StockI = 0;
            if (textStockI.Text == "")
            {
                StockI = 0;
            }
            else {
                StockI = Convert.ToInt32(textStockI.Text);
            }
            
            string Famille = textFamille.Text.ToString();
            string SousFamille = textSousFamille.Text.ToString();
            string format = "yyyy-MM-dd";
            if (RI == "")
            {
                MessageBox.Show("Veuillez remplir les champs obligatoires !", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {

                con.Open();
                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select * from [Inventaire] where Designation = '" + Desi + "' ";
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Cet article existe déjà !", null, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into [Inventaire] values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)";
                    cmd.Parameters.AddWithValue("@p1", Desi);
                    cmd.Parameters.AddWithValue("@p2", RI);
                    cmd.Parameters.AddWithValue("@p3", Cara);
                    cmd.Parameters.AddWithValue("@p4", StockI);
                    cmd.Parameters.AddWithValue("@p5", Famille);
                    cmd.Parameters.AddWithValue("@p6", SousFamille);
                    cmd.Parameters.AddWithValue("@p7", DateInventaire.Value.ToString(format));
                    cmd.ExecuteNonQuery();
                    
                    MessageBox.Show("Article ajouté avec succès !");
                    txtDesi1.Text = "";
                    textCara.Text = "";
                    textRI.Text = "";
                    textFamille.Text = "";
                    textSousFamille.Text = "";
                    textStockI.Text = "";
                    txtDesi1.Focus();
                }
                con.Close();


            }

        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            string RI = textRI.Text.ToString();
            string Desi = txtDesi1.Text.ToString();
            string Cara = textCara.Text.ToString();
            int StockI = 0;
            if (textStockI.Text == "")
            {
                StockI = 0;
            }
            else
            {
                StockI = Convert.ToInt32(textStockI.Text);
            }

            string Famille = textFamille.Text.ToString();
            string SousFamille = textSousFamille.Text.ToString();
            string format = "yyyy-MM-dd";
            if (RI == "")
            {
                MessageBox.Show("Veuillez remplir les champs obligatoires !", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE [Inventaire] SET ResponsableInventaire =@p1 , Caracteristique =@p2 , StockInitial =@p3 , Famille =@p4 , SousFamille =@p5 , DateInventaire =@p6 WHERE Id = '" + SelectedID + "' ";
                cmd.Parameters.AddWithValue("@p1", RI);
                cmd.Parameters.AddWithValue("@p2", Cara);
                cmd.Parameters.AddWithValue("@p3", StockI);
                cmd.Parameters.AddWithValue("@p4", Famille);
                cmd.Parameters.AddWithValue("@p5", SousFamille);
                cmd.Parameters.AddWithValue("@p6", DateInventaire.Value.ToString(format));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Article mis à jour avec succès !");
                txtDesi1.Text = "";
                textCara.Text = "";
                textRI.Text = "";
                textFamille.Text = "";
                textSousFamille.Text = "";
                textStockI.Text = "";
                txtDesi1.Focus();
            }
        }
    }
}
