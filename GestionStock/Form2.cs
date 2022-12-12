using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStock
{
    public partial class Form2 : Form
    {
        public string UserRole;
        public Form2()
        {
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Form activeForm = null;
        private void openChildForm(Form childForm) {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            panelChild.Controls.Add(childForm);
            panelChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListeAr listear = new ListeAr();
            listear.UserRole = UserRole;
            openChildForm(listear);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (UserRole == "UtilisateurC" || UserRole == "UtilisateurB" || UserRole == "UtilisateurA") {
                buttonGUsers.Visible = false;
            }
            this.WindowState = FormWindowState.Maximized;
        }

        private void buttonEntree_Click(object sender, EventArgs e)
        {
            Entree entree = new Entree();
            entree.UserRole = UserRole;
            openChildForm(entree);
        }

        private void buttonSortie_Click(object sender, EventArgs e)
        {
            Sortie sortie = new Sortie();
            sortie.UserRole = UserRole;
            openChildForm(sortie);
        }

        private void buttonGUsers_Click(object sender, EventArgs e)
        {
            GUsers g = new GUsers();
            g.ShowDialog();
        }

        private void buttonInventaire_Click(object sender, EventArgs e)
        {
            Inventaire inv = new Inventaire();
            openChildForm(inv);
        }
    }
}
