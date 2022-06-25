using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresWebModel
{
    public  class Lectura
    {
        private string num_medidor;
        private DateTime Fecha;
        private string horaLectura;
        private string valorConsumo;
        private string  valor_lectura;

     
        

        public DateTime Fecha_lectura { get => Fecha; set => Fecha = value; }
        public string ValorConsumo { get => valorConsumo; set => valorConsumo = value; }
        public string HoraLectura { get => horaLectura; set => horaLectura = value; }
       // public int Compañia { get => compañia; set => compañia = value; }
        public string Valor_lectura { get => valor_lectura; set => valor_lectura = value; }
        public string Num_medidor { get => num_medidor; set => num_medidor = value; }
    }


}
