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
using System.Configuration;

namespace GestionStock
{
    public partial class Form1 : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        //String con = ConfigurationManager.ConnectionStrings["GestionStock.Properties.Settings.Database1ConnectionString"].ToString();
        public static DataRow dr;
        



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            String id = txtUsername.Text;
            String pwd = txtPassword.Text;
            if (id == "" || pwd == "")
            {
                MessageBox.Show("Veuillez remplir les champs !", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [User] where UserID = '" + id + "' and Password = '" + pwd + "' ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    string role = dt.Rows[0][3].ToString();
                    //dr = dt.Rows[0];
                    if (role == "Admin")
                    {

                        new Acceuil().Show();
                        this.Hide();
                    }
                    else if (role == "Consultant")
                    {
                        Acceuil ac = new Acceuil();
                        ac.button1.Enabled = false;
                        ac.Show();
                        this.Hide();
                    }
                    else if (role == "UtilisateurC")
                    {
                        Acceuil ac = new Acceuil();
                        ac.Show();
                        this.Hide();
                        ac.UserRole = "UtilisateurC";

                    }
                    else if (role == "UtilisateurB") {

                        Acceuil ac = new Acceuil();
                        ac.Show();
                        this.Hide();
                        ac.UserRole = "UtilisateurB";
                    }
                    else if (role == "UtilisateurA")
                    {

                        Acceuil ac = new Acceuil();
                        ac.Show();
                        this.Hide();
                        ac.UserRole = "UtilisateurA";
                    }
                }
                else {
                    MessageBox.Show("ID ou mot de passe erroné !", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Focus();
                }
                con.Close();


            }
        }
    }
}
