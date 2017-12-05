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

        #region listado de usuarios y modulos
        private void Form_GestionUsuario_Load(object sender, EventArgs e)
        {
            listarUsuarios();
            ListarModulos();
        }
        #region metodos de listado
        private void ListarModulos()
        {
            MessageBox.Show("llego a listar modulos");
            List<MODULO> ListarModulos = new LogNeg_Modulo().ListarTodos();
            foreach(var modulos in ListarModulos)
            {
                listBoxTodos.Items.Add(modulos.Cod_Modulo + modulos.Nom_Modulo);
            }
        }
        private void listarUsuarios()
        {
            List<USUARIO> listaUsuarios = new LogNeg_Usuario().ListarTodos();
            foreach (var usuario in listaUsuarios)
            {
                comboBox1.Items.Add(usuario.Nom_Usuario + usuario.Apll_Paterno);
            }          
        }
        #endregion
        #endregion

        #region Función de los botones        
      
        #region Agregar un modulo
        
        private void btnAgregarMod_Click(object sender, EventArgs e)
        {
            MoverItemsSeleccionados(listBoxTodos, listBoxActual);
        }
              
        private void MoverItemsSeleccionados(ListBox ListDE, ListBox ListA)
        {
           
            if (listBoxTodos.SelectedItems.Count > 0)
            {
                                
                    btnAgregarAllMod.Enabled = true;
                    btnAgregarMod.Enabled = true;
                    btnQuitarAllMod.Enabled = true;
                    btnQuitarMod.Enabled = true;

                
            }
            while (ListDE.SelectedItems.Count > 0)
            {
                string item = (string)ListDE.SelectedItems[0];
                ListA.Items.Add(item);
                ListDE.Items.Remove(item);
            }
        }
        #endregion
        #region quitar un modulo
        // Mover items a lista de todos
        private void btnQuitarMod_Click(object sender, EventArgs e)
        {
            if (listBoxTodos.SelectedItems.Count > 0)
            {
                btnAgregarAllMod.Enabled = true;
                btnAgregarMod.Enabled = true;
                btnQuitarAllMod.Enabled = true;
                btnQuitarMod.Enabled = true;
            }
            MoverItemsSeleccionados(listBoxActual, listBoxTodos);
           
        }
        #endregion    
        #region Boton Añade todos los modulos
           
        private void btnAgregarAllMod_Click(object sender, EventArgs e)
        {
            MoverTodosItems(listBoxTodos, listBoxActual);
        }
        private void MoverTodosItems(ListBox ListDE, ListBox ListA)
        {
            if (listBoxTodos.SelectedItems.Count>0)
            {
                MessageBox.Show("hecho");
                btnAgregarAllMod.Enabled = false;
                btnAgregarMod.Enabled = false;
                btnQuitarAllMod.Enabled = true;
                btnQuitarMod.Enabled = true;

                

            }
            ListA.Items.AddRange(ListDE.Items);
            ListDE.Items.Clear();
        }
        #endregion
        #region quitar todos los modulos
        // mover todos los items a lista de todos.
        private void btnQuitarAllMod_Click(object sender, EventArgs e)
        {
            if (listBoxActual.SelectedItems.Count>0)
            {
                    btnAgregarAllMod.Enabled = true;
                    btnAgregarMod.Enabled = true;
                    btnQuitarAllMod.Enabled = false;
                    btnQuitarMod.Enabled = false;
            }
            MoverTodosItems(listBoxActual, listBoxTodos);


        }
        #endregion
        
        #endregion



        private void BtnCancelar_Click(object sender, EventArgs e)
        {

            this.Close();

            List<MODULO> ListarModulos = new LogNeg_Modulo().ListarTodos();
            foreach (var modulos in ListarModulos)
            {
                listBoxTodos.Items.Add(modulos.Cod_Modulo + modulos.Nom_Modulo);
            }
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {

            List<USUARIO> listaUsuarios = new LogNeg_Usuario().ListarTodos();
            List<USUARIO_MODULO> listaUsuariosMod = new LogNeg_Usuario().ListarTodos();


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

            //if (!actualiza)
            //{

            //}
            //else
            { }


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
                Cod_USM = 0,
                Cod_Usuario = int.Parse(comboBox1.Text.Substring(0, 7)),
                Cod_Modulo = int.Parse(listBoxActual.Items.ToString().Substring(0, 2))
            };
        }
        private USUARIO_MODULO actualizar()
        {
            return new USUARIO_MODULO
            {
            };

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();

            }
        }
    }

