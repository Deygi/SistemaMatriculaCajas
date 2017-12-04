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
    public partial class Form_GestionUsuario : Form
    {
        USUARIO_MODULO u_Modulo;
        private bool actualiza = false;

        public Form_GestionUsuario()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form_GestionUsuario_Load(object sender, EventArgs e)
        {
            listarUsuarios();
            ListarModulos();

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region Función de los botones        
        // Mover items selecionados de una lista a otra.
        private void MoverItemsSeleccionados(ListBox ListDE, ListBox ListA)
        {
            while (ListDE.SelectedItems.Count > 0)
            {
                string item = (string)ListDE.SelectedItems[0];
                ListA.Items.Add(item);
                ListDE.Items.Remove(item);
            }
            SetButtonsEditable();
        }
        // Mover items selecionados o lista actual.
        private void btnAgregarMod_Click(object sender, EventArgs e)
        {
            MoverItemsSeleccionados(listBoxTodos, listBoxActual);
        }
        // Mover items a lista de todos
        private void btnQuitarMod_Click(object sender, EventArgs e)
        {
            MoverItemsSeleccionados(listBoxActual, listBoxTodos);
        }
        // Mover todos los items de una lista a otra.
        private void MoverTodosItems(ListBox ListDE, ListBox ListA)
        {
            ListA.Items.AddRange(ListDE.Items);
            ListDE.Items.Clear();
            SetButtonsEditable();
        }
        // move todos los items a lista actual.       
        private void btnAgregarAllMod_Click(object sender, EventArgs e)
        {
            MoverTodosItems(listBoxTodos, listBoxActual);
        }
        // mover todos los items a lista de todos.
        private void btnQuitarAllMod_Click(object sender, EventArgs e)
        {
            MoverTodosItems(listBoxActual, listBoxTodos);
        }
        // Habilitar botones.
        private void SetButtonsEditable()
        {
            btnAgregarMod.Enabled = (listBoxTodos.SelectedItems.Count > 0);
            btnAgregarAllMod.Enabled = (listBoxTodos.Items.Count > 0);
            btnQuitarMod.Enabled = (listBoxActual.SelectedItems.Count > 0);
            btnAgregarAllMod.Enabled = (listBoxActual.Items.Count > 0);
        }
        #endregion
        private void ListarModulos()
        {
            List<MODULO> ListarModulos = new LogNeg_Modulo().ListarTodos();
            foreach (var modulos in ListarModulos)
            {
                listBoxTodos.Items.Add(modulos.Cod_Modulo + modulos.Nom_Modulo);
            }

            
        }
        private void listarUsuarios()
        {
            List<USUARIO_MODULO> listaUsuarios = new LogNeg_Usuario().ListarTodos();
            foreach (var usuario in listaUsuarios)
            {
                comboBox1.Items.Add(usuario.Nom_Usuario + usuario.Apll_Paterno);
            }
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            #region Verificar lista de permisos actuales
            int ContaModulos = listBoxActual.Items.Count;

            if (ContaModulos<=0)
            {
                errorProvider1.SetError(listBoxActual, "No esta selecciondado ningun permiso");
                return;
            }
            else
            {
                errorProvider1.Clear();
                return;
            }
            #endregion

            USUARIO_MODULO umoduloNew = registrar();
            USUARIO_MODULO umodulo;
                        
            if (!actualiza)
            {
                if ((umodulo = new LogNeg_UsuariosModulo().registrar(umodulo)) != null)
                {
                    if (umodulo.Cod_Modulo != umoduloNew.Cod_Modulo)
                    {
                        registrar();
                        MessageBox.Show("Registro con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Modulo ya registrado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Fallo al registro", "¡Warming!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if ((umodulo = new LogNeg_UsuariosModulo().actualizar(umoduloNew)) != null)
                {
                    if (umodulo.Cod_Modulo != umoduloNew.Cod_Modulo)
                    {
                        registrar();
                        MessageBox.Show("Actualización exitosa", "Información", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Modulo ya registrado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Fallo al actualizar", "¡Warming!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private USUARIO_MODULO registrar()
        {
            return new USUARIO_MODULO
            {
                Cod_USM = void,
                Cod_Usuario = int.Parse(comboBox1.Text.Substring(0, 7)),
                Cod_Modulo = int.Parse(listBoxActual.Items.ToString().Substring(0, 2))
            };
        }
        private USUARIO_MODULO actualizar()
        {
            return new USUARIO_MODULO
            {
                
            }
        }
    }
}
