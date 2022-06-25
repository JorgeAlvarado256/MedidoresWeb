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
    public partial class VerMedidores : System.Web.UI.Page
    {
        private IMedidorDAL medidorDAL = new MedidorDALObjetos();
        private ILecturaDAL lecturaDAL = new LecturaDALObjetos();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Medidor> medidor = medidorDAL.ObtenerMedidores();
                
            }

        }


        private void cargarGrilla(List<Medidor> filtrada)
        {
            this.grillaMedidores.DataSource = filtrada;
            this.grillaMedidores.DataBind();
        }

      private void cargarGrilla()
        {
            List<Medidor> medidores = medidorDAL.ObtenerMedidores();
            this.grillaMedidores.DataSource = medidores;
            this.grillaMedidores.DataBind();
        }
      
      
        protected void tipo_medidorDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tipo_medidor.SelectedItem != null)
            {
                string tipo_medidor = this.tipo_medidor.SelectedItem.Value;
                List<Medidor> filtrada = medidorDAL.Filtrar_tipoMedidor(tipo_medidor);
                cargarGrilla(filtrada);
            }
        }

    }
}