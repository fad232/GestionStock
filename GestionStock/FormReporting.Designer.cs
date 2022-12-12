
namespace GestionStock
{
    partial class FormReporting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporting));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonStock = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSortie = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.buttonStock);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonSortie);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 787);
            this.panel1.TabIndex = 1;
            // 
            // buttonStock
            // 
            this.buttonStock.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStock.FlatAppearance.BorderSize = 0;
            this.buttonStock.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonStock.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStock.Image = ((System.Drawing.Image)(resources.GetObject("buttonStock.Image")));
            this.buttonStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStock.Location = new System.Drawing.Point(0, 202);
            this.buttonStock.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStock.Name = "buttonStock";
            this.buttonStock.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.buttonStock.Size = new System.Drawing.Size(320, 119);
            this.buttonStock.TabIndex = 7;
            this.buttonStock.Text = "Etat du stock";
            this.buttonStock.UseVisualStyleBackColor = false;
            this.buttonStock.Click += new System.EventHandler(this.buttonStock_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(22, 710);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 1);
            this.panel3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 734);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quitter";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonSortie
            // 
            this.buttonSortie.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonSortie.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSortie.FlatAppearance.BorderSize = 0;
            this.buttonSortie.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonSortie.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSortie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSortie.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSortie.Image = ((System.Drawing.Image)(resources.GetObject("buttonSortie.Image")));
            this.buttonSortie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSortie.Location = new System.Drawing.Point(0, 83);
            this.buttonSortie.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSortie.Name = "buttonSortie";
            this.buttonSortie.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.buttonSortie.Size = new System.Drawing.Size(320, 119);
            this.buttonSortie.TabIndex = 3;
            this.buttonSortie.Text = "Sorties";
            this.buttonSortie.UseVisualStyleBackColor = false;
            this.buttonSortie.Click += new System.EventHandler(this.buttonSortie_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 83);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelChild
            // 
            this.panelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChild.Location = new System.Drawing.Point(320, 0);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(1089, 787);
            this.panelChild.TabIndex = 2;
            // 
            // FormReporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1409, 787);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReporting";
            this.Text = "Reporting";
            this.Load += new System.EventHandler(this.FormReporting_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSortie;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelChild;
        private System.Windows.Forms.Button buttonStock;
    }
}