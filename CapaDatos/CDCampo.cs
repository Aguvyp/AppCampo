using static CapaDatos.CDCampo;
using MySql.Data.MySqlClient;
using CapaEntidad;
using System.Data;

namespace CapaDatos
{
    public class CDCampo
    {


        string cadenaconexion = "Server=127.0.0.1;User id=root;Password=Agu43766205;Port=3306;database=CRUD";


        public void Crear(CECampo ce)
        {

            //Abrimos coneccion
            MySqlConnection myConecction = new MySqlConnection(cadenaconexion);
            myConecction.Open();

            //Creamos la query
            string Query = "INSERT INTO Animales (Caravana, Origen, Raza, Sexo, Vacunas, Destetado, Preñada, Capado, Sangrado, Dientes, Inseminada) VALUES ('" + ce.Caravana + "','" + ce.Origen + "','" + ce.Raza + "','" + ce.Sexo + "','" + ce.Vacunas + "','" + ce.Destetado + "','" + ce.Preñada + "','" + ce.Capado + "','" + ce.Sangrado + "','" + ce.Dientes + "','" + ce.Inseminada + "');";

            //Creamos el objeto comando para ejecutar la query
            MySqlCommand myCommand = new MySqlCommand(Query, myConecction);
            myCommand.ExecuteNonQuery();
            myConecction.Close();
            MessageBox.Show("Registro creado");

        }

        public void Editar(CECampo cE)
        {
            //Abrimos coneccion
            MySqlConnection myConecction = new MySqlConnection(cadenaconexion);
            myConecction.Open();

            //Crear la query
            string Query = "UPDATE Animales SET Origen='" + cE.Origen + "', Raza='" + cE.Raza + "'," + " Sexo=" + "'" + cE.Sexo + "'," + "Vacunas=" + "'" + cE.Vacunas + "'," + "Destetado=" + "'" + cE.Destetado + "'," + "Preñada=" + "'" + cE.Preñada + "'," + "Capado=" + "'" + cE.Capado + "'," + "Sangrado=" + "'" + cE.Sangrado + "'," + "Dientes=" + "'" + cE.Dientes + "'," + "Inseminada=" + "'" + cE.Inseminada + "'" + "WHERE Caravana=" + "'" + cE.Caravana + "';";
            MySqlCommand myCommand = new MySqlCommand(Query, myConecction); 
            myCommand.ExecuteNonQuery();
            myConecction.Close();
            MessageBox.Show("Edicion completada");
        }

        public void Eliminar(CECampo Ce)
        {
            //Abrimos coneccion
            MySqlConnection myConecction = new MySqlConnection(cadenaconexion);
            myConecction.Open();

            //Crear la query
            string Query = "DELETE FROM Animales WHERE Caravana=" + "\"" + Ce.Caravana + "\";"; 
            MySqlCommand myCommand = new MySqlCommand(Query, myConecction);
            
            myCommand.ExecuteNonQuery();
            myConecction.Close();
            MessageBox.Show("Eliminacion completada");
        }

        public DataSet Listar()
        {
            //Abrimos coneccion
            MySqlConnection myConecction = new MySqlConnection(cadenaconexion);
            myConecction.Open();

            //Crear la query
            string Query = "SELECT * FROM Animales LIMIT 1000";

            //Crear adaptador que me sirve para poder adaptar la estructura de la basedata al visual
            MySqlDataAdapter Adaptador;
            DataSet dataSet = new DataSet();
            Adaptador = new MySqlDataAdapter(Query, myConecction);
            Adaptador.Fill(dataSet, "table");

            return dataSet;
        }

        public void Filtrar(CECampo Ce)
        {
            //Abrimos coneccion
            MySqlConnection myConecction = new MySqlConnection(cadenaconexion);
            myConecction.Open();

            //Crear la query
            string Query = "SELECT * FROM Animales WHERE " + Ce.Columna + "= '" + Ce.Filtro + "';";
            MySqlCommand myCommand = new MySqlCommand(Query, myConecction);
            myCommand.ExecuteNonQuery();
            myConecction.Close();
        }

    }
    
}