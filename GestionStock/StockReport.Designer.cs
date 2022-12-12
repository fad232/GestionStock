
namespace GestionStock
{
    partial class StockReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockReport));
            this.dgv = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.labelTitre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonActualiser = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDesi = new System.Windows.Forms.Button();
            this.txtDesi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataSet1 = new GestionStock.DataSet1();
            this.familleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.familleTableAdapter = new GestionStock.DataSet1TableAdapters.FamilleTableAdapter();
            this.tableAdapterManager = new GestionStock.DataSet1TableAdapters.TableAdapterManager();
            this.sousFamilleTableAdapter = new GestionStock.DataSet1TableAdapters.SousFamilleTableAdapter();
            this.familleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sousFamilleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtFamille = new MetroFramework.Controls.MetroComboBox();
            this.sousFamilleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sousFamilleBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.txtSFamille = new MetroFramework.Controls.MetroComboBox();
            this.familleSousFamilleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.familleSousFamilleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.familleSousFamilleBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnFamille = new System.Windows.Forms.Button();
            this.btnSFamille = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEtat = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEtat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sousFamilleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sousFamilleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sousFamilleBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familleSousFamilleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familleSousFamilleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familleSousFamilleBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 254);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1522, 548);
            this.dgv.TabIndex = 112;
            // 
            // labelTitre
            // 
            this.labelTitre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelTitre.Location = new System.Drawing.Point(655, 41);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(160, 28);
            this.labelTitre.TabIndex = 113;
            this.labelTitre.Text = "Etat du stock";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ButtonActualiser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 949);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1667, 106);
            this.panel1.TabIndex = 114;
            // 
            // ButtonActualiser
            // 
            this.ButtonActualiser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonActualiser.Location = new System.Drawing.Point(1401, 26);
            this.ButtonActualiser.Name = "ButtonActualiser";
            this.ButtonActualiser.Size = new System.Drawing.Size(152, 50);
            this.ButtonActualiser.TabIndex = 10;
            this.ButtonActualiser.Values.Text = "Actualiser";
            this.ButtonActualiser.Click += new System.EventHandler(this.ButtonActualiser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1042, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 117;
            this.label1.Text = "Designation";
            // 
            // btnDesi
            // 
            this.btnDesi.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnDesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesi.Image = ((System.Drawing.Image)(resources.GetObject("btnDesi.Image")));
            this.btnDesi.Location = new System.Drawing.Point(1498, 108);
            this.btnDesi.Name = "btnDesi";
            this.btnDesi.Size = new System.Drawing.Size(38, 32);
            this.btnDesi.TabIndex = 116;
            this.btnDesi.UseVisualStyleBackColor = true;
            this.btnDesi.Click += new System.EventHandler(this.btnDesi_Click);
            // 
            // txtDesi
            // 
            this.txtDesi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDesi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDesi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesi.Location = new System.Drawing.Point(1198, 108);
            this.txtDesi.Name = "txtDesi";
            this.txtDesi.Size = new System.Drawing.Size(285, 32);
            this.txtDesi.TabIndex = 115;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 23);
            this.label4.TabIndex = 119;
            this.label4.Text = "SousFamille";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 118;
            this.label3.Text = "Famille";
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
            this.tableAdapterManager.SousFamilleTableAdapter = this.sousFamilleTableAdapter;
            this.tableAdapterManager.UpdateOrder = GestionStock.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserRoleTableAdapter = null;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // sousFamilleTableAdapter
            // 
            this.sousFamilleTableAdapter.ClearBeforeFill = true;
            // 
            // familleBindingSource1
            // 
            this.familleBindingSource1.DataMember = "Famille";
            this.familleBindingSource1.DataSource = this.dataSet1;
            // 
            // sousFamilleBindingSource
            // 
            this.sousFamilleBindingSource.DataMember = "Famille_SousFamille";
            this.sousFamilleBindingSource.DataSource = this.familleBindingSource;
            // 
            // txtFamille
            // 
            this.txtFamille.DataSource = this.familleBindingSource;
            this.txtFamille.DisplayMember = "NomFamille";
            this.txtFamille.FormattingEnabled = true;
            this.txtFamille.ItemHeight = 24;
            this.txtFamille.Location = new System.Drawing.Point(228, 114);
            this.txtFamille.Name = "txtFamille";
            this.txtFamille.Size = new System.Drawing.Size(300, 30);
            this.txtFamille.TabIndex = 122;
            this.txtFamille.UseSelectable = true;
            this.txtFamille.ValueMember = "Id";
            // 
            // sousFamilleBindingSource1
            // 
            this.sousFamilleBindingSource1.DataMember = "Famille_SousFamille";
            this.sousFamilleBindingSource1.DataSource = this.familleBindingSource1;
            // 
            // sousFamilleBindingSource2
            // 
            this.sousFamilleBindingSource2.DataMember = "Famille_SousFamille";
            this.sousFamilleBindingSource2.DataSource = this.familleBindingSource1;
            // 
            // txtSFamille
            // 
            this.txtSFamille.DataSource = this.familleSousFamilleBindingSource1;
            this.txtSFamille.DisplayMember = "NomSFamille";
            this.txtSFamille.FormattingEnabled = true;
            this.txtSFamille.ItemHeight = 24;
            this.txtSFamille.Location = new System.Drawing.Point(228, 190);
            this.txtSFamille.Name = "txtSFamille";
            this.txtSFamille.Size = new System.Drawing.Size(300, 30);
            this.txtSFamille.TabIndex = 122;
            this.txtSFamille.UseSelectable = true;
            this.txtSFamille.ValueMember = "Id";
            // 
            // familleSousFamilleBindingSource1
            // 
            this.familleSousFamilleBindingSource1.DataMember = "Famille_SousFamille";
            this.familleSousFamilleBindingSource1.DataSource = this.familleBindingSource;
            // 
            // familleSousFamilleBindingSource
            // 
            this.familleSousFamilleBindingSource.DataMember = "Famille_SousFamille";
            this.familleSousFamilleBindingSource.DataSource = this.familleBindingSource1;
            // 
            // familleSousFamilleBindingSource2
            // 
            this.familleSousFamilleBindingSource2.DataMember = "Famille_SousFamille";
            this.familleSousFamilleBindingSource2.DataSource = this.familleBindingSource;
            // 
            // btnFamille
            // 
            this.btnFamille.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnFamille.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFamille.Image = ((System.Drawing.Image)(resources.GetObject("btnFamille.Image")));
            this.btnFamille.Location = new System.Drawing.Point(544, 115);
            this.btnFamille.Name = "btnFamille";
            this.btnFamille.Size = new System.Drawing.Size(38, 32);
            this.btnFamille.TabIndex = 123;
            this.btnFamille.UseVisualStyleBackColor = true;
            this.btnFamille.Click += new System.EventHandler(this.btnFamille_Click);
            // 
            // btnSFamille
            // 
            this.btnSFamille.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnSFamille.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSFamille.Image = ((System.Drawing.Image)(resources.GetObject("btnSFamille.Image")));
            this.btnSFamille.Location = new System.Drawing.Point(544, 190);
            this.btnSFamille.Name = "btnSFamille";
            this.btnSFamille.Size = new System.Drawing.Size(38, 32);
            this.btnSFamille.TabIndex = 124;
            this.btnSFamille.UseVisualStyleBackColor = true;
            this.btnSFamille.Click += new System.EventHandler(this.btnSFamille_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(1279, 822);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 23);
            this.label2.TabIndex = 125;
            this.label2.Text = "Vert : Stock couvert";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Orange;
            this.label5.Location = new System.Drawing.Point(1279, 861);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 23);
            this.label5.TabIndex = 126;
            this.label5.Text = "Orange : Stock min atteint";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(934, 861);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(256, 23);
            this.label6.TabIndex = 127;
            this.label6.Text = "Rouge : Rupture de stock";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(934, 822);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 23);
            this.label7.TabIndex = 128;
            this.label7.Text = "Bleu : Erreur du stock";
            // 
            // txtEtat
            // 
            this.txtEtat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEtat.FormattingEnabled = true;
            this.txtEtat.Items.AddRange(new object[] {
            "STOCK COUVERT",
            "RUPTURE DE STOCK",
            "STOCK MIN ATTEINT",
            "ERREUR STOCK"});
            this.txtEtat.Location = new System.Drawing.Point(1198, 191);
            this.txtEtat.Name = "txtEtat";
            this.txtEtat.Size = new System.Drawing.Size(285, 31);
            this.txtEtat.TabIndex = 129;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1042, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 23);
            this.label8.TabIndex = 130;
            this.label8.Text = "Etat";
            // 
            // btnEtat
            // 
            this.btnEtat.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnEtat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEtat.Image = ((System.Drawing.Image)(resources.GetObject("btnEtat.Image")));
            this.btnEtat.Location = new System.Drawing.Point(1498, 192);
            this.btnEtat.Name = "btnEtat";
            this.btnEtat.Size = new System.Drawing.Size(38, 32);
            this.btnEtat.TabIndex = 131;
            this.btnEtat.UseVisualStyleBackColor = true;
            this.btnEtat.Click += new System.EventHandler(this.btnEtat_Click);
            // 
            // StockReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1667, 1055);
            this.Controls.Add(this.btnEtat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEtat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSFamille);
            this.Controls.Add(this.btnFamille);
            this.Controls.Add(this.txtSFamille);
            this.Controls.Add(this.txtFamille);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDesi);
            this.Controls.Add(this.txtDesi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.dgv);
            this.Name = "StockReport";
            this.Text = "StockReport";
            this.Load += new System.EventHandler(this.StockReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sousFamilleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sousFamilleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sousFamilleBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familleSousFamilleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familleSousFamilleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familleSousFamilleBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv;
        public System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ButtonActualiser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDesi;
        public System.Windows.Forms.TextBox txtDesi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource familleBindingSource;
        private DataSet1TableAdapters.FamilleTableAdapter familleTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DataSet1TableAdapters.SousFamilleTableAdapter sousFamilleTableAdapter;
        private System.Windows.Forms.BindingSource familleBindingSource1;
        private System.Windows.Forms.BindingSource sousFamilleBindingSource;
        private MetroFramework.Controls.MetroComboBox txtFamille;
        private System.Windows.Forms.BindingSource sousFamilleBindingSource1;
        private System.Windows.Forms.BindingSource sousFamilleBindingSource2;
        private MetroFramework.Controls.MetroComboBox txtSFamille;
        private System.Windows.Forms.BindingSource familleSousFamilleBindingSource;
        private System.Windows.Forms.BindingSource familleSousFamilleBindingSource2;
        private System.Windows.Forms.BindingSource familleSousFamilleBindingSource1;
        private System.Windows.Forms.Button btnFamille;
        private System.Windows.Forms.Button btnSFamille;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox txtEtat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEtat;
    }
}