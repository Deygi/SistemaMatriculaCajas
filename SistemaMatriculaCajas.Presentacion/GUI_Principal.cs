using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMatriculaCajas.Presentacion
{
    public partial class GUI_Principal : Form
    {
        public GUI_Principal()
        {
            InitializeComponent();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (sidemenu.Width >= 223)
            {
                logo.Location = new Point(7, 78);
                logo.Size = new Size(60, 60);
                sidemenu.Width = 67;
                userControlPrincipal1.Size = new Size(1338, 721);

            }
            else
            {
                logo.Location = new Point(54, 56);
                logo.Size = new Size(120, 127);
                sidemenu.Width = 223;
                // inicio1.Size = new Size(1338,721);
            }
        }

        private void btnGestUser_Click(object sender, EventArgs e)
        {
            userControlGestionUsuario2.BringToFront();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            userControlPrincipal1.BringToFront();
        }
    }
}
