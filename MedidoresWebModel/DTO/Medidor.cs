using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresWebModel
{
    public class Medidor
    {
        private string num_medidor;
        private string cod_medidor;
        private string tipo_medidor;

       
        public string Cod_medidor { get => cod_medidor; set => cod_medidor = value; }
        public string Tipo_medidor { get => tipo_medidor; set => tipo_medidor = value; }
        public string Num_medidor { get => num_medidor; set => num_medidor = value; }
    }
}
