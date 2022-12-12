
namespace GestionStock
{
    partial class SortieForm
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
            this.labelTitre = new System.Windows.Forms.Label();
            this.txtDesi1 = new System.Windows.Forms.TextBox();
            this.buttonRecherche = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnite = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQSortante = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAffOb = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValeurS = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.DateSortie = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.dataSet1 = new GestionStock.DataSet1();
            this.motifBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.motifTableAdapter = new GestionStock.DataSet1TableAdapters.MotifTableAdapter();
            this.tableAdapterManager = new GestionStock.DataSet1TableAdapters.TableAdapterManager();
            this.demandeurTableAdapter = new GestionStock.DataSet1TableAdapters.DemandeurTableAdapter();
            this.txtMotif = new MetroFramework.Controls.MetroComboBox();
            this.demandeurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtDemandeur = new MetroFramework.Controls.MetroComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPUMHT = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motifBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demandeurBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitre
            // 
            this.labelTitre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelTitre.Location = new System.Drawing.Point(791, 46);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(214, 28);
            this.labelTitre.TabIndex = 12;
            this.labelTitre.Text = "Ajouter une sortie";
            // 
            // txtDesi1
            // 
            this.txtDesi1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDesi1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDesi1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDesi1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesi1.Location = new System.Drawing.Point(676, 123);
            this.txtDesi1.Name = "txtDesi1";
            this.txtDesi1.Size = new System.Drawing.Size(421, 32);
            this.txtDesi1.TabIndex = 96;
            // 
            // buttonRecherche
            // 
            this.buttonRecherche.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonRecherche.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecherche.Location = new System.Drawing.Point(1130, 113);
            this.buttonRecherche.Name = "buttonRecherche";
            this.buttonRecherche.Size = new System.Drawing.Size(234, 49);
            this.buttonRecherche.TabIndex = 95;
            this.buttonRecherche.Text = "Recherche";
            this.buttonRecherche.UseVisualStyleBackColor = true;
            this.buttonRecherche.Click += new System.EventHandler(this.buttonRecherche_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 23);
            this.label1.TabIndex = 94;
            this.label1.Text = "Désignation de l\'article";
            // 
            // txtUnite
            // 
            this.txtUnite.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUnite.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtUnite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUnite.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnite.Location = new System.Drawing.Point(396, 233);
            this.txtUnite.Multiline = true;
            this.txtUnite.Name = "txtUnite";
            this.txtUnite.ReadOnly = true;
            this.txtUnite.Size = new System.Drawing.Size(351, 30);
            this.txtUnite.TabIndex = 99;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(396, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 1);
            this.panel1.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(19, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 39);
            this.label2.TabIndex = 97;
            this.label2.Text = "Unité";
            // 
            // txtQSortante
            // 
            this.txtQSortante.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtQSortante.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtQSortante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQSortante.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQSortante.Location = new System.Drawing.Point(396, 359);
            this.txtQSortante.Multiline = true;
            this.txtQSortante.Name = "txtQSortante";
            this.txtQSortante.Size = new System.Drawing.Size(351, 30);
            this.txtQSortante.TabIndex = 102;
            this.txtQSortante.Text = "0";
            this.txtQSortante.TextChanged += new System.EventHandler(this.txtQSortante_TextChanged);
            this.txtQSortante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQSortante_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(396, 391);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 1);
            this.panel2.TabIndex = 101;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 39);
            this.label3.TabIndex = 100;
            this.label3.Text = "Quantité sortante";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 773);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 39);
            this.label4.TabIndex = 103;
            this.label4.Text = "Date de sortie";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(821, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 39);
            this.label5.TabIndex = 106;
            this.label5.Text = "Motif";
            // 
            // txtAffOb
            // 
            this.txtAffOb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAffOb.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtAffOb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAffOb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAffOb.Location = new System.Drawing.Point(1161, 492);
            this.txtAffOb.Multiline = true;
            this.txtAffOb.Name = "txtAffOb";
            this.txtAffOb.Size = new System.Drawing.Size(401, 30);
            this.txtAffOb.TabIndex = 111;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel5.Location = new System.Drawing.Point(1161, 524);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(401, 1);
            this.panel5.TabIndex = 110;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(821, 502);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(305, 39);
            this.label6.TabIndex = 109;
            this.label6.Text = "Affectation et observation";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(821, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 39);
            this.label7.TabIndex = 112;
            this.label7.Text = "Demandeur";
            // 
            // txtValeurS
            // 
            this.txtValeurS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtValeurS.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtValeurS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValeurS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValeurS.Location = new System.Drawing.Point(396, 642);
            this.txtValeurS.Multiline = true;
            this.txtValeurS.Name = "txtValeurS";
            this.txtValeurS.ReadOnly = true;
            this.txtValeurS.Size = new System.Drawing.Size(351, 30);
            this.txtValeurS.TabIndex = 117;
            this.txtValeurS.Text = "0";
            this.txtValeurS.TextChanged += new System.EventHandler(this.txtValeurS_TextChanged);
            this.txtValeurS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValeurS_KeyPress);
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel7.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel7.Location = new System.Drawing.Point(396, 674);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(351, 1);
            this.panel7.TabIndex = 116;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 633);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 39);
            this.label8.TabIndex = 115;
            this.label8.Text = "Valeur sortie (DH)";
            // 
            // DateSortie
            // 
            this.DateSortie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateSortie.CustomFormat = "yyyy-MM-dd";
            this.DateSortie.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateSortie.Location = new System.Drawing.Point(396, 782);
            this.DateSortie.Name = "DateSortie";
            this.DateSortie.Size = new System.Drawing.Size(351, 25);
            this.DateSortie.TabIndex = 118;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassementTableAdapter = null;
            this.tableAdapterManager.DemandeurTableAdapter = this.demandeurTableAdapter;
            this.tableAdapterManager.FamilleTableAdapter = null;
            this.tableAdapterManager.FournisseurTableAdapter = null;
            this.tableAdapterManager.MotifTableAdapter = this.motifTableAdapter;
            this.tableAdapterManager.SousFamilleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestionStock.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserRoleTableAdapter = null;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // demandeurTableAdapter
            // 
            this.demandeurTableAdapter.ClearBeforeFill = true;
            // 
            // txtMotif
            // 
            this.txtMotif.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMotif.DataSource = this.motifBindingSource;
            this.txtMotif.DisplayMember = "Motif";
            this.txtMotif.FormattingEnabled = true;
            this.txtMotif.ItemHeight = 24;
            this.txtMotif.Location = new System.Drawing.Point(1161, 372);
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(401, 30);
            this.txtMotif.TabIndex = 119;
            this.txtMotif.UseSelectable = true;
            this.txtMotif.ValueMember = "Id";
            // 
            // demandeurBindingSource
            // 
            this.demandeurBindingSource.DataMember = "Demandeur";
            this.demandeurBindingSource.DataSource = this.dataSet1;
            // 
            // txtDemandeur
            // 
            this.txtDemandeur.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDemandeur.DataSource = this.demandeurBindingSource;
            this.txtDemandeur.DisplayMember = "NomDemandeur";
            this.txtDemandeur.FormattingEnabled = true;
            this.txtDemandeur.ItemHeight = 24;
            this.txtDemandeur.Location = new System.Drawing.Point(1161, 243);
            this.txtDemandeur.Name = "txtDemandeur";
            this.txtDemandeur.Size = new System.Drawing.Size(401, 30);
            this.txtDemandeur.TabIndex = 119;
            this.txtDemandeur.UseSelectable = true;
            this.txtDemandeur.ValueMember = "Id";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonModifier);
            this.panel3.Controls.Add(this.buttonAjouter);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 892);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1665, 163);
            this.panel3.TabIndex = 120;
            // 
            // buttonModifier
            // 
            this.buttonModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonModifier.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonModifier.FlatAppearance.BorderSize = 0;
            this.buttonModifier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonModifier.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifier.Location = new System.Drawing.Point(1345, 7);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(245, 54);
            this.buttonModifier.TabIndex = 90;
            this.buttonModifier.Text = "Modifier sortie";
            this.buttonModifier.UseVisualStyleBackColor = false;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAjouter.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonAjouter.FlatAppearance.BorderSize = 0;
            this.buttonAjouter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonAjouter.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouter.Location = new System.Drawing.Point(1345, 83);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(245, 54);
            this.buttonAjouter.TabIndex = 89;
            this.buttonAjouter.Text = "Ajouter une sortie";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label17.Location = new System.Drawing.Point(71, 46);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(378, 23);
            this.label17.TabIndex = 121;
            this.label17.Text = "Champs en rouge : Remplissage auto";
            // 
            // txtPUMHT
            // 
            this.txtPUMHT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPUMHT.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtPUMHT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPUMHT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPUMHT.Location = new System.Drawing.Point(396, 492);
            this.txtPUMHT.Multiline = true;
            this.txtPUMHT.Name = "txtPUMHT";
            this.txtPUMHT.ReadOnly = true;
            this.txtPUMHT.Size = new System.Drawing.Size(351, 30);
            this.txtPUMHT.TabIndex = 124;
            this.txtPUMHT.Text = "0";
            this.txtPUMHT.TextChanged += new System.EventHandler(this.txtPUMHT_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel4.Location = new System.Drawing.Point(396, 524);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(351, 1);
            this.panel4.TabIndex = 123;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(21, 492);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(291, 39);
            this.label9.TabIndex = 122;
            this.label9.Text = "Prix UM Pondéré";
            // 
            // SortieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1665, 1055);
            this.Controls.Add(this.txtPUMHT);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtDemandeur);
            this.Controls.Add(this.txtMotif);
            this.Controls.Add(this.DateSortie);
            this.Controls.Add(this.txtValeurS);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAffOb);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQSortante);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUnite);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDesi1);
            this.Controls.Add(this.buttonRecherche);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitre);
            this.Name = "SortieForm";
            this.ShowIcon = false;
            this.Text = "Formulaire Sortie";
            this.Load += new System.EventHandler(this.SortieForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motifBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demandeurBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelTitre;
        public System.Windows.Forms.TextBox txtDesi1;
        private System.Windows.Forms.Button buttonRecherche;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtUnite;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtQSortante;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtAffOb;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtValeurS;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label8;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource motifBindingSource;
        private DataSet1TableAdapters.MotifTableAdapter motifTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DataSet1TableAdapters.DemandeurTableAdapter demandeurTableAdapter;
        private System.Windows.Forms.BindingSource demandeurBindingSource;
        public MetroFramework.Controls.MetroComboBox txtMotif;
        public MetroFramework.Controls.MetroComboBox txtDemandeur;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button buttonModifier;
        public System.Windows.Forms.Button buttonAjouter;
        public ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker DateSortie;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox txtPUMHT;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
    }
}