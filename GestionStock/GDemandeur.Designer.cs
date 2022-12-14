
namespace GestionStock
{
    partial class GDemandeur
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDemandeur = new System.Windows.Forms.TextBox();
            this.dgv = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.buttonAjouter = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.buttonSupprimer = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.buttonActualiser = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Entrez un demandeur";
            // 
            // txtDemandeur
            // 
            this.txtDemandeur.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDemandeur.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDemandeur.Location = new System.Drawing.Point(352, 60);
            this.txtDemandeur.Multiline = true;
            this.txtDemandeur.Name = "txtDemandeur";
            this.txtDemandeur.Size = new System.Drawing.Size(296, 34);
            this.txtDemandeur.TabIndex = 27;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(352, 160);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(296, 209);
            this.dgv.TabIndex = 29;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAjouter.Location = new System.Drawing.Point(83, 160);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(197, 34);
            this.buttonAjouter.TabIndex = 30;
            this.buttonAjouter.Values.Text = "Ajouter";
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSupprimer.Location = new System.Drawing.Point(83, 241);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(199, 34);
            this.buttonSupprimer.TabIndex = 31;
            this.buttonSupprimer.Values.Text = "Supprimer";
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonActualiser
            // 
            this.buttonActualiser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonActualiser.Location = new System.Drawing.Point(81, 336);
            this.buttonActualiser.Name = "buttonActualiser";
            this.buttonActualiser.Size = new System.Drawing.Size(199, 34);
            this.buttonActualiser.TabIndex = 32;
            this.buttonActualiser.Values.Text = "Actualiser";
            this.buttonActualiser.Click += new System.EventHandler(this.buttonActualiser_Click);
            // 
            // GDemandeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(791, 455);
            this.Controls.Add(this.buttonActualiser);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.txtDemandeur);
            this.Controls.Add(this.label1);
            this.Name = "GDemandeur";
            this.ShowIcon = false;
            this.Text = "Gestion Demandeur";
            this.Load += new System.EventHandler(this.GDemandeur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDemandeur;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv;
        private ComponentFactory.Krypton.Toolkit.KryptonButton buttonAjouter;
        private ComponentFactory.Krypton.Toolkit.KryptonButton buttonSupprimer;
        private ComponentFactory.Krypton.Toolkit.KryptonButton buttonActualiser;
    }
}