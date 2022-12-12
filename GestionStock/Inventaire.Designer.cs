
namespace GestionStock
{
    partial class Inventaire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventaire));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.dgv = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.labelTitre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonActualiser = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAjouter.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonAjouter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.buttonAjouter.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouter.Image = ((System.Drawing.Image)(resources.GetObject("buttonAjouter.Image")));
            this.buttonAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAjouter.Location = new System.Drawing.Point(52, 68);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.buttonAjouter.Size = new System.Drawing.Size(253, 61);
            this.buttonAjouter.TabIndex = 6;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonModifier.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonModifier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.buttonModifier.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifier.Image = ((System.Drawing.Image)(resources.GetObject("buttonModifier.Image")));
            this.buttonModifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModifier.Location = new System.Drawing.Point(453, 68);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.buttonModifier.Size = new System.Drawing.Size(253, 61);
            this.buttonModifier.TabIndex = 7;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = false;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSupprimer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonSupprimer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.buttonSupprimer.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimer.Image = ((System.Drawing.Image)(resources.GetObject("buttonSupprimer.Image")));
            this.buttonSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSupprimer.Location = new System.Drawing.Point(860, 68);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.buttonSupprimer.Size = new System.Drawing.Size(253, 61);
            this.buttonSupprimer.TabIndex = 8;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(52, 186);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1061, 437);
            this.dgv.TabIndex = 16;
            // 
            // labelTitre
            // 
            this.labelTitre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelTitre.Location = new System.Drawing.Point(490, 20);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(216, 28);
            this.labelTitre.TabIndex = 17;
            this.labelTitre.Text = "Fiche d\'inventaire";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ButtonActualiser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 697);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 148);
            this.panel1.TabIndex = 18;
            // 
            // ButtonActualiser
            // 
            this.ButtonActualiser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonActualiser.Location = new System.Drawing.Point(961, 61);
            this.ButtonActualiser.Name = "ButtonActualiser";
            this.ButtonActualiser.Size = new System.Drawing.Size(152, 50);
            this.ButtonActualiser.TabIndex = 9;
            this.ButtonActualiser.Values.Text = "Actualiser";
            this.ButtonActualiser.Click += new System.EventHandler(this.ButtonActualiser_Click);
            // 
            // Inventaire
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1143, 845);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonAjouter);
            this.Name = "Inventaire";
            this.Text = "Inventaire";
            this.Load += new System.EventHandler(this.Inventaire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonModifier;
        public System.Windows.Forms.Button buttonSupprimer;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv;
        public System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ButtonActualiser;
    }
}