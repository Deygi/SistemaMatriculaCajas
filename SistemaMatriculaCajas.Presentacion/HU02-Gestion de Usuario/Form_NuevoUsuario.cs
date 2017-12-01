using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaMatriculaCajas.Entidades;
using SistemaMatriculaCajas.LogicaNegocio;

namespace SistemaMatriculaCajas.Presentacion.HU02_Gestion_de_Usuario
{
    public partial class Form_NuevoUsuario : Form
    {
        public Form_NuevoUsuario()
        {
            InitializeComponent();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            #region texto predefinido
            TxtboxCodigo.Text = "Codigo";
            TxtboxCodigo.Select();
            TxtboxPass.Text = "Password";
            TxtboxApPat.Text = "Apellido Paterno";
            txtboxApMat.Text = " Apellidos Materno";
            TxtboxNom.Text = "Nombres";
            TxtboxDni.Text = "Dni";
            #endregion

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            #region Verificar contenedores
            if (string.IsNullOrEmpty(TxtboxCodigo.Text))
            {
                errorProvider1.SetError(TxtboxCodigo, "Campo requerido");
                return;
            }
            else
            {
                errorProvider1.Clear();
                return;
            }

            if (string.IsNullOrEmpty(TxtboxApPat.Text))
            {
                errorProvider1.SetError(TxtboxApPat, "Campo requerido");
                return;
            }
            else
            {
                errorProvider1.Clear();
                return;
            }

            if (string.IsNullOrEmpty(txtboxApMat.Text))
            {
                errorProvider1.SetError(txtboxApMat, "Campo requerido");
                return;
            }
            else
            {
                errorProvider1.Clear();
                return;
            }

            if (string.IsNullOrEmpty(TxtboxPass.Text))
            {
                errorProvider1.SetError(TxtboxPass, "Campo requerido");
                return;
            }
            else
            {
                errorProvider1.Clear();
                return;
            }

            if (string.IsNullOrEmpty(TxtboxNom.Text))
            {
                errorProvider1.SetError(TxtboxNom, "Campo requerido");
                return;
            }
            else
            {
                errorProvider1.Clear();
                return;
            }

            if (string.IsNullOrEmpty(TxtboxDni.Text))
            {
                errorProvider1.SetError(TxtboxDni, "Campo requerido");
                return;
            }
            else
            {
                errorProvider1.Clear();
                return;
            }

            #endregion

            USUARIO usuarioNew = registrarUsuario();
            USUARIO usuario;

            if ((usuario = new LogNeg_Usuario().consultar(usuarioNew.Dni_Usuario)) != null)
            {
                if (usuario.Pass_Usuario != usuarioNew.Pass_Usuario)
                {
                    registrarUsuario();
                    MessageBox.Show("ingreso con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Fallo al registro", "Warming", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Usuario ya registrado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private USUARIO registrarUsuario()
        {
            return new USUARIO
            {
                Cod_Usuario = int.Parse(TxtboxCodigo.Text),
                Nom_Usuario = TxtboxNom.Text,
                Apll_Paterno = TxtboxApPat.Text,
                Apll_Materno = txtboxApMat.Text,
                Dni_Usuario = TxtboxDni.Text,
                Pass_Usuario = TxtboxPass.Text
            };
        }
    }
}
