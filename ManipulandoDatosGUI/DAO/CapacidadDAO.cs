using ManipulandoDatosGUI.Config;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulandoDatosGUI.DAO
{
    public class CapacidadDAO
    {
        private readonly Connection connection;
        private SqlDataReader reader;
        private SqlCommand command;

        public CapacidadDAO()
        {
            connection = new();
            command = new();
        }

        public void CargarCapacidadVuelo()
        {
            try
            {
                command.Connection = connection.AbrirConection();
                command.CommandText = "INSERT INTO INFORMACION values (0,'',GETDATE())";
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                connection.CerrarConection();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return;
            }
        }

        public DataTable MostrarDsponibles()
        {
            DataTable dt = new DataTable();
            try
            {
                command.Connection = connection.AbrirConection();
                command.CommandText = "SELECT * FROM Informacion WHERE Estado = 0";
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();
                dt.Load(reader);
                reader.Close();
                connection.CerrarConection();
                return dt;
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
                return dt;
            }
        }
    }
}
