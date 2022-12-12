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
    public partial class GUsers : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\GestionStock\GestionStock\Database1.mdf;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        string OldUser;
        string OldPwd;
        string OldRole;
        public GUsers()
        {
            InitializeComponent();
        }

        private void GUsers_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSet1.UserRole'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.userRoleTableAdapter.Fill(this.dataSet1.UserRole);
            // TODO: cette ligne de code charge les données dans la table 'dataSet1.User'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.userTableAdapter.Fill(this.dataSet1.User);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [User]", con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sda.Fill(dtbl);
            dgv.DataSource = dtbl;
            con.Close();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            string User = txtUser.Text.ToString();
            string Mdp = txtMdp.Text.ToString();
            string Role = txtRole.Text.ToString();
            if (User == "")
            {
                MessageBox.Show("Veuillez remplir les champs !", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("select * from [User] where UserID = '" + User + "' ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Cet utilisateur existe déjà !", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUser.Text = "";
                    txtMdp.Text = "";
                    txtUser.Focus();
                }
                else
                {


                    SqlCommand cmd = new SqlCommand("insert into [User] values ('"+User+"' , '"+Mdp+"' , '"+Role+"')", con);
                    cmd.ExecuteNonQuery();
                    
                    MessageBox.Show("Utilisateur ajouté avec succès !");
                    txtUser.Text = "";
                    txtMdp.Text = "";
                    txtUser.Focus();
                }
                con.Close();
            }
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void buttonActualiser_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [User]", con);
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
                cmd.CommandText = "Delete from [User] where id='" + id + "'";
                dgv.Rows.RemoveAt(this.dgv.SelectedRows[0].Index);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Utilisateur supprimé avec succès !");
                con.Close();
            }
            else
            {
                MessageBox.Show("Veuillez selectionner une ligne !", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (this.dgv.SelectedRows.Count > 0)
            {
                string User = txtUser.Text.ToString();
                string Pwd = txtMdp.Text.ToString();
                string Role = txtRole.Text.ToString();

                int id = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "update [User] set UserID =@p1 , Password =@p2 , Role =@p3 where Id = '"+id+"'";
                cmd.Parameters.AddWithValue("@p1", User);
                cmd.Parameters.AddWithValue("@p2", Pwd);
                cmd.Parameters.AddWithValue("@p3", Role);
                cmd.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("select * from [User] where UserID =@p1", con);
                cmd2.Parameters.AddWithValue("@p1", User);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                if (dt2.Rows.Count == 1)
                {
                    MessageBox.Show("Utilisateur mis à jour avec succès !");
                    txtUser.Text = "";
                    txtMdp.Text = "";
                    txtUser.Focus();
                }
                else if (dt2.Rows.Count > 1) {
                    SqlCommand cmd3 = new SqlCommand("update [User] set UserID =@p1 , Password =@p2 , Role =@p3 where Id = '" + id + "'", con);
                    cmd3.Parameters.AddWithValue("@p1",OldUser);
                    cmd3.Parameters.AddWithValue("@p2", OldPwd);
                    cmd3.Parameters.AddWithValue("@p3", OldRole);
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("Cet utilisateur existe déjà !", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                

                con.Close();
            }
            else
            {
                MessageBox.Show("Veuillez selectionner une ligne !", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgv.Rows[index];
            string User = selectedRow.Cells[1].Value.ToString();
            string Mdp = selectedRow.Cells[2].Value.ToString();

            con.Open();
            string Role = selectedRow.Cells[3].Value.ToString();
            int SelectedRoleValue;
            string selectQuery3 = "SELECT * FROM [UserRole] WHERE Role= '" + Role + "' ";
            SqlCommand cmd3 = new SqlCommand(selectQuery3, con);
            SqlDataReader rd3 = cmd3.ExecuteReader();
            if (rd3.Read())
            {
                string selectedValue3 = rd3.GetValue(rd3.GetOrdinal("Id")).ToString();
                SelectedRoleValue = Convert.ToInt32(selectedValue3);
                txtRole.SelectedValue = SelectedRoleValue;

            }
            else
            {
                MessageBox.Show("Erreur", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

            OldUser = User;
            OldPwd = Mdp;
            OldRole = Role;
            txtMdp.Text = Mdp;
            txtUser.Text = User;
            
        }
    }
}
