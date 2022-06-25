using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresWebModel
{
    public  class Lectura
    {
        private string nroMedidor;
        private DateTime Fecha;
        private string horaLectura;
        private string valorConsumo;
        private int compañia;
        private string  valor_lectura;

     
        public string compañias
        {
            get
            {
                string compañias = "";
                switch (compañia)
                {
                    case 1:
                        compañias = "CGE";
                        break;
                    case 2:
                        compañias = "Frontel";
                        break;
                    case 3:
                        compañias = "saesa";
                        break;
                }
                return compañias;
            }

        }

        public DateTime Fecha_lectura { get => Fecha; set => Fecha = value; }
        public string ValorConsumo { get => valorConsumo; set => valorConsumo = value; }
        public string HoraLectura { get => horaLectura; set => horaLectura = value; }
        public string NroMedidor { get => nroMedidor; set => nroMedidor = value; }
        public int Compañia { get => compañia; set => compañia = value; }
        public string Valor_lectura { get => valor_lectura; set => valor_lectura = value; }
    }


}
