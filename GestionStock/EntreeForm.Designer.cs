
namespace GestionStock
{
    partial class EntreeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRecherche = new System.Windows.Forms.Button();
            this.txtDA = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBL = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDateCommande = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDateReception = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.txtUnite = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtQEntrante = new System.Windows.Forms.TextBox();
            this.txtPrixUCHT = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFournisseur = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFabricant = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMP = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAcheteur = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMA = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.labelDelai = new System.Windows.Forms.Label();
            this.txtDesi1 = new System.Windows.Forms.TextBox();
            this.txtDesi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dataSet1 = new GestionStock.DataSet1();
            this.fournisseurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fournisseurTableAdapter = new GestionStock.DataSet1TableAdapters.FournisseurTableAdapter();
            this.tableAdapterManager = new GestionStock.DataSet1TableAdapters.TableAdapterManager();
            this.txtFournisseur1 = new MetroFramework.Controls.MetroComboBox();
            this.checkHabituel = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fournisseurBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitre
            // 
            this.labelTitre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelTitre.Location = new System.Drawing.Point(866, 33);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(226, 28);
            this.labelTitre.TabIndex = 11;
            this.labelTitre.Text = "Ajouter une entrée";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Désignation de l\'article";
            // 
            // buttonRecherche
            // 
            this.buttonRecherche.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonRecherche.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecherche.Location = new System.Drawing.Point(1328, 109);
            this.buttonRecherche.Name = "buttonRecherche";
            this.buttonRecherche.Size = new System.Drawing.Size(234, 49);
            this.buttonRecherche.TabIndex = 27;
            this.buttonRecherche.Text = "Recherche";
            this.buttonRecherche.UseVisualStyleBackColor = true;
            this.buttonRecherche.Click += new System.EventHandler(this.buttonRecherche_Click);
            // 
            // txtDA
            // 
            this.txtDA.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtDA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDA.Location = new System.Drawing.Point(281, 292);
            this.txtDA.Multiline = true;
            this.txtDA.Name = "txtDA";
            this.txtDA.Size = new System.Drawing.Size(351, 30);
            this.txtDA.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(281, 324);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 1);
            this.panel1.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 39);
            this.label2.TabIndex = 28;
            this.label2.Text = "Code DA*";
            // 
            // txtBL
            // 
            this.txtBL.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtBL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBL.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBL.Location = new System.Drawing.Point(281, 418);
            this.txtBL.Multiline = true;
            this.txtBL.Name = "txtBL";
            this.txtBL.Size = new System.Drawing.Size(351, 30);
            this.txtBL.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(281, 450);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(351, 1);
            this.panel3.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 38);
            this.label3.TabIndex = 31;
            this.label3.Text = "N BL*";
            // 
            // txtDateCommande
            // 
            this.txtDateCommande.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDateCommande.Location = new System.Drawing.Point(281, 552);
            this.txtDateCommande.Name = "txtDateCommande";
            this.txtDateCommande.Size = new System.Drawing.Size(351, 25);
            this.txtDateCommande.TabIndex = 34;
            this.txtDateCommande.ValueChanged += new System.EventHandler(this.txtDateCommande_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 557);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "Date commande*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 663);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 23);
            this.label5.TabIndex = 36;
            this.label5.Text = "Date reception*";
            // 
            // txtDateReception
            // 
            this.txtDateReception.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDateReception.Location = new System.Drawing.Point(281, 660);
            this.txtDateReception.Name = "txtDateReception";
            this.txtDateReception.Size = new System.Drawing.Size(351, 25);
            this.txtDateReception.TabIndex = 37;
            this.txtDateReception.ValueChanged += new System.EventHandler(this.txtDateReception_ValueChanged);
            // 
            // txtUnite
            // 
            this.txtUnite.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtUnite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUnite.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnite.Location = new System.Drawing.Point(281, 775);
            this.txtUnite.Multiline = true;
            this.txtUnite.Name = "txtUnite";
            this.txtUnite.ReadOnly = true;
            this.txtUnite.Size = new System.Drawing.Size(351, 30);
            this.txtUnite.TabIndex = 40;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel4.Location = new System.Drawing.Point(281, 807);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(351, 1);
            this.panel4.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(60, 785);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 23);
            this.label6.TabIndex = 38;
            this.label6.Text = "Unité*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(668, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 23);
            this.label7.TabIndex = 41;
            this.label7.Text = "Quantité entrante*";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel5.Location = new System.Drawing.Point(913, 329);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(351, 1);
            this.panel5.TabIndex = 42;
            // 
            // txtQEntrante
            // 
            this.txtQEntrante.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtQEntrante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQEntrante.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQEntrante.Location = new System.Drawing.Point(913, 297);
            this.txtQEntrante.Multiline = true;
            this.txtQEntrante.Name = "txtQEntrante";
            this.txtQEntrante.Size = new System.Drawing.Size(351, 30);
            this.txtQEntrante.TabIndex = 43;
            this.txtQEntrante.TextChanged += new System.EventHandler(this.txtQEntrante_TextChanged);
            this.txtQEntrante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQEntrante_KeyPress);
            // 
            // txtPrixUCHT
            // 
            this.txtPrixUCHT.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtPrixUCHT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrixUCHT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrixUCHT.Location = new System.Drawing.Point(913, 423);
            this.txtPrixUCHT.Multiline = true;
            this.txtPrixUCHT.Name = "txtPrixUCHT";
            this.txtPrixUCHT.Size = new System.Drawing.Size(351, 30);
            this.txtPrixUCHT.TabIndex = 46;
            this.txtPrixUCHT.TextChanged += new System.EventHandler(this.txtPrixUCHT_TextChanged);
            this.txtPrixUCHT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrixUCHT_KeyPress);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel6.Location = new System.Drawing.Point(913, 455);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(351, 1);
            this.panel6.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(668, 433);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 23);
            this.label8.TabIndex = 44;
            this.label8.Text = "Prix Unitaire BL HT*";
            // 
            // txtFournisseur
            // 
            this.txtFournisseur.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtFournisseur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFournisseur.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFournisseur.Location = new System.Drawing.Point(1343, 674);
            this.txtFournisseur.Multiline = true;
            this.txtFournisseur.Name = "txtFournisseur";
            this.txtFournisseur.Size = new System.Drawing.Size(351, 30);
            this.txtFournisseur.TabIndex = 49;
            this.txtFournisseur.Visible = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel8.Location = new System.Drawing.Point(1343, 706);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(351, 1);
            this.panel8.TabIndex = 51;
            this.panel8.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(668, 540);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(192, 23);
            this.label10.TabIndex = 50;
            this.label10.Text = "Fournisseur actuel*";
            // 
            // txtFabricant
            // 
            this.txtFabricant.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtFabricant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFabricant.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFabricant.Location = new System.Drawing.Point(913, 653);
            this.txtFabricant.Multiline = true;
            this.txtFabricant.Name = "txtFabricant";
            this.txtFabricant.ReadOnly = true;
            this.txtFabricant.Size = new System.Drawing.Size(351, 30);
            this.txtFabricant.TabIndex = 52;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel9.Location = new System.Drawing.Point(913, 685);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(351, 1);
            this.panel9.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(668, 663);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 23);
            this.label11.TabIndex = 44;
            this.label11.Text = "Fabricant";
            // 
            // txtMP
            // 
            this.txtMP.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtMP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMP.Location = new System.Drawing.Point(1537, 418);
            this.txtMP.Multiline = true;
            this.txtMP.Name = "txtMP";
            this.txtMP.ReadOnly = true;
            this.txtMP.Size = new System.Drawing.Size(351, 30);
            this.txtMP.TabIndex = 61;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel10.Location = new System.Drawing.Point(1537, 450);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(351, 1);
            this.panel10.TabIndex = 60;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(1304, 428);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(201, 23);
            this.label12.TabIndex = 59;
            this.label12.Text = "Mode de paiement";
            // 
            // txtAcheteur
            // 
            this.txtAcheteur.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtAcheteur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAcheteur.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcheteur.Location = new System.Drawing.Point(1537, 289);
            this.txtAcheteur.Multiline = true;
            this.txtAcheteur.Name = "txtAcheteur";
            this.txtAcheteur.ReadOnly = true;
            this.txtAcheteur.Size = new System.Drawing.Size(351, 30);
            this.txtAcheteur.TabIndex = 58;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel11.Location = new System.Drawing.Point(1537, 321);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(351, 1);
            this.panel11.TabIndex = 57;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(1304, 299);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 23);
            this.label13.TabIndex = 56;
            this.label13.Text = "Acheteur";
            // 
            // txtMA
            // 
            this.txtMA.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtMA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMA.Location = new System.Drawing.Point(913, 775);
            this.txtMA.Multiline = true;
            this.txtMA.Name = "txtMA";
            this.txtMA.ReadOnly = true;
            this.txtMA.Size = new System.Drawing.Size(351, 30);
            this.txtMA.TabIndex = 55;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel12.Location = new System.Drawing.Point(913, 807);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(351, 1);
            this.panel12.TabIndex = 54;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(667, 785);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(183, 23);
            this.label14.TabIndex = 53;
            this.label14.Text = "Methode d\'achat";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1304, 550);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(176, 23);
            this.label15.TabIndex = 62;
            this.label15.Text = "Délai de livraison";
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
            this.buttonAjouter.Location = new System.Drawing.Point(1604, 83);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(245, 54);
            this.buttonAjouter.TabIndex = 89;
            this.buttonAjouter.Text = "Ajouter entrée";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.buttonModifier);
            this.panel7.Controls.Add(this.buttonAjouter);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 892);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1924, 163);
            this.panel7.TabIndex = 91;
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
            this.buttonModifier.Location = new System.Drawing.Point(1604, 7);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(245, 54);
            this.buttonModifier.TabIndex = 90;
            this.buttonModifier.Text = "Modifier entrée";
            this.buttonModifier.UseVisualStyleBackColor = false;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // labelDelai
            // 
            this.labelDelai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDelai.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDelai.Location = new System.Drawing.Point(1537, 543);
            this.labelDelai.Name = "labelDelai";
            this.labelDelai.Padding = new System.Windows.Forms.Padding(4);
            this.labelDelai.Size = new System.Drawing.Size(351, 36);
            this.labelDelai.TabIndex = 92;
            this.labelDelai.Text = "0";
            this.labelDelai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDesi1
            // 
            this.txtDesi1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDesi1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDesi1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDesi1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesi1.Location = new System.Drawing.Point(761, 119);
            this.txtDesi1.Name = "txtDesi1";
            this.txtDesi1.Size = new System.Drawing.Size(421, 32);
            this.txtDesi1.TabIndex = 93;
            // 
            // txtDesi
            // 
            this.txtDesi.AllowDrop = true;
            this.txtDesi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDesi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDesi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtDesi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDesi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesi.Location = new System.Drawing.Point(174, 36);
            this.txtDesi.Name = "txtDesi";
            this.txtDesi.Size = new System.Drawing.Size(98, 25);
            this.txtDesi.TabIndex = 26;
            this.txtDesi.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(60, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(241, 23);
            this.label9.TabIndex = 94;
            this.label9.Text = "DA : Demande d\'achat";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(60, 111);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(199, 23);
            this.label16.TabIndex = 95;
            this.label16.Text = "BL : Bon de livraison";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fournisseurBindingSource
            // 
            this.fournisseurBindingSource.DataMember = "Fournisseur";
            this.fournisseurBindingSource.DataSource = this.dataSet1;
            // 
            // fournisseurTableAdapter
            // 
            this.fournisseurTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassementTableAdapter = null;
            this.tableAdapterManager.DemandeurTableAdapter = null;
            this.tableAdapterManager.FamilleTableAdapter = null;
            this.tableAdapterManager.FournisseurTableAdapter = this.fournisseurTableAdapter;
            this.tableAdapterManager.MotifTableAdapter = null;
            this.tableAdapterManager.SousFamilleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestionStock.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserRoleTableAdapter = null;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // txtFournisseur1
            // 
            this.txtFournisseur1.DataSource = this.fournisseurBindingSource;
            this.txtFournisseur1.DisplayMember = "NomFournisseur";
            this.txtFournisseur1.FormattingEnabled = true;
            this.txtFournisseur1.ItemHeight = 24;
            this.txtFournisseur1.Location = new System.Drawing.Point(913, 533);
            this.txtFournisseur1.Name = "txtFournisseur1";
            this.txtFournisseur1.Size = new System.Drawing.Size(351, 30);
            this.txtFournisseur1.TabIndex = 96;
            this.txtFournisseur1.UseSelectable = true;
            this.txtFournisseur1.ValueMember = "Id";
            // 
            // checkHabituel
            // 
            this.checkHabituel.AutoSize = true;
            this.checkHabituel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkHabituel.Location = new System.Drawing.Point(913, 604);
            this.checkHabituel.Name = "checkHabituel";
            this.checkHabituel.Size = new System.Drawing.Size(239, 27);
            this.checkHabituel.TabIndex = 97;
            this.checkHabituel.Text = "Fournisseur habituel ?";
            this.checkHabituel.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label17.Location = new System.Drawing.Point(60, 190);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(378, 23);
            this.label17.TabIndex = 98;
            this.label17.Text = "Champs en rouge : Remplissage auto";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1656, 36);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(232, 23);
            this.label18.TabIndex = 99;
            this.label18.Text = "(*) Champs obligatoire";
            // 
            // EntreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.checkHabituel);
            this.Controls.Add(this.txtFournisseur1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDesi1);
            this.Controls.Add(this.labelDelai);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtMP);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtAcheteur);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtMA);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtFabricant);
            this.Controls.Add(this.txtFournisseur);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPrixUCHT);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtQEntrante);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUnite);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDateReception);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDateCommande);
            this.Controls.Add(this.txtBL);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDA);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonRecherche);
            this.Controls.Add(this.txtDesi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitre);
            this.Name = "EntreeForm";
            this.ShowIcon = false;
            this.Text = "Formulaire Entrée";
            this.Load += new System.EventHandler(this.EntreeForm_Load);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fournisseurBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRecherche;
        public System.Windows.Forms.TextBox txtDA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtBL;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtUnite;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.TextBox txtQEntrante;
        public System.Windows.Forms.TextBox txtPrixUCHT;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtFournisseur;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtFabricant;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtMP;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtAcheteur;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtMA;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Panel panel7;
        public ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker txtDateCommande;
        public System.Windows.Forms.Label labelDelai;
        public System.Windows.Forms.Button buttonModifier;
        public ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker txtDateReception;
        public System.Windows.Forms.TextBox txtDesi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox txtDesi1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource fournisseurBindingSource;
        private DataSet1TableAdapters.FournisseurTableAdapter fournisseurTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        public MetroFramework.Controls.MetroComboBox txtFournisseur1;
        public System.Windows.Forms.CheckBox checkHabituel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}