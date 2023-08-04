using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Mostrar : Form
    {
        CECampo ce = new CECampo();
        CNCampo cn = new CNCampo();
        CDCampo cd = new CDCampo();
        



        public Mostrar()
        {
            InitializeComponent();
        }
        public void CargarDatos()
        {
            gridDatos.DataSource = cn.ObtenerDatos().Tables["table"];
        }

        private void Mostrar_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void chbBien_CheckedChanged(object sender, EventArgs e)
        {

        }

        //private void cbxOpciones_SelectedIndexChanged_1(object sender, EventArgs e)
        //{

        //    if (cbxOpciones.SelectedIndex == 0)
        //    {

        //        txtCarav.Visible = true;
        //        txtRaza.Visible = false;
        //        txtVacunas.Visible = false;
        //        txtOri.Visible = false;
        //        chbBien.Visible = false;
        //        chbPoco.Visible = false;
        //        chbBien.Visible = false;
        //        chbSi.Visible = false;
        //        chbNo.Visible = false;
        //        chbMacho.Visible = false;
        //        chbHembra.Visible = false;

        //        ce.Filtro = txtCarav.Text.ToString();
                
        //        ce.Columna = cbxOpciones.Items[0].ToString();


        //    }
        //    else if (cbxOpciones.SelectedIndex == 1)
        //    {

        //        txtCarav.Visible = false;
        //        txtOri.Visible = true;
        //        txtRaza.Visible = false;
        //        txtVacunas.Visible = false;
        //        chbBien.Visible = false;
        //        chbPoco.Visible = false;
        //        chbBien.Visible = false;
        //        chbSi.Visible = false;
        //        chbNo.Visible = false;
        //        chbMacho.Visible = false;
        //        chbHembra.Visible = false;

        //        ce.Filtro = txtOri.Text.ToString();
                
        //        ce.Columna = cbxOpciones.Items[1].ToString();


        //    }
        //    else if (cbxOpciones.SelectedIndex == 2)
        //    {

        //        txtCarav.Visible = false;
        //        txtRaza.Visible = true;
        //        txtVacunas.Visible = false;
        //        txtOri.Visible = false;
        //        chbBien.Visible = false;
        //        chbPoco.Visible = false;
        //        chbBien.Visible = false;
        //        chbSi.Visible = false;
        //        chbNo.Visible = false;
        //        chbMacho.Visible = false;
        //        chbHembra.Visible = false;

        //        ce.Filtro = txtRaza.Text.ToString();
                
        //        ce.Columna = cbxOpciones.Items[2].ToString();

        //    }
        //    else if (cbxOpciones.SelectedIndex == 3)
        //    {

        //        txtCarav.Visible = false;
        //        chbSi.Visible = true;
        //        chbNo.Visible = true;
        //        txtRaza.Visible = false;
        //        txtVacunas.Visible = false;
        //        txtOri.Visible = false;
        //        chbBien.Visible = false;
        //        chbPoco.Visible = false;
        //        chbBien.Visible = false;
        //        chbMacho.Visible = false;
        //        chbHembra.Visible = false;

        //        if (chbSi.Checked)
        //            ce.Filtro = "Si";
        //        if (chbNo.Checked)
        //            ce.Filtro = "No";
                
        //        ce.Columna = cbxOpciones.Items[3].ToString();


        //    }
        //    else if (cbxOpciones.SelectedIndex == 4)
        //    {

        //        txtCarav.Visible = false;
        //        chbMacho.Visible = true;
        //        chbHembra.Visible = true;
        //        txtRaza.Visible = false;
        //        txtVacunas.Visible = false;
        //        txtOri.Visible = false;
        //        chbBien.Visible = false;
        //        chbPoco.Visible = false;
        //        chbBien.Visible = false;
        //        chbSi.Visible = false;
        //        chbNo.Visible = false;

        //        if (chbMacho.Checked)
        //            ce.Filtro = "Macho";
        //        if (chbHembra.Checked)
        //            ce.Filtro = "Hembra";
               
        //        ce.Columna = cbxOpciones.Items[4].ToString();

        //    }
        //    else if (cbxOpciones.SelectedIndex == 5)
        //    {

        //        txtCarav.Visible = false;
        //        chbSi.Visible = true;
        //        chbNo.Visible = true;
        //        txtRaza.Visible = false;
        //        txtVacunas.Visible = false;
        //        txtOri.Visible = false;
        //        chbBien.Visible = false;
        //        chbPoco.Visible = false;
        //        chbBien.Visible = false;
        //        chbMacho.Visible = false;
        //        chbHembra.Visible = false;

        //        if (chbSi.Checked)
        //            ce.Filtro = "Si";
        //        if (chbNo.Checked)
        //            ce.Filtro = "No";
                
        //        ce.Columna = cbxOpciones.Items[5].ToString();

        //    }
        //    else if (cbxOpciones.SelectedIndex == 6)
        //    {

        //        txtCarav.Visible = false;
        //        chbSi.Visible = true;
        //        chbNo.Visible = true;
        //        txtRaza.Visible = false;
        //        txtVacunas.Visible = false;
        //        txtOri.Visible = false;
        //        chbBien.Visible = false;
        //        chbPoco.Visible = false;
        //        chbBien.Visible = false;
        //        chbMacho.Visible = false;
        //        chbHembra.Visible = false;

        //        if (chbSi.Checked)
        //            ce.Filtro = "Si";
        //        if (chbNo.Checked)
        //            ce.Filtro = "No";
                
        //        ce.Columna = cbxOpciones.Items[6].ToString();

        //    }
        //    else if (cbxOpciones.SelectedIndex == 7)
        //    {

        //        txtCarav.Visible = false;
        //        chbSi.Visible = true;
        //        chbNo.Visible = true;
        //        txtRaza.Visible = false;
        //        txtVacunas.Visible = false;
        //        txtOri.Visible = false;
        //        chbBien.Visible = false;
        //        chbPoco.Visible = false;
        //        chbBien.Visible = false;
        //        chbMacho.Visible = false;
        //        chbHembra.Visible = false;

        //        if (chbSi.Checked)
        //            ce.Filtro = "Si";
        //        if (chbNo.Checked)
        //            ce.Filtro = "No";
                
        //        ce.Columna = cbxOpciones.Items[7].ToString();

        //    }
        //    else if (cbxOpciones.SelectedIndex == 8)
        //    {
                
        //        txtCarav.Visible = false;
        //        txtVacunas.Visible = true;
        //        txtRaza.Visible = false;
        //        txtOri.Visible = false;
        //        chbBien.Visible = false;
        //        chbPoco.Visible = false;
        //        chbBien.Visible = false;
        //        chbSi.Visible = false;
        //        chbNo.Visible = false;
        //        chbMacho.Visible = false;
        //        chbHembra.Visible = false;
        //        ce.Filtro = txtVacunas.Text.ToString();
                
        //        ce.Columna = cbxOpciones.Items[8].ToString();


        //    }
        //    else if (cbxOpciones.SelectedIndex == 9)
        //    {
               
        //        txtCarav.Visible = false;
        //        chbSi.Visible = true;
        //        chbNo.Visible = true;
        //        txtRaza.Visible = false;
        //        txtVacunas.Visible = false;
        //        txtOri.Visible = false;
        //        chbBien.Visible = false;
        //        chbPoco.Visible = false;
        //        chbBien.Visible = false;
        //        chbMacho.Visible = false;
        //        chbHembra.Visible = false;

        //        if (chbSi.Checked)
        //            ce.Filtro = "Si";
        //        if (chbNo.Checked)
        //            ce.Filtro = "No";

        //        ce.Columna = cbxOpciones.Items[9].ToString();

        //    }
        //    else if (cbxOpciones.SelectedIndex == 10)
        //    {
                
        //        txtCarav.Visible = false;
        //        txtRaza.Visible = false;
        //        txtVacunas.Visible = false;
        //        txtOri.Visible = false;
        //        chbBien.Visible = false;
        //        chbPoco.Visible = false;
        //        chbBien.Visible = false;
        //        chbSi.Visible = false;
        //        chbNo.Visible = false;
        //        chbMacho.Visible = false;
        //        chbHembra.Visible = false;

        //        if (chbNada.Checked)
        //            ce.Filtro = "Nada";
        //        if (chbPoco.Checked)
        //            ce.Filtro = "Poco";
        //        if (chbBien.Checked)
        //            ce.Filtro = "Bien";
                
        //        ce.Columna = cbxOpciones.Items[10].ToString();
        //    }
            
        //}
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            label3.Text = ce.Filtro;
            label4.Text = ce.Columna;
        }
    }
}
