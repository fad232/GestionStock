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
    public partial class  Acceuil : Form
    {
        public string UserRole;
        public Acceuil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.UserRole = UserRole;
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormReporting formReporting = new FormReporting();
            formReporting.ShowDialog();
        }

        

        private void Acceuil_Load(object sender, EventArgs e)
        {

        }
    }
}
