<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerMedidores.aspx.cs" Inherits="MedidoresWeb.VerMedidores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contentido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-danger text-white">
                    <h3>Ver Medidores</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="tipo_medidorDdl">Filtrar por tipos de medidores</label>
                        <asp:DropDownList OnSelectedIndexChanged="tipo_medidorDdl_SelectedIndexChanged" runat="server" ID="tipo_medidor"></asp:DropDownList>
                        <asp:RadioButtonList runat="server" ID="tipo_medidorRbl">
                       <asp:ListItem Selected="True" Value="1" Text="inducción"></asp:ListItem>
                      <asp:ListItem Selected="True" Value="2" Text="electronicos"></asp:ListItem>
                    </asp:RadioButtonList>
                    </div>

                    <asp:GridView CssClass="table table-hover table-bordered"
                        EmptyDataText="No hay Medidores" ShowHeader="true"
                        AutoGenerateColumns="false" runat="server" ID="grillaMedidores">

                        <Columns>
                            <asp:BoundField DataField="num_medidor" HeaderText="Numero Medidor" />
                            <asp:BoundField DataField="cod_medidor" HeaderText="Codigo Medidor" />
                            <asp:BoundField DataField="tipoMedidor" HeaderText="Tipos de Medidor" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
