
namespace GestionStock
{
    partial class InventaireForm
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
            this.txtDesi1 = new System.Windows.Forms.TextBox();
            this.buttonRecherche = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTitre = new System.Windows.Forms.Label();
            this.textRI = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textCara = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textStockI = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textFamille = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textSousFamille = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DateInventaire = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDesi1
            // 
            this.txtDesi1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDesi1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDesi1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDesi1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesi1.Location = new System.Drawing.Point(650, 134);
            this.txtDesi1.Name = "txtDesi1";
            this.txtDesi1.Size = new System.Drawing.Size(421, 32);
            this.txtDesi1.TabIndex = 99;
            // 
            // buttonRecherche
            // 
            this.buttonRecherche.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonRecherche.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecherche.Location = new System.Drawing.Point(1104, 124);
            this.buttonRecherche.Name = "buttonRecherche";
            this.buttonRecherche.Size = new System.Drawing.Size(234, 49);
            this.buttonRecherche.TabIndex = 98;
            this.buttonRecherche.Text = "Recherche";
            this.buttonRecherche.UseVisualStyleBackColor = true;
            this.buttonRecherche.Click += new System.EventHandler(this.buttonRecherche_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 23);
            this.label1.TabIndex = 97;
            this.label1.Text = "Désignation de l\'article";
            // 
            // labelTitre
            // 
            this.labelTitre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelTitre.Location = new System.Drawing.Point(741, 55);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(210, 28);
            this.labelTitre.TabIndex = 100;
            this.labelTitre.Text = "Ajouter un article";
            // 
            // textRI
            // 
            this.textRI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textRI.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textRI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textRI.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRI.Location = new System.Drawing.Point(402, 377);
            this.textRI.Multiline = true;
            this.textRI.Name = "textRI";
            this.textRI.Size = new System.Drawing.Size(401, 30);
            this.textRI.TabIndex = 114;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel5.Location = new System.Drawing.Point(402, 409);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(401, 1);
            this.panel5.TabIndex = 113;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(305, 39);
            this.label6.TabIndex = 112;
            this.label6.Text = "Responsable inventaire";
            // 
            // textCara
            // 
            this.textCara.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textCara.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textCara.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCara.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCara.Location = new System.Drawing.Point(402, 503);
            this.textCara.Multiline = true;
            this.textCara.Name = "textCara";
            this.textCara.ReadOnly = true;
            this.textCara.Size = new System.Drawing.Size(401, 30);
            this.textCara.TabIndex = 117;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(402, 535);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 1);
            this.panel1.TabIndex = 116;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(62, 503);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 39);
            this.label2.TabIndex = 115;
            this.label2.Text = "Caractéristiques";
            // 
            // textStockI
            // 
            this.textStockI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textStockI.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textStockI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textStockI.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textStockI.Location = new System.Drawing.Point(402, 643);
            this.textStockI.Multiline = true;
            this.textStockI.Name = "textStockI";
            this.textStockI.Size = new System.Drawing.Size(401, 30);
            this.textStockI.TabIndex = 120;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(402, 675);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 1);
            this.panel2.TabIndex = 119;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(62, 643);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 39);
            this.label3.TabIndex = 118;
            this.label3.Text = "Stock Initial";
            // 
            // textFamille
            // 
            this.textFamille.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textFamille.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textFamille.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textFamille.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFamille.Location = new System.Drawing.Point(1184, 377);
            this.textFamille.Multiline = true;
            this.textFamille.Name = "textFamille";
            this.textFamille.ReadOnly = true;
            this.textFamille.Size = new System.Drawing.Size(401, 30);
            this.textFamille.TabIndex = 123;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(1184, 409);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(401, 1);
            this.panel3.TabIndex = 122;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(912, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 39);
            this.label4.TabIndex = 121;
            this.label4.Text = "Famille";
            // 
            // textSousFamille
            // 
            this.textSousFamille.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textSousFamille.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textSousFamille.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSousFamille.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSousFamille.Location = new System.Drawing.Point(1184, 503);
            this.textSousFamille.Multiline = true;
            this.textSousFamille.Name = "textSousFamille";
            this.textSousFamille.ReadOnly = true;
            this.textSousFamille.Size = new System.Drawing.Size(401, 30);
            this.textSousFamille.TabIndex = 126;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel4.Location = new System.Drawing.Point(1184, 535);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(401, 1);
            this.panel4.TabIndex = 125;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(912, 509);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 39);
            this.label5.TabIndex = 124;
            this.label5.Text = "Sous Famille";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(912, 643);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 39);
            this.label7.TabIndex = 127;
            this.label7.Text = "Date d\'inventaire";
            // 
            // DateInventaire
            // 
            this.DateInventaire.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateInventaire.CustomFormat = "yyyy-MM-dd";
            this.DateInventaire.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateInventaire.Location = new System.Drawing.Point(1184, 643);
            this.DateInventaire.Name = "DateInventaire";
            this.DateInventaire.Size = new System.Drawing.Size(410, 25);
            this.DateInventaire.TabIndex = 128;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label17.Location = new System.Drawing.Point(39, 221);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(378, 23);
            this.label17.TabIndex = 129;
            this.label17.Text = "Champs en rouge : Remplissage auto";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.buttonModifier);
            this.panel6.Controls.Add(this.buttonAjouter);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 892);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1665, 163);
            this.panel6.TabIndex = 130;
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
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = false;
            this.buttonModifier.Visible = false;
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
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // InventaireForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1665, 1055);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.DateInventaire);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textSousFamille);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textFamille);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textStockI);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textCara);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textRI);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.txtDesi1);
            this.Controls.Add(this.buttonRecherche);
            this.Controls.Add(this.label1);
            this.Name = "InventaireForm";
            this.ShowIcon = false;
            this.Text = "Formulaire Inventaire";
            this.Load += new System.EventHandler(this.InventaireForm_Load);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtDesi1;
        private System.Windows.Forms.Button buttonRecherche;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label labelTitre;
        public System.Windows.Forms.TextBox textRI;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textCara;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textStockI;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textFamille;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textSousFamille;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        public ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker DateInventaire;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Button buttonModifier;
        public System.Windows.Forms.Button buttonAjouter;
    }
}