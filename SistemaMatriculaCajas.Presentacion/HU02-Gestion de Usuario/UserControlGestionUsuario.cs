using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMatriculaCajas.Presentacion.HU02_Gestion_de_Usuario
{
    public partial class UserControlGestionUsuario : UserControl
    {
        public UserControlGestionUsuario()
        {
            InitializeComponent();
        }

      

        private void btnNuwvoUsuario_Click_1(object sender, EventArgs e)
        {
            Form_NuevoUsuario nuevoUser = new Form_NuevoUsuario();
            nuevoUser.ShowDialog();
        }
    }
}
