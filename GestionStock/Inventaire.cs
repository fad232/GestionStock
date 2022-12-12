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
    public partial class Inventaire : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\GestionStock\GestionStock\Database1.mdf;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        public Inventaire()
        {
            InitializeComponent();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            InventaireForm IF = new InventaireForm();
            IF.ShowDialog();
        }

        private void Inventaire_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [Inventaire]", con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sda.Fill(dtbl);
            dgv.DataSource = dtbl;
            
            con.Close();
        }

        private void ButtonActualiser_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [Inventaire]", con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sda.Fill(dtbl);
            dgv.DataSource = dtbl;
            
            con.Close();
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            InventaireForm invf = new InventaireForm();
            invf.buttonAjouter.Visible = false;
            invf.buttonModifier.Visible = true;
            invf.labelTitre.Text = "Modifier un article";
            if (this.dgv.SelectedRows.Count > 0) {
                invf.SelectedID = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);
                invf.txtDesi1.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
                invf.textRI.Text = dgv.SelectedRows[0].Cells[2].Value.ToString();
                invf.textCara.Text = dgv.SelectedRows[0].Cells[3].Value.ToString();
                invf.textStockI.Text = dgv.SelectedRows[0].Cells[4].Value.ToString();
                invf.textFamille.Text = dgv.SelectedRows[0].Cells[5].Value.ToString(); 
                invf.textSousFamille.Text = dgv.SelectedRows[0].Cells[6].Value.ToString();

                DateTime inv = DateTime.Parse(dgv.SelectedRows[0].Cells[7].Value.ToString());
                invf.DateInventaire.Value = inv;
                invf.ShowDialog();
            }
            else
            {
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
                    cmd.CommandText = "Delete from [Inventaire] where id='" + id + "'";

                    dgv.Rows.RemoveAt(this.dgv.SelectedRows[0].Index);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Article supprimé avec succès !");
                }



            }
            else
            {
                MessageBox.Show("Veuillez selectionner une ligne !", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
