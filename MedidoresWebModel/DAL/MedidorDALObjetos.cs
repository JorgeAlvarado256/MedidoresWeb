using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresWebModel.DAL
{
    public class MedidorDALObjetos : IMedidorDAL
    {
        private static List<Medidor> medidores = new List<Medidor>();
        public void AgregarMedidores(Medidor medidor)
        {
            medidores.Add(medidor);
        }

      

        public List<Medidor> ObtenerMedidores()
        {
            return medidores;
        }


        public List<Medidor> Filtrar_tipoMedidor(string tipo_medidor)
        {
            return medidores.FindAll(m => m.Tipo_medidor == tipo_medidor);
        }

        public List<Medidor> Filtrar_numMedidor(string num_medidor)
        {
            return medidores.FindAll(m => m.NroMedidor == num_medidor);
        }
    }
}
