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
    public partial class GDemandeur : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\GestionStock\GestionStock\Database1.mdf;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");

        public GDemandeur()
        {
            InitializeComponent();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            string Demandeur = txtDemandeur.Text.ToString();
            if (Demandeur == "")
            {
                MessageBox.Show("Veuillez remplir le champs !", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("select * from [Demandeur] where NomDemandeur = '" + Demandeur + "' ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Ce demandeur existe déjà !", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDemandeur.Text = "";
                    txtDemandeur.Focus();
                }
                else
                {


                    SqlCommand cmd = new SqlCommand("insert into [Demandeur] values ('" + Demandeur + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Demandeur ajouté avec succès ! Redémarrez l'application pour voir les changements.");
                    txtDemandeur.Text = "";
                    txtDemandeur.Focus();
                }
                con.Close();
            }
        }

        private void GDemandeur_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [Demandeur]", con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sda.Fill(dtbl);
            dgv.DataSource = dtbl;
            con.Close();
        }

        private void buttonActualiser_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [Demandeur]", con);
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
                cmd.CommandText = "Delete from [Demandeur] where id='" + id + "'";
                dgv.Rows.RemoveAt(this.dgv.SelectedRows[0].Index);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Demandeur supprimé avec succès !");
                con.Close();
            }
            else
            {
                MessageBox.Show("Veuillez selectionner une ligne !", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
