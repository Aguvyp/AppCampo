using System;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;
using MySql.Data.MySqlClient;
using System.Runtime.ConstrainedExecution;
using CapaDatos;

namespace AppCampo
{
    public partial class Carga : Form
    {
        int contador;
        CNCampo cNCampo = new CNCampo();
        CECampo cE = new CECampo();
        public Carga()
        {
            InitializeComponent();
        }
       
        private void LblTot_Click(object sender, EventArgs e)
        {
            
            //mostrar cantidad animales
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            cE.Vacunas = txtVacunas.Text;
            cE.Caravana = txtCaravana.Text;
            cE.Raza = txtRaza.Text;
            cE.Origen = txtOrigen.Text;
            if (rbtHembra.Checked)
                cE.Sexo = "Hembra";
            else
                cE.Sexo = "Macho";
            if (rbtDesSi.Checked)
                cE.Destetado = "Si";
            else
                cE.Destetado = "No";
            if (rbtCapSi.Checked)
                cE.Capado = "Si";
            else
                cE.Capado = "No";
            if (rbtSi.Checked)
                cE.Sangrado = "Si";
            else
                cE.Sangrado = "No";
            if (rbtBien.Checked)
                cE.Dientes = "Bien";
            else if (rbtPoco.Checked)
                cE.Dientes = "Poco";
            else
                cE.Dientes = "Nada";
            if (rbtInseNo.Checked)
                cE.Inseminada = "No";
            else
                cE.Inseminada = "Si";
            if (rbtPreSi.Checked)
                cE.Preñada = "Si";
            else
                cE.Preñada = "No";
           
            contador++;
            lblTot.Text = contador.ToString();
            cNCampo.CrearAnimal(cE);
            gridDatos.DataSource = cNCampo.ObtenerDatos().Tables["tabla"];
            LimpiarForm();
            CargarDatos();
            
        }
        public void LimpiarForm()
        {
            txtCaravana.Text = string.Empty;
            txtRaza.Text = string.Empty;
            txtOrigen.Text = string.Empty;
            rbtHembra.Checked = false;
            rbtMacho.Checked = false;
            rbtDesSi.Checked = false;
            rbtDesNo.Checked = false;
            rbtCapNo.Checked = false;
            rbtCapSi.Checked = false;
            rbtBien.Checked = false;
            rbtPoco.Checked = false;
            rbtNada.Checked = false;
            rbtInseNo.Checked = false;
            rbtInseSi.Checked = false;
            rbtPreNo.Checked = false;
            rbtPreSi.Checked = false;
            rbtSi.Checked = false;
            rbtNo.Checked = false;
            txtVacunas.Text = string.Empty ;
            

        }


        private void cbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        public void CargarDatos()
        {
            gridDatos.DataSource = cNCampo.ObtenerDatos().Tables["table"];
        }
        private void Carga_Load(object sender, EventArgs e)
        {
            CargarDatos();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
