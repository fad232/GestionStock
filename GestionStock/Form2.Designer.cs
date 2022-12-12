
namespace GestionStock
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonInventaire = new System.Windows.Forms.Button();
            this.buttonGUsers = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSortie = new System.Windows.Forms.Button();
            this.buttonEntree = new System.Windows.Forms.Button();
            this.buttonListe = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChild = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.buttonInventaire);
            this.panel1.Controls.Add(this.buttonGUsers);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonSortie);
            this.panel1.Controls.Add(this.buttonEntree);
            this.panel1.Controls.Add(this.buttonListe);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 787);
            this.panel1.TabIndex = 0;
            // 
            // buttonInventaire
            // 
            this.buttonInventaire.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonInventaire.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonInventaire.FlatAppearance.BorderSize = 0;
            this.buttonInventaire.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonInventaire.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonInventaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInventaire.Image = ((System.Drawing.Image)(resources.GetObject("buttonInventaire.Image")));
            this.buttonInventaire.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInventaire.Location = new System.Drawing.Point(0, 365);
            this.buttonInventaire.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInventaire.Name = "buttonInventaire";
            this.buttonInventaire.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.buttonInventaire.Size = new System.Drawing.Size(257, 94);
            this.buttonInventaire.TabIndex = 8;
            this.buttonInventaire.Text = "Inventaire";
            this.buttonInventaire.UseVisualStyleBackColor = false;
            this.buttonInventaire.Click += new System.EventHandler(this.buttonInventaire_Click);
            // 
            // buttonGUsers
            // 
            this.buttonGUsers.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonGUsers.FlatAppearance.BorderSize = 0;
            this.buttonGUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGUsers.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGUsers.Location = new System.Drawing.Point(22, 610);
            this.buttonGUsers.Name = "buttonGUsers";
            this.buttonGUsers.Size = new System.Drawing.Size(200, 67);
            this.buttonGUsers.TabIndex = 7;
            this.buttonGUsers.Text = "Gerer les utilisateurs";
            this.buttonGUsers.UseVisualStyleBackColor = false;
            this.buttonGUsers.Click += new System.EventHandler(this.buttonGUsers_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(22, 719);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 1);
            this.panel3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Location = new System.Drawing.Point(82, 732);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quitter";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // buttonSortie
            // 
            this.buttonSortie.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonSortie.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSortie.FlatAppearance.BorderSize = 0;
            this.buttonSortie.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonSortie.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSortie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSortie.Image = ((System.Drawing.Image)(resources.GetObject("buttonSortie.Image")));
            this.buttonSortie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSortie.Location = new System.Drawing.Point(0, 271);
            this.buttonSortie.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSortie.Name = "buttonSortie";
            this.buttonSortie.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.buttonSortie.Size = new System.Drawing.Size(257, 94);
            this.buttonSortie.TabIndex = 3;
            this.buttonSortie.Text = "Sorties";
            this.buttonSortie.UseVisualStyleBackColor = false;
            this.buttonSortie.Click += new System.EventHandler(this.buttonSortie_Click);
            // 
            // buttonEntree
            // 
            this.buttonEntree.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonEntree.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEntree.FlatAppearance.BorderSize = 0;
            this.buttonEntree.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonEntree.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEntree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEntree.Image = ((System.Drawing.Image)(resources.GetObject("buttonEntree.Image")));
            this.buttonEntree.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEntree.Location = new System.Drawing.Point(0, 177);
            this.buttonEntree.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEntree.Name = "buttonEntree";
            this.buttonEntree.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.buttonEntree.Size = new System.Drawing.Size(257, 94);
            this.buttonEntree.TabIndex = 2;
            this.buttonEntree.Text = "Entrées";
            this.buttonEntree.UseVisualStyleBackColor = false;
            this.buttonEntree.Click += new System.EventHandler(this.buttonEntree_Click);
            // 
            // buttonListe
            // 
            this.buttonListe.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonListe.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonListe.FlatAppearance.BorderSize = 0;
            this.buttonListe.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonListe.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonListe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListe.Image = ((System.Drawing.Image)(resources.GetObject("buttonListe.Image")));
            this.buttonListe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonListe.Location = new System.Drawing.Point(0, 83);
            this.buttonListe.Margin = new System.Windows.Forms.Padding(4);
            this.buttonListe.Name = "buttonListe";
            this.buttonListe.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.buttonListe.Size = new System.Drawing.Size(257, 94);
            this.buttonListe.TabIndex = 1;
            this.buttonListe.Text = "Liste des articles";
            this.buttonListe.UseVisualStyleBackColor = false;
            this.buttonListe.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 83);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelChild
            // 
            this.panelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChild.Location = new System.Drawing.Point(257, 0);
            this.panelChild.MinimumSize = new System.Drawing.Size(1152, 787);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(1152, 787);
            this.panelChild.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1409, 787);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1112, 580);
            this.Name = "Form2";
            this.Text = "Saisie des données";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonListe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSortie;
        private System.Windows.Forms.Button buttonEntree;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelChild;
        private System.Windows.Forms.Button buttonGUsers;
        private System.Windows.Forms.Button buttonInventaire;
    }
}