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
    public partial class StockReport : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\GestionStock\GestionStock\Database1.mdf;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");

        public StockReport()
        {
            InitializeComponent();
            
        }

        private void ButtonActualiser_Click(object sender, EventArgs e)
        {
            con.Open();


            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT Designation , Unite , PrixUM , StockI , StockMin , Famille , SFamille FROM [Article] ";
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();

            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                string desi = row["Designation"].ToString();
                string Unite = row["Unite"].ToString();
                double PrixUM = Convert.ToDouble(row["PrixUM"].ToString());
                int StockI = Convert.ToInt32(row["StockI"].ToString());
                int StockMin = Convert.ToInt32(row["StockMin"].ToString());
                string Famille = row["Famille"].ToString();
                string SousFamille = row["SFamille"].ToString();

                SqlCommand cmd2 = new SqlCommand("SELECT Designation , QuantiteSortante FROM [Sortie] WHERE Designation = '" + desi + "' ", con);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                da2.Fill(dt2);

                SqlCommand cmd5 = new SqlCommand("SELECT Designation , QuantiteEntrante FROM [Entree] WHERE Designation = '" + desi + "' ", con);
                SqlDataAdapter da3 = new SqlDataAdapter(cmd5);
                da3.Fill(dt3);

                SqlCommand cmd3 = new SqlCommand(" IF NOT EXISTS(SELECT Designation FROM [EtatStock] WHERE Designation = '" + desi + "') insert into [EtatStock] (Designation , Unite , PrixUnitaireMoyen , StockInitial , QuantiteTotaleSortante , QuantiteTotaleEntrante , StockMin , Famille , SousFamille) values ('" + desi + "' , '" + Unite + "' , '" + PrixUM + "' , '" + StockI + "' , '0' , '0' , '" + StockMin + "' , '"+Famille+"' , '"+SousFamille+"')", con);
                cmd3.ExecuteNonQuery();


                double total1;
                if (dt2.Compute("SUM(QuantiteSortante)", "Designation = '" + desi + "' ") is System.DBNull)
                {
                    total1 = 0;

                }
                else
                {
                    total1 = Convert.ToDouble(dt2.Compute("SUM(QuantiteSortante)", "Designation = '" + desi + "' "));
                }

                double total2;
                if (dt3.Compute("SUM(QuantiteEntrante)", "Designation = '" + desi + "' ") is System.DBNull)
                {
                    total2 = 0;
                }
                else
                {
                    total2 = Convert.ToDouble(dt3.Compute("SUM(QuantiteEntrante)", "Designation = '" + desi + "' "));
                }

                SqlCommand cmd4 = new SqlCommand("update [EtatStock] set QuantiteTotaleSortante = '" + total1 + "' , QuantiteTotaleEntrante = '" + total2 + "' where Designation = '" + desi + "'", con);
                cmd4.ExecuteNonQuery();

                total1 = 0;
                total2 = 0;



            }

            SqlCommand cmd6 = new SqlCommand("select * from [EtatStock]", con);
            SqlDataAdapter da4 = new SqlDataAdapter(cmd6);
            DataTable dt4 = new DataTable();

            da4.Fill(dt4);
            foreach (DataRow row2 in dt4.Rows)
            {
                string desi = row2["Designation"].ToString();
                int Initial = Convert.ToInt32(row2["StockInitial"].ToString());
                int Entrante = Convert.ToInt32(row2["QuantiteTotaleEntrante"].ToString());
                int Sortante = Convert.ToInt32(row2["QuantiteTotaleSortante"].ToString());
                double Prix = Convert.ToDouble(row2["PrixUnitaireMoyen"].ToString());
                int Reel = Initial + Entrante - Sortante;
                double Valeur = Reel * Prix;

                SqlCommand cmd7 = new SqlCommand("update [EtatStock] set StockReel =@p1 , Valeur =@p2 where Designation = '" + desi + "' ", con);
                cmd7.Parameters.AddWithValue("@p1", Reel);
                cmd7.Parameters.AddWithValue("@p2", Valeur);
                cmd7.ExecuteNonQuery();

            }
            SqlCommand cmd8 = new SqlCommand("select * from [EtatStock]", con);
            SqlDataAdapter da5 = new SqlDataAdapter(cmd8);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);
            dt5.Columns.Add("Etat");

            dgv.DataSource = dt5;
            dgv.Columns["PrixUnitaireMoyen"].HeaderText = "Prix Unitaire Moyen";
            dgv.Columns["StockInitial"].HeaderText = "Stock Initial";
            dgv.Columns["StockReel"].HeaderText = "Stock Réel";
            dgv.Columns["StockMin"].HeaderText = "Stock Min";
            dgv.Columns["QuantiteTotaleEntrante"].HeaderText = "Quantité Totale Entrante";
            dgv.Columns["QuantiteTotaleSortante"].HeaderText = "Quantité Totale Sortante";
            for (int i = 0; i < dgv.Rows.Count; i++) {
                int stockReel = Convert.ToInt32(dgv.Rows[i].Cells[5].Value.ToString());
                int stockMin = Convert.ToInt32(dgv.Rows[i].Cells[6].Value.ToString());
                if (stockReel <= stockMin && stockReel > 0) {
                    dgv.Rows[i].Cells[12].Style.BackColor = Color.Orange;    
                }
                if (stockReel > stockMin) {
                    dgv.Rows[i].Cells[12].Style.BackColor = Color.Green;
                }
                if (stockReel == 0)
                {
                    dgv.Rows[i].Cells[12].Style.BackColor = Color.Red;
                }
                if (stockReel < 0) {
                    dgv.Rows[i].Cells[12].Style.BackColor = Color.Blue;
                }
            }
            




            con.Close();


        }

        private void StockReport_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSet1.SousFamille'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.sousFamilleTableAdapter.Fill(this.dataSet1.SousFamille);
            // TODO: cette ligne de code charge les données dans la table 'dataSet1.Famille'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.familleTableAdapter.Fill(this.dataSet1.Famille);
            con.Open();

            SqlCommand cmd33 = new SqlCommand("select Designation from [Article]", con);
            SqlDataAdapter da33 = new SqlDataAdapter(cmd33);
            DataTable dt33 = new DataTable();
            DataTable dt44 = new DataTable();

            da33.Fill(dt33);
            foreach (DataRow row in dt33.Rows)
            {
                string Desi = row["Designation"].ToString();
                SqlCommand cmd44 = new SqlCommand("select Designation , QuantiteEntrante , MontantFactureHT from [Entree]", con);
                SqlDataAdapter da44 = new SqlDataAdapter(cmd44);
                da44.Fill(dt44);

                double MontantTotal;
                if (dt44.Compute("SUM(MontantFactureHT)", "Designation = '" + Desi + "' ") is System.DBNull)
                {
                    MontantTotal = 0;
                }
                else
                {
                    MontantTotal = Convert.ToDouble(dt44.Compute("SUM(MontantFactureHT)", "Designation = '" + Desi + "' "));
                }

                double QteEntranteTotal;
                if (dt44.Compute("SUM(QuantiteEntrante)", "Designation = '" + Desi + "' ") is System.DBNull)
                {
                    QteEntranteTotal = 0;
                }
                else
                {
                    QteEntranteTotal = Convert.ToDouble(dt44.Compute("SUM(QuantiteEntrante)", "Designation = '" + Desi + "' "));
                }
                if (QteEntranteTotal != 0)
                {

                    double PrixUnitaireMoyen = (double)MontantTotal / (double)QteEntranteTotal;
                    PrixUnitaireMoyen = Convert.ToDouble(String.Format("{0:0.00}", PrixUnitaireMoyen));
                    SqlCommand cmd55 = new SqlCommand("update [Sortie] set PrixUnitaireMoyenHT =@p1 where Designation = '" + Desi + "' ", con);
                    cmd55.Parameters.AddWithValue("@p1", PrixUnitaireMoyen);
                    cmd55.ExecuteNonQuery();
                    SqlCommand cmd66 = new SqlCommand("update [Article] set PrixUM =@p1 where Designation = '" + Desi + "'", con);
                    cmd66.Parameters.AddWithValue("@p1", PrixUnitaireMoyen);
                    cmd66.ExecuteNonQuery();
                    SqlCommand cmd77 = new SqlCommand("update [EtatStock] set PrixUnitaireMoyen =@p1 where Designation = '" + Desi + "'", con);
                    cmd77.Parameters.AddWithValue("@p1", PrixUnitaireMoyen);
                    cmd77.ExecuteNonQuery();



                }

            }


            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT Designation , Unite , PrixUM , StockI , StockMin , Famille , SFamille FROM [Article] ";
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();

            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                string desi = row["Designation"].ToString();
                string Unite = row["Unite"].ToString();
                double PrixUM = Convert.ToDouble(row["PrixUM"].ToString());
                int StockI = Convert.ToInt32(row["StockI"].ToString());
                int StockMin = Convert.ToInt32(row["StockMin"].ToString());
                string Famille = row["Famille"].ToString();
                string SousFamille = row["SFamille"].ToString();

                SqlCommand cmd2 = new SqlCommand("SELECT Designation , QuantiteSortante FROM [Sortie] WHERE Designation = '" + desi + "' ", con);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                da2.Fill(dt2);

                SqlCommand cmd5 = new SqlCommand("SELECT Designation , QuantiteEntrante FROM [Entree] WHERE Designation = '" + desi + "' ", con);
                SqlDataAdapter da3 = new SqlDataAdapter(cmd5);
                da3.Fill(dt3);

                SqlCommand cmd3 = new SqlCommand(" IF NOT EXISTS(SELECT Designation FROM [EtatStock] WHERE Designation = '" + desi + "') insert into [EtatStock] (Designation , Unite , PrixUnitaireMoyen , StockInitial , QuantiteTotaleSortante , QuantiteTotaleEntrante , StockMin , Famille , SousFamille) values ('" + desi + "' , '" + Unite + "' , @p1 , '" + StockI + "' , '0' , '0' , '" + StockMin + "' , '"+Famille+"' , '"+SousFamille+"')", con);
                cmd3.Parameters.AddWithValue("@p1", PrixUM);
                cmd3.ExecuteNonQuery();


                double total1;
                if (dt2.Compute("SUM(QuantiteSortante)", "Designation = '" + desi + "' ") is System.DBNull)
                {
                    total1 = 0;
                }
                else
                {
                    total1 = Convert.ToDouble(dt2.Compute("SUM(QuantiteSortante)", "Designation = '" + desi + "' "));
                }

                double total2;
                if (dt3.Compute("SUM(QuantiteEntrante)", "Designation = '" + desi + "' ") is System.DBNull)
                {
                    total2 = 0;
                }
                else
                {
                    total2 = Convert.ToDouble(dt3.Compute("SUM(QuantiteEntrante)", "Designation = '" + desi + "' "));
                }

                SqlCommand cmd4 = new SqlCommand("update [EtatStock] set QuantiteTotaleSortante = '" + total1 + "' , QuantiteTotaleEntrante = '" + total2 + "' where Designation = '" + desi + "'", con);
                cmd4.ExecuteNonQuery();

                total1 = 0;
                total2 = 0;



            }

            SqlCommand cmd6 = new SqlCommand("select * from [EtatStock]", con);
            SqlDataAdapter da4 = new SqlDataAdapter(cmd6);
            DataTable dt4 = new DataTable();

            da4.Fill(dt4);
            foreach (DataRow row2 in dt4.Rows)
            {
                string desi = row2["Designation"].ToString();
                int Initial = Convert.ToInt32(row2["StockInitial"].ToString());
                int Entrante = Convert.ToInt32(row2["QuantiteTotaleEntrante"].ToString());
                int Sortante = Convert.ToInt32(row2["QuantiteTotaleSortante"].ToString());
                double Prix = Convert.ToDouble(row2["PrixUnitaireMoyen"].ToString());
                int Reel = Initial + Entrante - Sortante;
                double Valeur = Reel * Prix;

                SqlCommand cmd7 = new SqlCommand("update [EtatStock] set StockReel =@p1 , Valeur =@p2 where Designation = '" + desi + "' ", con);
                cmd7.Parameters.AddWithValue("@p1", Reel);
                cmd7.Parameters.AddWithValue("@p2", Valeur);
                cmd7.ExecuteNonQuery();

            }
            SqlCommand cmd8 = new SqlCommand("select * from [EtatStock]", con);
            SqlDataAdapter da5 = new SqlDataAdapter(cmd8);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);
            dt5.Columns.Add("Etat");

            dgv.DataSource = dt5;
            dgv.Columns["PrixUnitaireMoyen"].HeaderText = "Prix Unitaire Moyen";
            dgv.Columns["StockInitial"].HeaderText = "Stock Initial";
            dgv.Columns["StockReel"].HeaderText = "Stock Réel";
            dgv.Columns["StockMin"].HeaderText = "Stock Min";
            dgv.Columns["QuantiteTotaleEntrante"].HeaderText = "Quantité Totale Entrante";
            dgv.Columns["QuantiteTotaleSortante"].HeaderText = "Quantité Totale Sortante";
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                string Desi = dgv.Rows[i].Cells[1].Value.ToString();
                int stockReel = Convert.ToInt32(dgv.Rows[i].Cells[5].Value.ToString());
                int stockMin = Convert.ToInt32(dgv.Rows[i].Cells[6].Value.ToString());
                if (stockReel <= stockMin && stockReel > 0)
                {
                    dgv.Rows[i].Cells[12].Style.BackColor = Color.Orange;
                    
                }
                if (stockReel > stockMin)
                {
                    dgv.Rows[i].Cells[12].Style.BackColor = Color.Green;
                }
                if (stockReel == 0)
                {
                    dgv.Rows[i].Cells[12].Style.BackColor = Color.Red;
                    MessageBox.Show("L'article : '"+Desi+"' est en rupture !", null, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                if (stockReel < 0)
                {
                    dgv.Rows[i].Cells[12].Style.BackColor = Color.Blue;
                }
            }
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Designation FROM [Article] ", con);
            SqlDataReader reader = cmd.ExecuteReader();
            AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                MyCollection.Add(reader.GetString(0));
            }


            txtDesi.AutoCompleteCustomSource = MyCollection;
            con.Close();
        }

        private void btnDesi_Click(object sender, EventArgs e)
        {
            string result = txtDesi.Text.ToString();
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [EtatStock] Where Designation = '" + result + "'", con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count > 0)
            {
                dtbl.Columns.Add("Etat");
                dgv.DataSource = dtbl;
                dgv.Columns["PrixUnitaireMoyen"].HeaderText = "Prix Unitaire Moyen";
                dgv.Columns["StockInitial"].HeaderText = "Stock Initial";
                dgv.Columns["StockReel"].HeaderText = "Stock Réel";
                dgv.Columns["StockMin"].HeaderText = "Stock Min";
                dgv.Columns["QuantiteTotaleEntrante"].HeaderText = "Quantité Totale Entrante";
                dgv.Columns["QuantiteTotaleSortante"].HeaderText = "Quantité Totale Sortante";
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    int stockReel = Convert.ToInt32(dgv.Rows[i].Cells[5].Value.ToString());
                    int stockMin = Convert.ToInt32(dgv.Rows[i].Cells[6].Value.ToString());
                    if (stockReel <= stockMin && stockReel > 0)
                    {
                        dgv.Rows[i].Cells[12].Style.BackColor = Color.Orange;
                    }
                    if (stockReel > stockMin)
                    {
                        dgv.Rows[i].Cells[12].Style.BackColor = Color.Green;
                    }
                    if (stockReel == 0)
                    {
                        dgv.Rows[i].Cells[12].Style.BackColor = Color.Red;
                    }
                    if (stockReel < 0)
                    {
                        dgv.Rows[i].Cells[12].Style.BackColor = Color.Blue;
                    }
                }



            }
            else
            {
                MessageBox.Show("Aucun résultat !", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        private void familleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.familleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void btnFamille_Click(object sender, EventArgs e)
        {
            string result = txtFamille.Text.ToString();
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [EtatStock] Where Famille = '" + result + "'", con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count > 0)
            {
                dtbl.Columns.Add("Etat");
                dgv.DataSource = dtbl;
                dgv.Columns["PrixUnitaireMoyen"].HeaderText = "Prix Unitaire Moyen";
                dgv.Columns["StockInitial"].HeaderText = "Stock Initial";
                dgv.Columns["StockReel"].HeaderText = "Stock Réel";
                dgv.Columns["StockMin"].HeaderText = "Stock Min";
                dgv.Columns["QuantiteTotaleEntrante"].HeaderText = "Quantité Totale Entrante";
                dgv.Columns["QuantiteTotaleSortante"].HeaderText = "Quantité Totale Sortante";
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    int stockReel = Convert.ToInt32(dgv.Rows[i].Cells[5].Value.ToString());
                    int stockMin = Convert.ToInt32(dgv.Rows[i].Cells[6].Value.ToString());
                    if (stockReel <= stockMin && stockReel > 0)
                    {
                        dgv.Rows[i].Cells[12].Style.BackColor = Color.Orange;
                    }
                    if (stockReel > stockMin)
                    {
                        dgv.Rows[i].Cells[12].Style.BackColor = Color.Green;
                    }
                    if (stockReel == 0)
                    {
                        dgv.Rows[i].Cells[12].Style.BackColor = Color.Red;
                    }
                    if (stockReel < 0)
                    {
                        dgv.Rows[i].Cells[12].Style.BackColor = Color.Blue;
                    }
                }

            }
            else
            {
                MessageBox.Show("Aucun résultat !", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        private void btnSFamille_Click(object sender, EventArgs e)
        {
            string result = txtSFamille.Text.ToString();
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [EtatStock] Where SousFamille = '" + result + "'", con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count > 0)
            {
                dtbl.Columns.Add("Etat");
                dgv.DataSource = dtbl;
                dgv.Columns["PrixUnitaireMoyen"].HeaderText = "Prix Unitaire Moyen";
                dgv.Columns["StockInitial"].HeaderText = "Stock Initial";
                dgv.Columns["StockReel"].HeaderText = "Stock Réel";
                dgv.Columns["StockMin"].HeaderText = "Stock Min";
                dgv.Columns["QuantiteTotaleEntrante"].HeaderText = "Quantité Totale Entrante";
                dgv.Columns["QuantiteTotaleSortante"].HeaderText = "Quantité Totale Sortante";
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    int stockReel = Convert.ToInt32(dgv.Rows[i].Cells[5].Value.ToString());
                    int stockMin = Convert.ToInt32(dgv.Rows[i].Cells[6].Value.ToString());
                    if (stockReel <= stockMin && stockReel > 0)
                    {
                        dgv.Rows[i].Cells[12].Style.BackColor = Color.Orange;
                    }
                    if (stockReel > stockMin)
                    {
                        dgv.Rows[i].Cells[12].Style.BackColor = Color.Green;
                    }
                    if (stockReel == 0)
                    {
                        dgv.Rows[i].Cells[12].Style.BackColor = Color.Red;
                    }
                    if (stockReel < 0)
                    {
                        dgv.Rows[i].Cells[12].Style.BackColor = Color.Blue;
                    }
                }

            }
            else
            {
                MessageBox.Show("Aucun résultat !", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        private void btnEtat_Click(object sender, EventArgs e)
        {
            string result = txtEtat.Text.ToString();
            con.Open();
            string cmd = " SELECT * FROM [EtatStock]";
            if (result == "RUPTURE DE STOCK")
            {
                cmd = " SELECT * FROM [EtatStock] Where StockReel = 0 ";
            }
            else if (result == "STOCK COUVERT")
            {
                cmd = " SELECT * FROM [EtatStock] Where StockReel > StockMin ";
            }
            else if (result == "STOCK MIN ATTEINT")
            {
                cmd = "SELECT * FROM [EtatStock] Where StockReel BETWEEN 0 AND StockMin";
            }
            else if (result == "ERREUR STOCK")
            {
                cmd = "SELECT * FROM [EtatStock] Where StockReel < 0";
            }
            else {
                MessageBox.Show("Aucun résultat !", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            SqlDataAdapter sda = new SqlDataAdapter(cmd , con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count > 0)
            {
                dtbl.Columns.Add("Etat");
                dgv.DataSource = dtbl;
                dgv.Columns["PrixUnitaireMoyen"].HeaderText = "Prix Unitaire Moyen";
                dgv.Columns["StockInitial"].HeaderText = "Stock Initial";
                dgv.Columns["StockReel"].HeaderText = "Stock Réel";
                dgv.Columns["StockMin"].HeaderText = "Stock Min";
                dgv.Columns["QuantiteTotaleEntrante"].HeaderText = "Quantité Totale Entrante";
                dgv.Columns["QuantiteTotaleSortante"].HeaderText = "Quantité Totale Sortante";
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    int stockReel = Convert.ToInt32(dgv.Rows[i].Cells[5].Value.ToString());
                    int stockMin = Convert.ToInt32(dgv.Rows[i].Cells[6].Value.ToString());
                    if (stockReel <= stockMin && stockReel > 0)
                    {
                        dgv.Rows[i].Cells[12].Style.BackColor = Color.Orange;
                    }
                    if (stockReel > stockMin)
                    {
                        dgv.Rows[i].Cells[12].Style.BackColor = Color.Green;
                    }
                    if (stockReel == 0)
                    {
                        dgv.Rows[i].Cells[12].Style.BackColor = Color.Red;
                    }
                    if (stockReel < 0)
                    {
                        dgv.Rows[i].Cells[12].Style.BackColor = Color.Blue;
                    }
                }

            }
            else
            {
                MessageBox.Show("Aucun résultat !", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }
    }
}
