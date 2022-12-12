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
using System.Globalization;
using System.Data.SqlTypes;

namespace GestionStock
{
    public partial class SortieForm : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\GestionStock\GestionStock\Database1.mdf;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        public int Modifier;
        public int SelectedID;
        public int SelectedMotifValue;
        public int SelectedDemandeurValue;
        string Famille;
        string SousFamille;
        public SortieForm()
        {
            InitializeComponent();
        }

        private void SortieForm_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSet1.Demandeur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.demandeurTableAdapter.Fill(this.dataSet1.Demandeur);
            // TODO: cette ligne de code charge les données dans la table 'dataSet1.Motif'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.motifTableAdapter.Fill(this.dataSet1.Motif);
            WindowState = FormWindowState.Maximized;

            if (Modifier == 1) {
                txtMotif.SelectedValue = SelectedMotifValue;
                txtDemandeur.SelectedValue = SelectedDemandeurValue;
            }

            
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
                MessageBox.Show("Veuillez remplir le champ Designation", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        txtUnite.Text = rd.GetValue(rd.GetOrdinal("Unite")).ToString();
                        string PUMHT = rd.GetValue(rd.GetOrdinal("PrixUM")).ToString();
                        PUMHT = PUMHT.Replace(',', '.');
                        txtPUMHT.Text = PUMHT;

                        Famille = rd.GetValue(rd.GetOrdinal("Famille")).ToString();
                        SousFamille = rd.GetValue(rd.GetOrdinal("SFamille")).ToString();

                    }
                    else
                    {
                        MessageBox.Show("Erreur de recherche!", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                con.Close();
            }
        }

        private void motifBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.motifBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            string Designation = txtDesi1.Text.ToString();
            string Unite = txtUnite.Text.ToString();
            
            
            double QSortante = Convert.ToDouble(txtQSortante.Text, CultureInfo.InvariantCulture);
            
            string format = "yyyy-MM-dd";
            //string dateSortie1 = DateSortie.Text.ToString();

            String strDateFormat = "yyyy-MM-dd";//change accordingly if format is something different
            //DateTime dateSortie = DateTime.ParseExact(DateSortie.Text, strDateFormat, CultureInfo.InvariantCulture);

            string dateSortie = DateTime.ParseExact(DateSortie.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
            
            string Motif = txtMotif.Text.ToString();
            string AffOb = txtAffOb.Text.ToString();
            string Demandeur = txtDemandeur.Text.ToString();
            double VSortie = Convert.ToDouble(txtValeurS.Text, CultureInfo.InvariantCulture);
            double PUMHT = Convert.ToDouble(txtPUMHT.Text, CultureInfo.InvariantCulture);
            if (Designation == "" || Unite == "" || Motif == "" || Demandeur == "")
            {
                MessageBox.Show("Veuillez remplir les champs obligatoires !", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [Sortie] values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,'Non')";
                cmd.Parameters.AddWithValue("@p1", Designation);
                cmd.Parameters.AddWithValue("@p2", Unite);
                cmd.Parameters.AddWithValue("@p3", QSortante);
                cmd.Parameters.AddWithValue("@p4", DateSortie.Value.ToString(format));
                cmd.Parameters.AddWithValue("@p5", Motif);
                cmd.Parameters.AddWithValue("@p6", AffOb);
                cmd.Parameters.AddWithValue("@p7", Demandeur);
                cmd.Parameters.AddWithValue("@p8", PUMHT);
                cmd.Parameters.AddWithValue("@p9", VSortie);
                cmd.Parameters.AddWithValue("@p10", Famille);
                cmd.Parameters.AddWithValue("@p11", SousFamille);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sortie ajouté avec succès !");
                con.Close();
                txtDesi1.Text = "";
                txtUnite.Text = "";
                txtQSortante.Text = "0";
                txtMotif.SelectedValue = 0;
                txtAffOb.Text = "";
                txtDemandeur.Text = "";
                txtValeurS.Text = "0";
                txtPUMHT.Text = "0";
                txtDesi1.Focus();
            }

        }
        private void ValidateFloat(object sender, KeyPressEventArgs e)
        {
            int b;

            if (e.KeyChar == (char)Keys.Back ||
                e.KeyChar == (char)Keys.Delete ||
                e.KeyChar == (char)Keys.Left ||
                e.KeyChar == (char)Keys.Right ||
                int.TryParse(e.KeyChar.ToString(), out b))
            {
                TextBox obj = sender as TextBox;
                if (e.KeyChar == '.' && obj.Text.IndexOf('.') > 0)
                    e.Handled = true;
                else
                    e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void txtQSortante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtQSortante_TextChanged(object sender, EventArgs e)
        {
            if (txtQSortante.Text == "")
            {
                txtQSortante.Text = "0";
            }
            double PrixUM = Convert.ToDouble(txtPUMHT.Text, CultureInfo.InvariantCulture);
            double QSortante = Convert.ToDouble(txtQSortante.Text, CultureInfo.InvariantCulture);
            double ValeurS = PrixUM * QSortante;
            txtValeurS.Text = ValeurS.ToString();
        }

        private void txtValeurS_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ValidateFloat(sender, e);
        }

        private void txtValeurS_TextChanged(object sender, EventArgs e)
        {
            if (txtValeurS.Text == "")
            {
                txtValeurS.Text = "0";
            }
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            string Designation = txtDesi1.Text.ToString();
            string Unite = txtUnite.Text.ToString();
            double QSortante = Convert.ToDouble(txtQSortante.Text, CultureInfo.InvariantCulture);
            DateTime dateSortie = DateSortie.Value;
            string Motif = txtMotif.Text.ToString();
            string AffOb = txtAffOb.Text.ToString();
            string Demandeur = txtDemandeur.Text.ToString();
            double VSortie = Convert.ToDouble(txtValeurS.Text, CultureInfo.InvariantCulture);
            string format = "yyyy-MM-dd";
            if (Designation == "" || Unite == "" || Motif == "" || Demandeur == "")
            {
                MessageBox.Show("Veuillez remplir les champs obligatoires !", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE [Sortie] SET Unite = '" + Unite + "' , QuantiteSortante =@p1 , DateSortie = '" + DateSortie.Value.ToString(format) + "' , Motif = '" + Motif + "' , AffectationObservation = '" + AffOb + "' , Demandeur = '" + Demandeur + "' , ValeurSortie =@p2 WHERE Id = '" + SelectedID + "'  ";
                cmd.Parameters.AddWithValue("@p1", QSortante);
                cmd.Parameters.AddWithValue("@p2", VSortie);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Sortie mise à jour avec succès !");
                txtDesi1.Text = "";
                txtUnite.Text = "";
                txtQSortante.Text = "0";
                txtMotif.SelectedValue = 0;
                txtAffOb.Text = "";
                txtDemandeur.SelectedValue = 0;
                txtValeurS.Text = "0";
                txtPUMHT.Text = "0";
                txtDesi1.Focus();
            }
        }

        private void txtPUMHT_TextChanged(object sender, EventArgs e)
        {
            if (txtQSortante.Text == "")
            {
                txtQSortante.Text = "0";
            }
            double PrixUM = Convert.ToDouble(txtPUMHT.Text, CultureInfo.InvariantCulture);
            double QSortante = Convert.ToDouble(txtQSortante.Text, CultureInfo.InvariantCulture);
            double ValeurS = PrixUM * QSortante;
            txtValeurS.Text = ValeurS.ToString();
        }
    }
}
