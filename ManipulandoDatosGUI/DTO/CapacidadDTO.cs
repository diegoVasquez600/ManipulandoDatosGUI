using ManipulandoDatosGUI.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulandoDatosGUI.DTO
{
    public class CapacidadDTO
    {
        private readonly CapacidadDAO capacidadDAO;
        public CapacidadDTO()
        {
            capacidadDAO = new();
        }

        public void CargarCapacidadVuelo(int capacidad)
        {
            for (int i = 0; i < capacidad; i++)
            {
                capacidadDAO.CargarCapacidadVuelo();
            }
        }


    }
}
