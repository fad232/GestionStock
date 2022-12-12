
namespace GestionStock
{
    partial class GSFamille
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSet1 = new GestionStock.DataSet1();
            this.familleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.familleTableAdapter = new GestionStock.DataSet1TableAdapters.FamilleTableAdapter();
            this.tableAdapterManager = new GestionStock.DataSet1TableAdapters.TableAdapterManager();
            this.ComboFamille = new MetroFramework.Controls.MetroComboBox();
            this.txtSFamille = new System.Windows.Forms.TextBox();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ajouter une sous famille";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // familleBindingSource
            // 
            this.familleBindingSource.DataMember = "Famille";
            this.familleBindingSource.DataSource = this.dataSet1;
            // 
            // familleTableAdapter
            // 
            this.familleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassementTableAdapter = null;
            this.tableAdapterManager.DemandeurTableAdapter = null;
            this.tableAdapterManager.FamilleTableAdapter = this.familleTableAdapter;
            this.tableAdapterManager.FournisseurTableAdapter = null;
            this.tableAdapterManager.MotifTableAdapter = null;
            this.tableAdapterManager.SousFamilleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestionStock.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserRoleTableAdapter = null;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // ComboFamille
            // 
            this.ComboFamille.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ComboFamille.DataSource = this.familleBindingSource;
            this.ComboFamille.DisplayMember = "NomFamille";
            this.ComboFamille.FormattingEnabled = true;
            this.ComboFamille.ItemHeight = 24;
            this.ComboFamille.Location = new System.Drawing.Point(310, 126);
            this.ComboFamille.Name = "ComboFamille";
            this.ComboFamille.Size = new System.Drawing.Size(356, 30);
            this.ComboFamille.TabIndex = 3;
            this.ComboFamille.UseSelectable = true;
            this.ComboFamille.ValueMember = "Id";
            // 
            // txtSFamille
            // 
            this.txtSFamille.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSFamille.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSFamille.Location = new System.Drawing.Point(310, 232);
            this.txtSFamille.Multiline = true;
            this.txtSFamille.Name = "txtSFamille";
            this.txtSFamille.Size = new System.Drawing.Size(356, 41);
            this.txtSFamille.TabIndex = 4;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.kryptonButton1.Location = new System.Drawing.Point(310, 333);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(356, 47);
            this.kryptonButton1.TabIndex = 5;
            this.kryptonButton1.Values.Text = "Ajouter";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Famille Mère";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sous Famille";
            // 
            // GSFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(838, 440);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.txtSFamille);
            this.Controls.Add(this.ComboFamille);
            this.Controls.Add(this.label1);
            this.Name = "GSFamille";
            this.ShowIcon = false;
            this.Text = "Gestion Sous Famille";
            this.Load += new System.EventHandler(this.GSFamille_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource familleBindingSource;
        private DataSet1TableAdapters.FamilleTableAdapter familleTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private MetroFramework.Controls.MetroComboBox ComboFamille;
        private System.Windows.Forms.TextBox txtSFamille;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}