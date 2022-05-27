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
            }
        }
    }
}
