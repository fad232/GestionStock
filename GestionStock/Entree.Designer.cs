
namespace GestionStock
{
    partial class Entree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entree));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.dgv = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonActualiser = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.labelTitre = new System.Windows.Forms.Label();
            this.buttonExporter = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(52, 68);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(253, 61);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.buttonModifier.TabIndex = 6;
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
            this.buttonSupprimer.TabIndex = 7;
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1061, 437);
            this.dgv.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonExporter);
            this.panel1.Controls.Add(this.ButtonActualiser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 697);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 148);
            this.panel1.TabIndex = 9;
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
            // labelTitre
            // 
            this.labelTitre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelTitre.Location = new System.Drawing.Point(480, 23);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(203, 28);
            this.labelTitre.TabIndex = 12;
            this.labelTitre.Text = "Liste des entrées";
            // 
            // buttonExporter
            // 
            this.buttonExporter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExporter.Location = new System.Drawing.Point(803, 61);
            this.buttonExporter.Name = "buttonExporter";
            this.buttonExporter.Size = new System.Drawing.Size(152, 50);
            this.buttonExporter.TabIndex = 13;
            this.buttonExporter.Values.Text = "Exporter";
            this.buttonExporter.Click += new System.EventHandler(this.buttonExporter_Click);
            // 
            // Entree
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1143, 845);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.button1);
            this.Name = "Entree";
            this.Text = "Entree";
            this.Load += new System.EventHandler(this.Entree_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonSupprimer;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ButtonActualiser;
        public System.Windows.Forms.Label labelTitre;
        private ComponentFactory.Krypton.Toolkit.KryptonButton buttonExporter;
    }
}