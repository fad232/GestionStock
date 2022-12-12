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
    public partial class GSFamille : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\GestionStock\GestionStock\Database1.mdf;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        public GSFamille()
        {
            InitializeComponent();
        }

        private void familleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.familleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void GSFamille_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSet1.Famille'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.familleTableAdapter.Fill(this.dataSet1.Famille);

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string SFamille = txtSFamille.Text.ToString();
            string Famille = ComboFamille.Text.ToString();
            if (txtSFamille.Text == "")
            {
                MessageBox.Show("Veuillez remplir le champs !", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [SousFamille] where FamilleMere = '" + Famille + "' AND NomSFamille = '" + SFamille + "' ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Ce nom de sous famille existe déjà !", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand cmd2 = con.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "insert into [SousFamille] values ('" + Famille + "' , '" + SFamille + "') ";
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Sous famille ajouté avec succès , redemarrez l'application pour enregistrer les changements !");
                }
                con.Close();
                txtSFamille.Text = "";
                txtSFamille.Focus();
            }
        }
    }
}
