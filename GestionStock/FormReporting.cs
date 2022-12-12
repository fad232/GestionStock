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
    public partial class FormReporting : Form
    {
        public FormReporting()
        {
            InitializeComponent();
        }

        private void FormReporting_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
        Form activeForm = null;
        private void openChildForm(Form childForm)
        {
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

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSortie_Click(object sender, EventArgs e)
        {
            SortieReport sortie = new SortieReport();
            openChildForm(sortie);
        }

        private void buttonStock_Click(object sender, EventArgs e)
        {
            StockReport stock = new StockReport();
            openChildForm(stock);
        }
    }
}
