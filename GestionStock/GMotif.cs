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
    public partial class GMotif : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\GestionStock\GestionStock\Database1.mdf;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");

        public GMotif()
        {
            InitializeComponent();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            string Motif = txtMotif.Text.ToString();
            if (Motif == "")
            {
                MessageBox.Show("Veuillez remplir le champs !", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("select * from [Motif] where Motif = '" + Motif + "' ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Ce motif existe déjà !", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMotif.Text = "";
                    txtMotif.Focus();
                }
                else
                {


                    SqlCommand cmd = new SqlCommand("insert into [Motif] values ('" + Motif + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Motif ajouté avec succès ! Redémarrez l'application pour voir les changements.");
                    txtMotif.Text = "";
                    txtMotif.Focus();
                }
                con.Close();
            }
        }

        private void GMotif_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [Motif]", con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sda.Fill(dtbl);
            dgv.DataSource = dtbl;
            con.Close();
        }

        private void buttonActualiser_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [Motif]", con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sda.Fill(dtbl);
            dgv.DataSource = dtbl;
            con.Close();
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (this.dgv.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Delete from [Motif] where id='" + id + "'";
                dgv.Rows.RemoveAt(this.dgv.SelectedRows[0].Index);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Motif supprimé avec succès !");
                con.Close();
            }
            else
            {
                MessageBox.Show("Veuillez selectionner une ligne !", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
