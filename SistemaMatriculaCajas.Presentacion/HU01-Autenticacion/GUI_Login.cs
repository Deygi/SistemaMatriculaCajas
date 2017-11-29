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

namespace SistemaMatriculaCajas.Presentacion.HU01_Autenticacion
{
    public partial class GUI_Login : Form
    {


        public GUI_Login()
        {
            InitializeComponent();
        }
        //Metodos del Diagrama de col
        private void verificarUsuario()
        {
            USUARIO usuarioLogin = construirUsuario();
            USUARIO usuario;



            if ((usuario=new LogNeg_Usuario().consultar(usuarioLogin.Dni_Usuario))!=null)
            {
                if (usuario.Pass_Usuario==usuarioLogin.Pass_Usuario)
                {
                    MessageBox.Show("ingreso con exito");
                    //Redirecciona
                    new GUI_Principal().ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("contraseña erronea");
                }
            }
            else
            {
                MessageBox.Show("usuario no existe");
            }
        }

        private void listarUsuarios()
        {
            List<USUARIO> listaUsuarios = new LogNeg_Usuario().ListarTodos();
        //textBox1.Clear();
        //foreach (var usuario in listaUsuarios)
        //{
        //    textBox1.Text += usuario.Nom_Usuario + usuario.Apll_Paterno + "\n";
        //}
        }

        //Metodos de ayuda
        private USUARIO construirUsuario()
        {
            return new USUARIO
            {
                Dni_Usuario = txtDni_Usuario.Text,
                Pass_Usuario = txtPass_Usuario.Text
            };
        }

        private void BtonAceptar_Click(object sender, EventArgs e)
        {
            verificarUsuario();
        }

        private void BtonCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //eventos

    }
}
