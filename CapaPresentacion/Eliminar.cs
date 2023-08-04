using CapaNegocio;
using CapaEntidad;
using CapaDatos;
using System.Windows.Forms;

namespace AppCampo
{
    public partial class Eliminar : Form
    {
        CNCampo cncampo = new CNCampo();
        CDCampo cd = new CDCampo();
        CECampo cE = new CECampo();
        
        

        public Eliminar()
        {
            InitializeComponent();
            
            
        }
        public void CargarDatos()
        {
            gridDatos.DataSource = cncampo.ObtenerDatos().Tables["table"];
        }

        private void gridDatos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string selectedData = gridDatos.CurrentRow.Cells["Caravana"].Value.ToString();
            if (selectedData != null)
            {
                if (MessageBox.Show("¿Deseas Eliminar el Registro?", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                { // Eliminar la fila del GridView
                    cE.Caravana = selectedData;
                    cncampo.EliminarAnimal(cE);
                    CargarDatos();
                }
            }
        }

        private void Eliminar_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
