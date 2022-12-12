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
    public partial class GFamille : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\GestionStock\GestionStock\Database1.mdf;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");

        public GFamille()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string NFamille = txtFamille.Text.ToString();
            if (txtFamille.Text == "")
            {
                MessageBox.Show("Veuillez remplir le champs !", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [Famille] where NomFamille = '" + txtFamille.Text + "' ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Ce nom de famille existe déjà !", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    SqlCommand cmd2 = con.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "insert into [Famille] values ('"+NFamille+"') ";
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Famille ajouté avec succès , redemarrez l'application pour enregistrer les changements !");
                }
                con.Close();
                txtFamille.Text = "";
                txtFamille.Focus();
            }
        }
    }
}
