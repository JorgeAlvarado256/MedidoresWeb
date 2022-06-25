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
    public partial class MostrarLecturas : System.Web.UI.Page
    {
        private ILecturaDAL lecturaDAL = new LecturaDALObjetos();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarGrilla();
            }

        }

        private void cargarGrilla(List<Lectura> filtrada)
        { 
            this.grillaLecturas.DataSource = filtrada;
            this.grillaLecturas.DataBind();
        }

        private void cargarGrilla()
        {
            List<Lectura> lecturas = lecturaDAL.ObtenerLecturas();
            this.grillaLecturas.DataSource = lecturas;
            this.grillaLecturas.DataBind();
        }

        protected void num_medidorDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.num_medidorRbl.SelectedItem != null)
            {

                string num_medidor = this.num_medidorDdl.SelectedItem.Value;
                List<Lectura> filtrada = lecturaDAL.Filtrar_numMedidor(num_medidor);
                cargarGrilla(filtrada);
            }
        }

    }
}