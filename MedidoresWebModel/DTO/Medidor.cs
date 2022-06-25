using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresWebModel
{
    public class Medidor
    {
        private string nroMedidor;
        private string cod_medidor;
        private string tipo_medidor;

        public string NroMedidor { get => nroMedidor; set => nroMedidor = value; }
        public string Cod_medidor { get => cod_medidor; set => cod_medidor = value; }
        public string Tipo_medidor { get => tipo_medidor; set => tipo_medidor = value; }
    }
}
