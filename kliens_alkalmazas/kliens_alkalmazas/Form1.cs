using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kliens_alkalmazas
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonKeszlet_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControlKeszlet userControlKeszlet = new UserControlKeszlet();
            panel1.Controls.Add(userControlKeszlet);
            userControlKeszlet.Dock = DockStyle.Fill;

        }

        private void buttonRendeles_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControlRendeles userControlRendeles = new UserControlRendeles();
            panel1.Controls.Add(userControlRendeles);
            userControlRendeles.Dock = DockStyle.Fill;

        }
    }
}
