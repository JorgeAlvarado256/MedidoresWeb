<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="IngresarMedidor.aspx.cs" Inherits="MedidoresWeb.IngresarMedidor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contentido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="mensaje">
                <asp:Label runat="server" ID="mensajeLbl" CssClass="text-success"></asp:Label>
            </div>
            <div class="card">
                <div class="card-header bg-dark text-white">
                    <h3>Agregar Medidor</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="num_medidorTxt">Ingrese nuevo medidor</label>
                        <asp:TextBox ID="num_medidorDdl" CssClass="form-group" runat="server"> </asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="cod_medidorTxt">Ingrese codigo medidor</label>
                        <asp:TextBox ID="cod_medidorDdl" CssClass="form-group" runat="server"> </asp:TextBox>
                    </div>

                        <div class="form-group">
                        <label for="tiposMedidorDdl">Tipos de medidores</label>
                        <asp:RadioButtonList runat="server" ID="tiposMedidorDdl">
                            <asp:ListItem Selected="True" Value="1" Text="inducción"></asp:ListItem>
                            <asp:ListItem Selected="True" Value="2" Text="electronicos"></asp:ListItem>
                        </asp:RadioButtonList>
                            </div>


                    <div class="form-group">
                        <asp:Button runat="server" ID="agregarMedidorBtn" OnClick="agregarMedidorBtn_Click"
                        Text="Agregar Medidor" CssClass="btn btn-primary" />
                    </div>

                </div>
            </div>
        </div>
    </div>

</asp:Content>
