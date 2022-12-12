using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GestionStock
{
    public partial class ArticleForm : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\GestionStock\GestionStock\Database1.mdf;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        public int SelectedID;
        public int SelectedClassValue;
        public int SelectedFamilleValue;
        public int SelectedSFamilleValue;
        public int SelectedFournisseurValue;
        public string oldDesi;
        public int Modifier;

        public ArticleForm()
        {
            InitializeComponent();
        }

        

        private void ArticleForm_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSet1.Fournisseur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.fournisseurTableAdapter.Fill(this.dataSet1.Fournisseur);
            // TODO: cette ligne de code charge les données dans la table 'dataSet1.Classement'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.classementTableAdapter.Fill(this.dataSet1.Classement);
            // TODO: cette ligne de code charge les données dans la table 'dataSet1.SousFamille'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.sousFamilleTableAdapter.Fill(this.dataSet1.SousFamille);
            // TODO: cette ligne de code charge les données dans la table 'dataSet1.Famille'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.familleTableAdapter.Fill(this.dataSet1.Famille);
            if (Modifier == 1)
            {
                ComboClassement.SelectedValue = SelectedClassValue;
                ComboFamille.SelectedValue = SelectedFamilleValue;
                ComboSousFamille.SelectedValue = SelectedSFamilleValue;
                txtFournisseur1.SelectedValue = SelectedFournisseurValue;
            }
            
            WindowState = FormWindowState.Maximized;


        }

        private void familleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.familleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string Cara = txtCara.Text.ToString();
            string Famille = ComboFamille.Text.ToString();
            string SousFamille = ComboSousFamille.Text.ToString();
            string Designation = txtDesi.Text.ToString();
            string PO = "Non";
            if (checkPO.Checked == true)
            {
                PO = "Oui";
            }
            int StockMin = 0;
            if (txtStockMin.Text == "")
            {
                StockMin = 0;
            }
            else {
                StockMin = Convert.ToInt32(txtStockMin.Text);
            }
            
           
            string Zone = txtZone.Text.ToString();
            string Armoire = txtArmoire.Text.ToString();
            string Colonne = txtColonne.Text.ToString();
            string Etage = txtEtage.Text.ToString();
            string Classement = ComboClassement.Text.ToString();
            string Unite = txtUnite.Text.ToString();
            double PrixUA = 0;
            if (txtPrixUA.Text == "")
            {
                PrixUA = 0;
            }
            else {
                PrixUA = Convert.ToDouble(txtPrixUA.Text, CultureInfo.InvariantCulture);
            }


            
            int StockI = 0;
            if (txtStockI.Text == "")
            {
                StockI = 0;
            }
            else {
                StockI = Convert.ToInt32(txtStockI.Text);
            }
            

            
            string DateInv = dateTimePicker1.Value.ToString();
            string Fournisseur = txtFournisseur1.Text.ToString();
            string Fabricant = txtFabricant.Text.ToString();
            string Fournisseur2 = txtFournisseur2.Text.ToString();
            string Fabricant2 = txtFabricant2.Text.ToString();
            double PrixUA2 = 0;
            if (txtPrixUA2.Text == "")
            {
                PrixUA2 = 0;
            }
            else { 
                PrixUA2 = Convert.ToDouble(txtPrixUA2.Text, CultureInfo.InvariantCulture);
            }
            


            
            
            string MethodeA = txtMA.Text.ToString();
            string Acheteur = txtAcheteur.Text.ToString();
            string ModePaiement = txtMP2.Text.ToString();
            if (Cara == "" || Famille == "" || SousFamille == "" || Designation == "" || Classement == "" || Unite == "" || DateInv == null || Fournisseur == "" || Fabricant == "")
            {
                MessageBox.Show("Veuillez remplir les champs obligatoires !", null, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else {

                con.Open();
                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select * from [Article] where Designation = '" + Designation + "' ";
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Cet article existe déjà !", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                else
                {
                    
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into [Article] values ('" + Cara + "' , '" + Famille + "' , '" + SousFamille + "' , '" + Designation + "' , '" + PO + "' , '" + StockMin + "' , '" + Zone + "' , '" + Armoire + "', '" + Colonne + "' , '" + Etage + "' , '" + Classement + "','" + Unite + "' , @p1 , @p2 , '" + StockI + "' , '" + DateInv + "' , '" + Fournisseur + "' , '" + Fabricant + "' , '" + Fournisseur2 + "' , '" + Fabricant2 + "' , @p3 , '" + MethodeA + "' , '" + Acheteur + "' , '" + ModePaiement + "')";
                    cmd.Parameters.AddWithValue("@p1", PrixUA);
                    cmd.Parameters.AddWithValue("@p2", PrixUA);
                    cmd.Parameters.AddWithValue("@p3", PrixUA2);

                    cmd.ExecuteNonQuery();
                    
                    MessageBox.Show("Article ajouté avec succès !");
                    txtCara.Text = "";
                    txtDesi.Text = "";
                    txtStockMin.Text = "";
                    checkPO.Checked = false;
                    txtZone.Text = "";
                    txtArmoire.Text = "";
                    txtColonne.Text = "";
                    txtEtage.Text = "";
                    txtUnite.Text = "";
                    txtPrixUA.Text = "";
                    
                    txtStockI.Text = "";
                    txtFournisseur1.SelectedValue = 0;
                    txtFournisseur2.Text = "";
                    txtFabricant.Text = "";
                    txtFabricant2.Text = "";
                    txtPrixUA2.Text = "";
                    txtMA.Text = "";
                    txtAcheteur.Text = "";
                    txtMP2.SelectedItem = "";
                    txtCara.Focus();
                }
                con.Close();

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

        private void txtPrixUA_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ValidateFloat(sender, e);
        }

        private void txtPrixUM_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ValidateFloat(sender, e);
        }

        private void txtStockI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrixUA2_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ValidateFloat(sender, e);
        }

        private void txtStockMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrixUA2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtStockMin_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPrixUA_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPrixUM_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtStockI_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Cara = txtCara.Text.ToString();
            string Famille = ComboFamille.Text.ToString();
            string SousFamille = ComboSousFamille.Text.ToString();
            string Designation = txtDesi.Text.ToString();
            string PO = "Non";
            if (checkPO.Checked == true)
            {
                PO = "Oui";
            }
            int StockMin = 0;
            if (txtStockMin.Text == "")
            {
                StockMin = 0;
            }
            else
            {
                StockMin = Convert.ToInt32(txtStockMin.Text);
            }


            string Zone = txtZone.Text.ToString();
            string Armoire = txtArmoire.Text.ToString();
            string Colonne = txtColonne.Text.ToString();
            string Etage = txtEtage.Text.ToString();
            string Classement = ComboClassement.Text.ToString();
            string Unite = txtUnite.Text.ToString();
            double PrixUA = 0;
            if (txtPrixUA.Text == "")
            {
                PrixUA = 0;
            }
            else
            {
                PrixUA = Convert.ToDouble(txtPrixUA.Text, CultureInfo.InvariantCulture);
            }

            

            int StockI = 0;
            if (txtStockI.Text == "")
            {
                StockI = 0;
            }
            else
            {
                StockI = Convert.ToInt32(txtStockI.Text);
            }

            string DateInv = dateTimePicker1.Value.ToString();
            string Fournisseur = txtFournisseur1.Text.ToString();
            string Fabricant = txtFabricant.Text.ToString();
            string Fournisseur2 = txtFournisseur2.Text.ToString();
            string Fabricant2 = txtFabricant2.Text.ToString();

            double PrixUA2 = 0;
            if (txtPrixUA2.Text == "")
            {
                PrixUA2 = 0;
            }
            else
            {
                PrixUA2 = Convert.ToDouble(txtPrixUA2.Text, CultureInfo.InvariantCulture);
            }




            string MethodeA = txtMA.Text.ToString();
            string Acheteur = txtAcheteur.Text.ToString();
            string ModePaiement = txtMP2.Text.ToString();
            if (Cara == "" || Famille == "" || SousFamille == "" || Designation == "" || Classement == "" || Unite == "" || DateInv == null || Fournisseur == "" || Fabricant == "")
            {
                MessageBox.Show("Veuillez remplir les champs obligatoires !", null, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else {

                
                
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE [Article] SET Caracteristique = '" + Cara + "' , Famille ='" + Famille + "' , SFamille = '" + SousFamille + "' , Designation = '" + Designation + "' , PO = '" + PO + "' , StockMin = '" + StockMin + "' , Zone = '" + Zone + "' , Armoire = '" + Armoire + "', Colonne = '" + Colonne + "' , Etage = '" + Etage + "' , Classement = '" + Classement + "', Unite = '" + Unite + "' , PrixUA =@p1 , StockI = '" + StockI + "' , DateInventaire = '" + DateInv + "' , Fournisseur = '" + Fournisseur + "' , Fabricant = '" + Fabricant + "' , Fournisseur2 = '" + Fournisseur2 + "' , Fabricant2 = '" + Fabricant2 + "' , PrixUA2 =@p3 , MethodeAchat = '" + MethodeA + "' , Acheteur = '" + Acheteur + "' , ModePaiement = '" + ModePaiement + "' WHERE Id = '" + SelectedID + "' ";
                    cmd.Parameters.AddWithValue("@p1", PrixUA);
                    cmd.Parameters.AddWithValue("@p3", PrixUA2);
                    cmd.ExecuteNonQuery();

                

                SqlCommand cmd2 = new SqlCommand("update [Entree] SET Unite = '"+Unite+"' , Fournisseur = '"+Fournisseur+"' , Fabricant = '"+Fabricant+"' , MethodeAchat = '"+MethodeA+"' , Acheteur = '"+Acheteur+"' , ModePaiement = '"+ModePaiement+"' WHERE Designation = '"+Designation+"' ", con);
                    cmd2.ExecuteNonQuery();
                    SqlCommand cmd3 = new SqlCommand("update [Sortie] SET Unite = '"+Unite+ "' , Famille = '" + Famille + "' , SousFamille = '" + SousFamille + "' WHERE Designation = '" + Designation+"'  ", con);
                    
                    cmd3.ExecuteNonQuery();
                    SqlCommand cmd4 = new SqlCommand("update [EtatStock] SET Unite = '"+Unite+ "' , StockInitial = '" + StockI+"' , StockMin = '"+StockMin+ "' , Famille = '"+Famille+"' , SousFamille = '"+SousFamille+"' WHERE Designation = '" + Designation + "'  ", con );
                    
                    cmd4.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Article mis à jour avec succès !");
                    txtCara.Text = "";
                    txtDesi.Text = "";
                    txtStockMin.Text = "";
                    checkPO.Checked = false;
                    txtZone.Text = "";
                    txtArmoire.Text = "";
                    txtColonne.Text = "";
                    txtEtage.Text = "";
                    txtUnite.Text = "";
                    txtPrixUA.Text = "";
                    //txtPrixUM.Text = "0";
                    txtStockI.Text = "";
                    txtFournisseur1.SelectedValue = 0;
                    txtFournisseur2.Text = "";
                    txtFabricant.Text = "";
                    txtFabricant2.Text = "";
                    txtPrixUA2.Text = "";
                    txtMA.Text = "";
                    txtAcheteur.Text = "";
                    txtMP2.SelectedItem = "";
                    txtCara.Focus();
                
                
                
            }
        }
    }
}
