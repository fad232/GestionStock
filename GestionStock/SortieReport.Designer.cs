
namespace GestionStock
{
    partial class SortieReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SortieReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTitre = new System.Windows.Forms.Label();
            this.txtDesi = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonActualiser = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDesi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataSet1 = new GestionStock.DataSet1();
            this.demandeurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demandeurTableAdapter = new GestionStock.DataSet1TableAdapters.DemandeurTableAdapter();
            this.tableAdapterManager = new GestionStock.DataSet1TableAdapters.TableAdapterManager();
            this.txtDemandeur = new MetroFramework.Controls.MetroComboBox();
            this.btnDemandeur = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.familleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.familleTableAdapter = new GestionStock.DataSet1TableAdapters.FamilleTableAdapter();
            this.txtFamille = new MetroFramework.Controls.MetroComboBox();
            this.btnFamille = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.sousFamilleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sousFamilleTableAdapter = new GestionStock.DataSet1TableAdapters.SousFamilleTableAdapter();
            this.btnSousFamille = new System.Windows.Forms.Button();
            this.sousFamilleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sousFamilleBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.txtSFamille = new MetroFramework.Controls.MetroComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.motifBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.motifTableAdapter = new GestionStock.DataSet1TableAdapters.MotifTableAdapter();
            this.txtMotif = new MetroFramework.Controls.MetroComboBox();
            this.btnMotif = new System.Windows.Forms.Button();
            this.dgv = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.DateSortie1 = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.DateSortie2 = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demandeurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sousFamilleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sousFamilleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sousFamilleBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motifBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitre
            // 
            this.labelTitre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelTitre.Location = new System.Drawing.Point(658, 9);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(191, 28);
            this.labelTitre.TabIndex = 13;
            this.labelTitre.Text = "Liste des sorties";
            // 
            // txtDesi
            // 
            this.txtDesi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDesi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDesi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesi.Location = new System.Drawing.Point(192, 82);
            this.txtDesi.Name = "txtDesi";
            this.txtDesi.Size = new System.Drawing.Size(285, 32);
            this.txtDesi.TabIndex = 94;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ButtonActualiser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 949);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1667, 106);
            this.panel1.TabIndex = 97;
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
            // btnDesi
            // 
            this.btnDesi.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnDesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesi.Image = ((System.Drawing.Image)(resources.GetObject("btnDesi.Image")));
            this.btnDesi.Location = new System.Drawing.Point(492, 82);
            this.btnDesi.Name = "btnDesi";
            this.btnDesi.Size = new System.Drawing.Size(38, 32);
            this.btnDesi.TabIndex = 99;
            this.btnDesi.UseVisualStyleBackColor = true;
            this.btnDesi.Click += new System.EventHandler(this.btnDesi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 100;
            this.label1.Text = "Designation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 101;
            this.label2.Text = "Demandeur";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // demandeurBindingSource
            // 
            this.demandeurBindingSource.DataMember = "Demandeur";
            this.demandeurBindingSource.DataSource = this.dataSet1;
            // 
            // demandeurTableAdapter
            // 
            this.demandeurTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassementTableAdapter = null;
            this.tableAdapterManager.DemandeurTableAdapter = this.demandeurTableAdapter;
            this.tableAdapterManager.FamilleTableAdapter = this.familleTableAdapter;
            this.tableAdapterManager.FournisseurTableAdapter = null;
            this.tableAdapterManager.MotifTableAdapter = this.motifTableAdapter;
            this.tableAdapterManager.SousFamilleTableAdapter = this.sousFamilleTableAdapter;
            this.tableAdapterManager.UpdateOrder = GestionStock.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtDemandeur
            // 
            this.txtDemandeur.DataSource = this.demandeurBindingSource;
            this.txtDemandeur.DisplayMember = "NomDemandeur";
            this.txtDemandeur.FormattingEnabled = true;
            this.txtDemandeur.ItemHeight = 24;
            this.txtDemandeur.Location = new System.Drawing.Point(192, 151);
            this.txtDemandeur.Name = "txtDemandeur";
            this.txtDemandeur.Size = new System.Drawing.Size(285, 30);
            this.txtDemandeur.TabIndex = 102;
            this.txtDemandeur.UseSelectable = true;
            this.txtDemandeur.ValueMember = "Id";
            // 
            // btnDemandeur
            // 
            this.btnDemandeur.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnDemandeur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDemandeur.Image = ((System.Drawing.Image)(resources.GetObject("btnDemandeur.Image")));
            this.btnDemandeur.Location = new System.Drawing.Point(492, 151);
            this.btnDemandeur.Name = "btnDemandeur";
            this.btnDemandeur.Size = new System.Drawing.Size(38, 36);
            this.btnDemandeur.TabIndex = 104;
            this.btnDemandeur.UseVisualStyleBackColor = true;
            this.btnDemandeur.Click += new System.EventHandler(this.btnDemandeur_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(601, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 105;
            this.label3.Text = "Famille";
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
            // txtFamille
            // 
            this.txtFamille.DataSource = this.familleBindingSource;
            this.txtFamille.DisplayMember = "NomFamille";
            this.txtFamille.FormattingEnabled = true;
            this.txtFamille.ItemHeight = 24;
            this.txtFamille.Location = new System.Drawing.Point(758, 84);
            this.txtFamille.Name = "txtFamille";
            this.txtFamille.Size = new System.Drawing.Size(300, 30);
            this.txtFamille.TabIndex = 105;
            this.txtFamille.UseSelectable = true;
            this.txtFamille.ValueMember = "Id";
            // 
            // btnFamille
            // 
            this.btnFamille.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnFamille.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFamille.Image = ((System.Drawing.Image)(resources.GetObject("btnFamille.Image")));
            this.btnFamille.Location = new System.Drawing.Point(1073, 85);
            this.btnFamille.Name = "btnFamille";
            this.btnFamille.Size = new System.Drawing.Size(38, 32);
            this.btnFamille.TabIndex = 106;
            this.btnFamille.UseVisualStyleBackColor = true;
            this.btnFamille.Click += new System.EventHandler(this.btnFamille_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(602, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 23);
            this.label4.TabIndex = 107;
            this.label4.Text = "SousFamille";
            // 
            // sousFamilleBindingSource
            // 
            this.sousFamilleBindingSource.DataMember = "SousFamille";
            this.sousFamilleBindingSource.DataSource = this.dataSet1;
            // 
            // sousFamilleTableAdapter
            // 
            this.sousFamilleTableAdapter.ClearBeforeFill = true;
            // 
            // btnSousFamille
            // 
            this.btnSousFamille.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnSousFamille.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSousFamille.Image = ((System.Drawing.Image)(resources.GetObject("btnSousFamille.Image")));
            this.btnSousFamille.Location = new System.Drawing.Point(1073, 156);
            this.btnSousFamille.Name = "btnSousFamille";
            this.btnSousFamille.Size = new System.Drawing.Size(38, 36);
            this.btnSousFamille.TabIndex = 108;
            this.btnSousFamille.UseVisualStyleBackColor = true;
            this.btnSousFamille.Click += new System.EventHandler(this.btnSousFamille_Click);
            // 
            // sousFamilleBindingSource1
            // 
            this.sousFamilleBindingSource1.DataMember = "Famille_SousFamille";
            this.sousFamilleBindingSource1.DataSource = this.familleBindingSource;
            // 
            // sousFamilleBindingSource2
            // 
            this.sousFamilleBindingSource2.DataMember = "Famille_SousFamille";
            this.sousFamilleBindingSource2.DataSource = this.familleBindingSource;
            // 
            // txtSFamille
            // 
            this.txtSFamille.DataSource = this.sousFamilleBindingSource2;
            this.txtSFamille.DisplayMember = "NomSFamille";
            this.txtSFamille.FormattingEnabled = true;
            this.txtSFamille.ItemHeight = 24;
            this.txtSFamille.Location = new System.Drawing.Point(758, 155);
            this.txtSFamille.Name = "txtSFamille";
            this.txtSFamille.Size = new System.Drawing.Size(300, 30);
            this.txtSFamille.TabIndex = 108;
            this.txtSFamille.UseSelectable = true;
            this.txtSFamille.ValueMember = "Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1169, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 23);
            this.label5.TabIndex = 109;
            this.label5.Text = "Motif";
            // 
            // motifBindingSource
            // 
            this.motifBindingSource.DataMember = "Motif";
            this.motifBindingSource.DataSource = this.dataSet1;
            // 
            // motifTableAdapter
            // 
            this.motifTableAdapter.ClearBeforeFill = true;
            // 
            // txtMotif
            // 
            this.txtMotif.DataSource = this.motifBindingSource;
            this.txtMotif.DisplayMember = "Motif";
            this.txtMotif.FormattingEnabled = true;
            this.txtMotif.ItemHeight = 24;
            this.txtMotif.Location = new System.Drawing.Point(1271, 84);
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(300, 30);
            this.txtMotif.TabIndex = 109;
            this.txtMotif.UseSelectable = true;
            this.txtMotif.ValueMember = "Id";
            // 
            // btnMotif
            // 
            this.btnMotif.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnMotif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMotif.Image = ((System.Drawing.Image)(resources.GetObject("btnMotif.Image")));
            this.btnMotif.Location = new System.Drawing.Point(1587, 85);
            this.btnMotif.Name = "btnMotif";
            this.btnMotif.Size = new System.Drawing.Size(38, 32);
            this.btnMotif.TabIndex = 110;
            this.btnMotif.UseVisualStyleBackColor = true;
            this.btnMotif.Click += new System.EventHandler(this.btnMotif_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(40, 290);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1402, 548);
            this.dgv.TabIndex = 111;
            // 
            // DateSortie1
            // 
            this.DateSortie1.CustomFormat = "yyyy-MM-dd";
            this.DateSortie1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateSortie1.Location = new System.Drawing.Point(1343, 155);
            this.DateSortie1.Name = "DateSortie1";
            this.DateSortie1.Size = new System.Drawing.Size(228, 25);
            this.DateSortie1.TabIndex = 119;
            // 
            // DateSortie2
            // 
            this.DateSortie2.CustomFormat = "yyyy-MM-dd";
            this.DateSortie2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateSortie2.Location = new System.Drawing.Point(1343, 208);
            this.DateSortie2.Name = "DateSortie2";
            this.DateSortie2.Size = new System.Drawing.Size(228, 25);
            this.DateSortie2.TabIndex = 120;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1169, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 23);
            this.label6.TabIndex = 121;
            this.label6.Text = "Date debut";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1169, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 23);
            this.label7.TabIndex = 122;
            this.label7.Text = "Date fin";
            // 
            // btnDate
            // 
            this.btnDate.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDate.Image = ((System.Drawing.Image)(resources.GetObject("btnDate.Image")));
            this.btnDate.Location = new System.Drawing.Point(1587, 179);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(38, 32);
            this.btnDate.TabIndex = 123;
            this.btnDate.UseVisualStyleBackColor = true;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // SortieReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1667, 1055);
            this.Controls.Add(this.btnDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DateSortie2);
            this.Controls.Add(this.DateSortie1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnMotif);
            this.Controls.Add(this.txtMotif);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSFamille);
            this.Controls.Add(this.btnSousFamille);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFamille);
            this.Controls.Add(this.txtFamille);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDemandeur);
            this.Controls.Add(this.txtDemandeur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDesi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDesi);
            this.Controls.Add(this.labelTitre);
            this.Name = "SortieReport";
            this.Text = "SortieReport";
            this.Load += new System.EventHandler(this.SortieReport_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demandeurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sousFamilleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sousFamilleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sousFamilleBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motifBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label labelTitre;
        public System.Windows.Forms.TextBox txtDesi;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ButtonActualiser;
        private System.Windows.Forms.Button btnDesi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource demandeurBindingSource;
        private DataSet1TableAdapters.DemandeurTableAdapter demandeurTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private MetroFramework.Controls.MetroComboBox txtDemandeur;
        private System.Windows.Forms.Button btnDemandeur;
        private DataSet1TableAdapters.FamilleTableAdapter familleTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource familleBindingSource;
        private DataSet1TableAdapters.SousFamilleTableAdapter sousFamilleTableAdapter;
        private MetroFramework.Controls.MetroComboBox txtFamille;
        private System.Windows.Forms.Button btnFamille;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource sousFamilleBindingSource;
        private System.Windows.Forms.Button btnSousFamille;
        private System.Windows.Forms.BindingSource sousFamilleBindingSource1;
        private System.Windows.Forms.BindingSource sousFamilleBindingSource2;
        private MetroFramework.Controls.MetroComboBox txtSFamille;
        private DataSet1TableAdapters.MotifTableAdapter motifTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource motifBindingSource;
        private MetroFramework.Controls.MetroComboBox txtMotif;
        private System.Windows.Forms.Button btnMotif;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv;
        public ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker DateSortie1;
        public ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker DateSortie2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDate;
    }
}