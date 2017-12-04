using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMatriculaCajas.Presentacion.HU03_Gestion_Postulante
{
    public partial class Form_Postulante : Form
    {
        public Form_Postulante()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Form_examen fex = new Form_examen();
            fex.ShowDialog();
        }
    }
}
