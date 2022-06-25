<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="IngresarLecturas.aspx.cs" Inherits="MedidoresWeb.IngresarLecturas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contentido" runat="server">

    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="mensaje">
                <asp:Label runat="server" ID="mensajeLbl" CssClass="text-success"></asp:Label>
            </div>
            <div class="card">
                <div class="card-header bg-dark text-white">
                    <h3>Agregar Lectura</h3>
                </div>

                <div class="card-body">
                    <div class="form-group">
                        <label for="medidorTxt">seleccione el numero del medidor</label>
                        <asp:DropDownList ID="num_medidorDdl" CssClass="form-group" runat="server" > </asp:DropDownList>
                    </div>

                    
                   <div>
                        <h3>calendario</h3>
                        <asp:Calendar ID="CalendarioCld" runat="server"></asp:Calendar>
                    </div>
                    
                     <div>
                        <h3>Hora de lectura</h3>
                        <asp:Label ID="horaLbl"  runat="server" ValidateRequest="true"></asp:Label>
                    </div> 

                    <div class="form-group">
                        <label for="companias_Ddl">Compañias</label>
                        <asp:DropDownList runat="server" ID="companiaDdl" CssClass="form-select">
              
                        </asp:DropDownList>
                    </div>

                    <div class="form-group">
                        <label for="valor_lectura">Ingrese la lectura </label>
                        <asp:TextBox runat="server" ID="valor_lecturaDdl" CssClass="form-group">
                    </asp:TextBox>

                    </div>

                    <div class="form-group">
                        <label for="v_consumoTxt">Ingrese el valor del consumo</label>
                        <asp:TextBox runat="server" ID="v_consumoTxt" CssClass="form-group">
                    </asp:TextBox>

                    </div>

                    <div class="form-group">
                        <asp:Button runat="server" ID="agregarLecturaBtn" OnClick="agregarLecturaBtn_Click"
                        Text="Agregar Lectura" CssClass="btn btn-primary" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
