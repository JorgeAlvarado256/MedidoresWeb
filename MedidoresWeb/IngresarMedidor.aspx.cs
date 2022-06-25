using MedidoresWebModel;
using MedidoresWebModel.DAL;
using System;
using System.Collections.Generic;

namespace MedidoresWeb
{
    public partial class IngresarMedidor : System.Web.UI.Page
    {
        private IMedidorDAL medidorDAL = new MedidorDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void agregarMedidorBtn_Click(object sender, EventArgs e)
        {
            string nroMedidor = this.num_medidorDdl.Text.Trim();
            string cod_medidor = this.cod_medidorDdl.Text.Trim();  
            string  tipo_medidor = this.tiposMedidorDdl.Text.Trim();

            List<Medidor> medidores = medidorDAL.ObtenerMedidores();
#pragma warning disable CS0019 // El operador '==' no se puede aplicar a operandos del tipo 'int' y 'string'
            Medidor medidor = medidores.Find(b => b.Tipo_medidor == this.tiposMedidorDdl.SelectedItem.Value);
#pragma warning restore CS0019 // El operador '==' no se puede aplicar a operandos del tipo 'int' y 'string'


#pragma warning disable CS0029 // No se puede convertir implícitamente el tipo 'string' en 'int'
           Medidor medidor_ = new Medidor()
            {
                Num_medidor = nroMedidor,
                Cod_medidor = cod_medidor,
                Tipo_medidor = tipo_medidor,
            };
          
#pragma warning restore CS0029 // No se puede convertir implícitamente el tipo 'string' en 'int'
            

            medidorDAL.AgregarMedidores(medidor_);
            this.mensajeLbl.Text = "Medidor ingresado correctamente";
            Response.Redirect("verMedidores.aspx");


        }
    }
}
