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
        USUARIO_MODULO u_Modul;

        public Form_GestionUsuario()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form_GestionUsuario_Load(object sender, EventArgs e)
        {

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
            List<MODULO> Listarmodulos = new List<MODULO>.listarTodos();
        }
    }
}
