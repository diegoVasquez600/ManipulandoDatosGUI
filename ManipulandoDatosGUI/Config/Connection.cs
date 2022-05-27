using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulandoDatosGUI.Config
{
    public class Connection
    {
        private readonly string connectionString;

        public Connection()
        {
            connectionString = "Data Source=.;Initial Catalog=ReservasDB;Integrated Security=True;Encrypt=False";
        }
        public SqlConnection AbrirConection()
        {
            SqlConnection conection = new(connectionString);
            if (conection.State == ConnectionState.Closed)
                conection.Open();
            return conection;
        }
        public SqlConnection CerrarConection()
        {
            SqlConnection conection = new(connectionString);
            if (conection.State == ConnectionState.Open)
                conection.Close();
            return conection;
        }
    }
}
