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
      ///  USUARIO_MODULO u_Modulo;
    
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
            //MessageBox.Show("llego a listar modulos");
            List<MODULO> ListarModulos = new LogNeg_Modulo().ListarTodos();
            foreach(var modulos in ListarModulos)
            {
                listBoxTodos.Items.Add(modulos.Cod_Modulo +" .- "+ modulos.Nom_Modulo);
            }
        }
        private void listarUsuarios()
        {
            List<USUARIO> listaUsuarios = new LogNeg_Usuario().ListarTodos();
            foreach (var usuario in listaUsuarios)
            {
                comboBox1.Items.Add(usuario.Nom_Usuario +"-"+ usuario.Apll_Paterno);
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
           //List<MODULO> ListarModulos = new LogNeg_Modulo().ListarTodos();
           // foreach (var modulos in ListarModulos)
           // {
           //     listBoxTodos.Items.Add(modulos.Cod_Modulo +" .- "+ modulos.Nom_Modulo);
           // }

            

        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {

            List<USUARIO> listaUsuarios = new LogNeg_Usuario().ListarTodos();
            foreach (var usuario in listaUsuarios)
            {
                comboBox1.Items.Add(usuario.Nom_Usuario + usuario.Apll_Paterno);
            }

        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            #region Verificar lista de permisos actuales
            if (string.IsNullOrEmpty(listBoxActual.Items.ToString()))
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
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        
    }
}
