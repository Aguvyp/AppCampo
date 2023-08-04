using CapaPresentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCampo
{
    public partial class Opciones : Form
    {
        public Opciones()
        {
            InitializeComponent();
        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            Carga ca = new Carga();
            ca.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modifico md = new Modifico();
            md.ShowDialog();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Mostrar m = new Mostrar();
            m.ShowDialog();
            //Abrir base de datos y mostrar
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar eli = new Eliminar();
            eli.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
