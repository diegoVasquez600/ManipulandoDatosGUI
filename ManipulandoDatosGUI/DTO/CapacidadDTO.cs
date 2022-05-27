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
        private List<Informacion> informacionList;
        private Informacion informacion;
        public CapacidadDTO()
        {
            capacidadDAO = new();
            informacionList = new();
        }

        public void CargarCapacidadVuelo(int capacidad)
        {
            try
            {
                for (int i = 0; i < capacidad; i++)
                {
                    capacidadDAO.CargarCapacidadVuelo();
                }
                MessageBox.Show($"Capacidad de {capacidad} vuelos se creo correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<Informacion> MostrarDsponibles()
        {
            try
            {
                var disponibles = capacidadDAO.MostrarDsponibles();
                for (int i = 0; i < disponibles.Rows.Count; i++)
                {
                    informacion = new();
                    informacion.IdInformacion = int.Parse(disponibles.Rows[i]["IdInFormacion"].ToString());
                    informacion.Nombre = disponibles.Rows[i]["Nombre"].ToString();
                    informacion.Fecha = DateTime.Parse(disponibles.Rows[i]["Fecha"].ToString());
                    informacionList.Add(informacion);
                }
                return informacionList.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return informacionList;
            }
        }
    }
}
