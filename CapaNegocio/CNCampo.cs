using System.Data;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CNCampo
    {
        CDCampo cDCampo = new CDCampo();

        public void CrearAnimal(CECampo cE)
        {
            cDCampo.Crear(cE);
        }

        public void EditarAnimal(CECampo cE)
        {
            cDCampo.Editar(cE);
        }

        public void EliminarAnimal(CECampo cE)
        {
            cDCampo.Eliminar(cE);
        }

        public DataSet ObtenerDatos()
        {
            return cDCampo.Listar();
        }

    }
}