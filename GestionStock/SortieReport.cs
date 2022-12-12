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

namespace GestionStock
{
    public partial class SortieReport : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\GestionStock\GestionStock\Database1.mdf;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        public SortieReport()
        {
            InitializeComponent();
        }

        private void SortieReport_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSet1.Motif'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.motifTableAdapter.Fill(this.dataSet1.Motif);
            // TODO: cette ligne de code charge les données dans la table 'dataSet1.SousFamille'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.sousFamilleTableAdapter.Fill(this.dataSet1.SousFamille);
            // TODO: cette ligne de code charge les données dans la table 'dataSet1.Famille'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.familleTableAdapter.Fill(this.dataSet1.Famille);
            // TODO: cette ligne de code charge les données dans la table 'dataSet1.Demandeur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.demandeurTableAdapter.Fill(this.dataSet1.Demandeur);

            con.Open();

            SqlCommand cmd3 = new SqlCommand("select Designation from [Article]", con);
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            DataTable dt3 = new DataTable();
            DataTable dt4 = new DataTable();

            da3.Fill(dt3);
            foreach (DataRow row in dt3.Rows)
            {
                string Desi = row["Designation"].ToString();
                SqlCommand cmd4 = new SqlCommand("select Designation , QuantiteEntrante , MontantFactureHT from [Entree]", con);
                SqlDataAdapter da4 = new SqlDataAdapter(cmd4);
                da4.Fill(dt4);

                double MontantTotal;
                if (dt4.Compute("SUM(MontantFactureHT)", "Designation = '" + Desi + "' ") is System.DBNull)
                {
                    MontantTotal = 0;
                }
                else
                {
                    MontantTotal = Convert.ToDouble(dt4.Compute("SUM(MontantFactureHT)", "Designation = '" + Desi + "' "));
                }

                double QteEntranteTotal;
                if (dt4.Compute("SUM(QuantiteEntrante)", "Designation = '" + Desi + "' ") is System.DBNull)
                {
                    QteEntranteTotal = 0;
                }
                else
                {
                    QteEntranteTotal = Convert.ToDouble(dt4.Compute("SUM(QuantiteEntrante)", "Designation = '" + Desi + "' "));
                }
                if (QteEntranteTotal != 0)
                {

                    double PrixUnitaireMoyen = (double)MontantTotal / (double)QteEntranteTotal;
                    PrixUnitaireMoyen = Convert.ToDouble(String.Format("{0:0.00}", PrixUnitaireMoyen));
                    SqlCommand cmd5 = new SqlCommand("update [Sortie] set PrixUnitaireMoyenHT =@p1 where Designation = '" + Desi + "' ", con);
                    cmd5.Parameters.AddWithValue("@p1", PrixUnitaireMoyen);
                    cmd5.ExecuteNonQuery();
                    SqlCommand cmd6 = new SqlCommand("update [Article] set PrixUM =@p1 where Designation = '" + Desi + "'", con);
                    cmd6.Parameters.AddWithValue("@p1", PrixUnitaireMoyen);
                    cmd6.ExecuteNonQuery();
                    SqlCommand cmd7 = new SqlCommand("update [EtatStock] set PrixUnitaireMoyen =@p1 where Designation = '" + Desi + "'", con);
                    cmd7.Parameters.AddWithValue("@p1", PrixUnitaireMoyen);
                    cmd7.ExecuteNonQuery();



                }

            }

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [Sortie]", con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sda.Fill(dtbl);
            dgv.DataSource = dtbl;
            
            
            
            SqlCommand cmd = new SqlCommand("SELECT Designation FROM [Sortie] ", con);
            SqlDataReader reader = cmd.ExecuteReader();
            AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                 MyCollection.Add(reader.GetString(0));
            }


            txtDesi.AutoCompleteCustomSource = MyCollection;
            con.Close();

            


        }

        

        private void ButtonActualiser_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [Sortie]", con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sda.Fill(dtbl);
            dgv.DataSource = dtbl;
            con.Close();
        }

        private void demandeurBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.demandeurBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void btnDesi_Click(object sender, EventArgs e)
        {
            string result = txtDesi.Text.ToString();
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [Sortie] Where Designation = '" + result + "'", con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count > 0)
            {
                dgv.DataSource = dtbl;
                
            }
            else {
                MessageBox.Show("Aucun résultat !", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        private void btnDemandeur_Click(object sender, EventArgs e)
        {
            string result = txtDemandeur.Text.ToString();
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [Sortie] Where Demandeur = '" + result + "'", con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count > 0)
            {
                dgv.DataSource = dtbl;

            }
            else
            {
                MessageBox.Show("Aucun résultat !", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        private void btnFamille_Click(object sender, EventArgs e)
        {
            string result = txtFamille.Text.ToString();
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [Sortie] Where Famille = '" + result + "'", con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count > 0)
            {
                dgv.DataSource = dtbl;

            }
            else
            {
                MessageBox.Show("Aucun résultat !", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        private void btnSousFamille_Click(object sender, EventArgs e)
        {
            string result = txtSFamille.Text.ToString();
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [Sortie] Where SousFamille = '" + result + "'", con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count > 0)
            {
                dgv.DataSource = dtbl;

            }
            else
            {
                MessageBox.Show("Aucun résultat !", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        private void btnMotif_Click(object sender, EventArgs e)
        {
            string result = txtMotif.Text.ToString();
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [Sortie] Where Motif = '" + result + "'", con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count > 0)
            {
                dgv.DataSource = dtbl;

            }
            else
            {
                MessageBox.Show("Aucun résultat !", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            string format = "yyyy-MM-dd";//change accordingly if format is something different
            
            
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [Sortie] Where DateSortie BETWEEN '"+DateSortie1.Value.ToString(format)+"' AND '"+DateSortie2.Value.ToString(format)+"' ", con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count > 0)
            {
                dgv.DataSource = dtbl;

            }
            else
            {
                MessageBox.Show("Aucun résultat !", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();

        }
    }
}
