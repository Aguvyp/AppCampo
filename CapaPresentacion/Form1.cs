using System;
using System.Windows.Forms;


namespace AppCampo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInrgesar_Click(object sender, EventArgs e)
        {
            Opciones op = new Opciones();
            op.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
