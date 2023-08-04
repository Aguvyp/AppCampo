using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCampo;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Modifico : Form
    {
        CNCampo cn = new CNCampo();
        CECampo ce = new CECampo();
        CDCampo cd = new CDCampo();
        Carga c = new Carga();
        string indice = null;
        public Modifico()
        {
            InitializeComponent();
        }

        private void Modifico_Load(object sender, EventArgs e)
        {
            gridDatos.DataSource = cn.ObtenerDatos().Tables["table"];
        }

        private void gridDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = gridDatos.CurrentRow.Cells["Caravana"].Value.ToString();
            ce.Caravana = indice;
            lblprueba.Text = indice;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(indice == ce.Caravana)
            {
                ce.Vacunas = txtVacunas.Text;
                ce.Raza = txtRaza.Text;
                ce.Origen = txtOrigen.Text;
                if (rbtHembra.Checked)
                    ce.Sexo = "Hembra";
                else
                    ce.Sexo = "Macho";
                if (rbtDesSi.Checked)
                    ce.Destetado = "Si";
                else
                    ce.Destetado = "No";
                if (rbtCapSi.Checked)
                    ce.Capado = "Si";
                else
                    ce.Capado = "No";
                if (rbtSi.Checked)
                    ce.Sangrado = "Si";
                else
                    ce.Sangrado = "No";
                if (rbtBien.Checked)
                    ce.Dientes = "Bien";
                else if (rbtPoco.Checked)
                    ce.Dientes = "Poco";
                else
                    ce.Dientes = "Nada";
                if (rbtInseNo.Checked)
                    ce.Inseminada = "No";
                else
                    ce.Inseminada = "Si";
                if (rbtPreSi.Checked)
                    ce.Preñada = "Si";
                else
                    ce.Preñada = "No";

                cn.EditarAnimal(ce);
                gridDatos.DataSource = cn.ObtenerDatos().Tables["table"];
                c.LimpiarForm();
                
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
