
namespace GestionStock
{
    partial class GUsers
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
            this.buttonActualiser = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.buttonSupprimer = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.buttonAjouter = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgv = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonModifier = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dataSet1 = new GestionStock.DataSet1();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new GestionStock.DataSet1TableAdapters.UserTableAdapter();
            this.tableAdapterManager = new GestionStock.DataSet1TableAdapters.TableAdapterManager();
            this.userRoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userRoleTableAdapter = new GestionStock.DataSet1TableAdapters.UserRoleTableAdapter();
            this.txtRole = new MetroFramework.Controls.MetroComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonActualiser
            // 
            this.buttonActualiser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonActualiser.Location = new System.Drawing.Point(925, 428);
            this.buttonActualiser.Name = "buttonActualiser";
            this.buttonActualiser.Size = new System.Drawing.Size(199, 34);
            this.buttonActualiser.TabIndex = 38;
            this.buttonActualiser.Values.Text = "Actualiser";
            this.buttonActualiser.Click += new System.EventHandler(this.buttonActualiser_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSupprimer.Location = new System.Drawing.Point(580, 428);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(199, 34);
            this.buttonSupprimer.TabIndex = 37;
            this.buttonSupprimer.Values.Text = "Supprimer";
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAjouter.Location = new System.Drawing.Point(44, 39);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(197, 34);
            this.buttonAjouter.TabIndex = 36;
            this.buttonAjouter.Values.Text = "Ajouter";
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(580, 152);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(544, 217);
            this.dgv.TabIndex = 35;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // txtUser
            // 
            this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(212, 154);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(296, 34);
            this.txtUser.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 33;
            this.label1.Text = "User ID";
            // 
            // txtMdp
            // 
            this.txtMdp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMdp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMdp.Location = new System.Drawing.Point(212, 244);
            this.txtMdp.Multiline = true;
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(296, 34);
            this.txtMdp.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 23);
            this.label2.TabIndex = 39;
            this.label2.Text = "Mot de passe";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 23);
            this.label3.TabIndex = 41;
            this.label3.Text = "Role";
            // 
            // buttonModifier
            // 
            this.buttonModifier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonModifier.Location = new System.Drawing.Point(309, 39);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(199, 34);
            this.buttonModifier.TabIndex = 43;
            this.buttonModifier.Values.Text = "Modifier";
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.dataSet1;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassementTableAdapter = null;
            this.tableAdapterManager.DemandeurTableAdapter = null;
            this.tableAdapterManager.FamilleTableAdapter = null;
            this.tableAdapterManager.FournisseurTableAdapter = null;
            this.tableAdapterManager.MotifTableAdapter = null;
            this.tableAdapterManager.SousFamilleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestionStock.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserRoleTableAdapter = null;
            this.tableAdapterManager.UserTableAdapter = this.userTableAdapter;
            // 
            // userRoleBindingSource
            // 
            this.userRoleBindingSource.DataMember = "UserRole";
            this.userRoleBindingSource.DataSource = this.dataSet1;
            // 
            // userRoleTableAdapter
            // 
            this.userRoleTableAdapter.ClearBeforeFill = true;
            // 
            // txtRole
            // 
            this.txtRole.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRole.DataSource = this.userRoleBindingSource;
            this.txtRole.DisplayMember = "Role";
            this.txtRole.FormattingEnabled = true;
            this.txtRole.ItemHeight = 24;
            this.txtRole.Location = new System.Drawing.Point(215, 338);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(300, 30);
            this.txtRole.TabIndex = 43;
            this.txtRole.UseSelectable = true;
            this.txtRole.ValueMember = "Id";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(416, 23);
            this.label4.TabIndex = 44;
            this.label4.Text = "Consultant : Accès à reporting seulement";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 496);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(521, 23);
            this.label5.TabIndex = 45;
            this.label5.Text = "Utilisateur C : Accès à \"Ajouter\" , \"Modifier\" seulement";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 561);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(773, 23);
            this.label6.TabIndex = 46;
            this.label6.Text = "Utilisateur B : Accès à \"Ajouter\" , \"Modifier\" et gestion de demandeurs , Motif ," +
    " ....";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 626);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(707, 23);
            this.label7.TabIndex = 47;
            this.label7.Text = "Utilisateur A : Accès à toutes les fonctionnalités sauf la gestion des Users";
            // 
            // GUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1284, 669);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonActualiser);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label1);
            this.Name = "GUsers";
            this.ShowIcon = false;
            this.Text = "Gestion Utilisateurs";
            this.Load += new System.EventHandler(this.GUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton buttonActualiser;
        private ComponentFactory.Krypton.Toolkit.KryptonButton buttonSupprimer;
        private ComponentFactory.Krypton.Toolkit.KryptonButton buttonAjouter;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton buttonModifier;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private DataSet1TableAdapters.UserTableAdapter userTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource userRoleBindingSource;
        private DataSet1TableAdapters.UserRoleTableAdapter userRoleTableAdapter;
        private MetroFramework.Controls.MetroComboBox txtRole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}