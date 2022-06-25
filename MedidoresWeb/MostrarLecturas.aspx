<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarLecturas.aspx.cs" Inherits="MedidoresWeb.MostrarLecturas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contentido" runat="server">
<div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-danger text-white">
                    <h3>Ver Lecturas</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="num_medidorDdl">Filtrar por tipos de medidores</label>
                        <asp:DropDownList OnSelectedIndexChanged="num_medidorDdl_SelectedIndexChanged" runat="server" ID="num_medidorDdl" ></asp:DropDownList>
                        <asp:RadioButtonList runat="server" ID="num_medidorRbl">
                       <asp:ListItem Selected="True" Value="num_medidor" Text="numero medidor"></asp:ListItem>
                    </asp:RadioButtonList>
                    </div>

                    <asp:GridView CssClass="table table-hover table-bordered"
                        EmptyDataText="No hay Lecturas" ShowHeader="true"
                        AutoGenerateColumns="false" runat="server" ID="grillaLecturas">

                        <Columns>
                            <asp:BoundField DataField="num_medidor" HeaderText="Numero Medidor" />
                            <asp:BoundField DataField="fecha_lectura" HeaderText="Fecha Lectura" />
                            <asp:BoundField DataField="valor_lectura" HeaderText="Valor Lectura" />
                            <asp:BoundField DataField="valor_consumo" HeaderText="Valor Consumo" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
    </asp:Content>