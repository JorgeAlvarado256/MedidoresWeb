using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresWebModel.DAL
{
    public class LecturaDALObjetos : ILecturaDAL
    {
        private static List<Lectura> lecturas = new List<Lectura>();
        

        public void AgregarLecturas(Lectura lectura)
        {
            lecturas.Add(lectura);
        }

        public List<Lectura> Filtrar_numMedidor(string num_medidor)
        {
            return lecturas.FindAll(f=> f.Num_medidor==num_medidor);
        }

        public List<Lectura> ObtenerLecturas()
        {
            return lecturas;
        }
    }
}
