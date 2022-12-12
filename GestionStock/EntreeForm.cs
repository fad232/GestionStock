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
    public partial class EntreeForm : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\GestionStock\GestionStock\Database1.mdf;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        public int SelectedID;
        public int SelectedFournisseurValue;
        public int Modifier;
        
        public EntreeForm()
        {
            InitializeComponent();
        }

        private void EntreeForm_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSet1.Fournisseur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.fournisseurTableAdapter.Fill(this.dataSet1.Fournisseur);
            //txtQEntrante.Text = "0";
            //txtPrixUCHT.Text = "0";
            if (Modifier == 1)
            {
                txtFournisseur1.SelectedValue = SelectedFournisseurValue;
            }
            WindowState = FormWindowState.Maximized;
            
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Designation FROM [Article] ", con);
            SqlDataReader reader = cmd.ExecuteReader();
            AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
            while (reader.Read()) {
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
                        txtFabricant.Text = rd.GetValue(rd.GetOrdinal("Fabricant")).ToString();
                        txtMA.Text = rd.GetValue(rd.GetOrdinal("MethodeAchat")).ToString();
                        txtAcheteur.Text = rd.GetValue(rd.GetOrdinal("Acheteur")).ToString();
                        txtMP.Text = rd.GetValue(rd.GetOrdinal("ModePaiement")).ToString();


                    }
                    else
                    {
                        MessageBox.Show("Erreur de recherche!", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                con.Close();
            }
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            string Desi = txtDesi1.Text.ToString();
            string DA = txtDA.Text.ToString();
            string NBL = txtBL.Text.ToString();
            string DateCommande = txtDateCommande.Value.ToString();
            string DateReception = txtDateReception.Value.ToString();
            string Unite = txtUnite.Text.ToString();
            double QE = 0;
            if (txtQEntrante.Text == "")
            {
                QE = 0;
            }
            else {
                QE = Convert.ToDouble(txtQEntrante.Text, CultureInfo.InvariantCulture);
            }
            double PUCHT = 0;
            if (txtPrixUCHT.Text == "")
            {
                PUCHT = 0;
            }
            else {
                PUCHT = Convert.ToDouble(txtPrixUCHT.Text, CultureInfo.InvariantCulture);
            }
            
            double MFHT = QE * PUCHT;
            string FournisseurActuel = txtFournisseur1.Text.ToString();
            string FHabituel;
            if (checkHabituel.Checked == true)
            {
                FHabituel = "Oui";
            }
            else {
                FHabituel = "Non";
            }
            string Fabricant = txtFabricant.Text.ToString();
            string MA = txtMA.Text.ToString();
            string Acheteur = txtAcheteur.Text.ToString();
            string MP = txtMP.Text.ToString();
            double Delai = Convert.ToDouble(labelDelai.Text);
            if (Desi == "" || DA == "" || NBL == "" || Unite == "" || FournisseurActuel == "")
            {
                MessageBox.Show("Veuillez remplir les champs obligatoires !", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [Entree] values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,'Non')";
                cmd.Parameters.AddWithValue("@p1", Desi);
                cmd.Parameters.AddWithValue("@p2", DA);
                cmd.Parameters.AddWithValue("@p3", NBL);
                cmd.Parameters.AddWithValue("@p4", DateCommande);
                cmd.Parameters.AddWithValue("@p5", DateReception);
                cmd.Parameters.AddWithValue("@p6", Unite);
                cmd.Parameters.AddWithValue("@p7", QE);
                cmd.Parameters.AddWithValue("@p8", PUCHT);
                cmd.Parameters.AddWithValue("@p9", MFHT);
                cmd.Parameters.AddWithValue("@p10", FournisseurActuel);
                cmd.Parameters.AddWithValue("@p11", Fabricant);
                cmd.Parameters.AddWithValue("@p12", MA);
                cmd.Parameters.AddWithValue("@p13", Acheteur);
                cmd.Parameters.AddWithValue("@p14", MP);
                cmd.Parameters.AddWithValue("@p15", Delai);
                cmd.Parameters.AddWithValue("@p16", FHabituel);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Entrée ajouté avec succès !");
                con.Close();
                txtDesi1.Text = "";
                txtDA.Text = "";
                txtBL.Text = "";
                txtUnite.Text = "";
                txtQEntrante.Text = "";
                txtPrixUCHT.Text = "";
                txtFournisseur1.SelectedValue = 0;
                txtFabricant.Text = "";
                txtMA.Text = "";
                txtMP.Text = "";
                txtAcheteur.Text = "";
                
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

        private void txtQEntrante_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ValidateFloat(sender, e);
        }

        private void txtQEntrante_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void txtPrixUCHT_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ValidateFloat(sender, e);
        }

        private void txtPrixUCHT_TextChanged(object sender, EventArgs e)
        {
            
            

        }

        private void txtDateReception_ValueChanged(object sender, EventArgs e)
        {
            int DayCommande = txtDateCommande.Value.Date.Day;
            int MonthCommande = txtDateCommande.Value.Date.Month;
            int YearCommande = txtDateCommande.Value.Date.Year;
            DateTime commande = new DateTime(YearCommande, MonthCommande, DayCommande);
            int DayReception = txtDateReception.Value.Date.Day;
            int MonthReception = txtDateReception.Value.Date.Month;
            int YearReception = txtDateReception.Value.Date.Year;
            DateTime reception = new DateTime(YearReception, MonthReception, DayReception);
            double result = reception.Subtract(commande).TotalDays;
            labelDelai.Text = result.ToString();
        }

        private void txtDateCommande_ValueChanged(object sender, EventArgs e)
        {
            
            int DayCommande = txtDateCommande.Value.Date.Day;
            int MonthCommande = txtDateCommande.Value.Date.Month;
            int YearCommande = txtDateCommande.Value.Date.Year;
            DateTime commande = new DateTime(YearCommande, MonthCommande, DayCommande);
            int DayReception = txtDateReception.Value.Date.Day;
            int MonthReception = txtDateReception.Value.Date.Month;
            int YearReception = txtDateReception.Value.Date.Year;
            DateTime reception = new DateTime(YearReception, MonthReception, DayReception);
            double result = reception.Subtract(commande).TotalDays;
            labelDelai.Text = result.ToString();
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            string Desi = txtDesi1.Text.ToString();
            string DA = txtDA.Text.ToString();
            string NBL = txtBL.Text.ToString();
            string DateCommande = txtDateCommande.Value.ToString();
            string DateReception = txtDateReception.Value.ToString();
            string Unite = txtUnite.Text.ToString();
            double QE = 0;
            if (txtQEntrante.Text == "")
            {
                QE = 0;
            }
            else
            {
                QE = Convert.ToDouble(txtQEntrante.Text, CultureInfo.InvariantCulture);
            }
            double PUCHT = 0;
            if (txtPrixUCHT.Text == "")
            {
                PUCHT = 0;
            }
            else
            {
                PUCHT = Convert.ToDouble(txtPrixUCHT.Text, CultureInfo.InvariantCulture);
            }
            double MFHT = QE * PUCHT;
            string FournisseurActuel = txtFournisseur1.Text.ToString();
            string FHabituel;
            if (checkHabituel.Checked == true)
            {
                FHabituel = "Oui";
            }
            else
            {
                FHabituel = "Non";
            }
            string Fabricant = txtFabricant.Text.ToString();
            string MA = txtMA.Text.ToString();
            string Acheteur = txtAcheteur.Text.ToString();
            string MP = txtMP.Text.ToString();
            double Delai = Convert.ToDouble(labelDelai.Text);
            if (Desi == "" || DA == "" || NBL == "" || Unite == "" || FournisseurActuel == "")
            {
                MessageBox.Show("Veuillez remplir les champs obligatoires !", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                con.Open();
                
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE [Entree] SET CodeDA = '"+DA+ "' , NBL = '"+NBL+ "' , DateCommande = '"+DateCommande+ "' , DateReception = '"+DateReception+ "' , Unite = '"+Unite+ "' , QuantiteEntrante =@p1 , PrixUnitaireCalculeHT =@p2 , MontantFactureHT =@p3 , Fournisseur = '"+FournisseurActuel+"' , Fabricant = '"+Fabricant+"' , MethodeAchat = '"+MA+"' , Acheteur = '"+Acheteur+ "' , ModePaiement = '"+MP+ "' , DelaiLivraison =@p4 , FournisseurHabituel = '"+FHabituel+"' WHERE Id = '" + SelectedID+"' ";
                cmd.Parameters.AddWithValue("@p1", QE);
                cmd.Parameters.AddWithValue("@p2", PUCHT);
                cmd.Parameters.AddWithValue("@p3", MFHT);
                cmd.Parameters.AddWithValue("@p4", Delai);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Entrée mise à jour avec succès !");
                txtDesi1.Text = "";
                txtDA.Text = "";
                txtBL.Text = "";
                txtUnite.Text = "";
                txtQEntrante.Text = "";
                txtPrixUCHT.Text = "";
                txtFournisseur1.SelectedValue = 0;
                txtFabricant.Text = "";
                txtMA.Text = "";
                txtMP.Text = "";
                txtAcheteur.Text = "";
                
                checkHabituel.Checked = false;
                txtDesi1.Focus();
            }
        }

        private void fournisseurBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fournisseurBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }
    }
}
