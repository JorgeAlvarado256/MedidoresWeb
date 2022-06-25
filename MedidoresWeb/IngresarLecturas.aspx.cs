using MedidoresWebModel;
using MedidoresWebModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidoresWeb
{
    public partial class IngresarLecturas : System.Web.UI.Page
    {
        private ILecturaDAL lecturaDAL = new LecturaDALObjetos();
        private IMedidorDAL medidorDAL =  new MedidorDALObjetos();
        public void Page_Load(object sender, EventArgs e)
        {
            List<Medidor> medidores = medidorDAL.ObtenerMedidores();
            this.num_medidorDdl.DataSource = medidores;
            this.num_medidorDdl.DataValueField = "num_medidor";
            this.num_medidorDdl.DataBind();
         }


        protected void agregarLecturaBtn_Click(object sender, EventArgs e)
        {

            string num_medidor = this.num_medidorDdl.SelectedValue;
            DateTime fecha_lectura = this.CalendarioCld.TodaysDate;
            string valor_consumo= this.v_consumoTxt.Text.Trim();
            string valor_lectura= this.valor_lecturaDdl.Text.Trim();

            List<Medidor> medidores = medidorDAL.ObtenerMedidores();
            Medidor medidor = medidores.Find(b => b.Num_medidor == this.num_medidorDdl.SelectedItem.Value);



            List<Lectura> lecturas = lecturaDAL.ObtenerLecturas();
            Lectura lectura = lecturas.Find(l => l.Num_medidor == this.num_medidorDdl.SelectedItem.Value);

            Lectura lectura1 = new Lectura()
          {
                Num_medidor = num_medidor,
                Fecha_lectura = fecha_lectura,
                Valor_lectura = valor_lectura,
                ValorConsumo = valor_consumo,
            };


           lecturaDAL.AgregarLecturas(lectura);
           this.mensajeLbl.Text = "Lectura  Ingresada Correctamente";
           Response.Redirect("MostrarLecturas.aspx");

        }
    }
}