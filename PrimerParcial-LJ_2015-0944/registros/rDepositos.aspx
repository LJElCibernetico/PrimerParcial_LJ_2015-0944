<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="rDepositos.aspx.cs" Inherits="PrimerParcial_LJ_2015_0944.registros.rDepositos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <label for="TextBoxDepositoID">ID</label>
    <div class="form-row">
        <div class="form-group col-md-1">
            <asp:TextBox TextMode="Number" class="form-control" ID="TextBoxDepositoID" runat="server" placeholder="ID"></asp:TextBox>
        </div>
        <div class="btn-group col-md-1">
            <asp:Button class="btn btn-primary" ID="ButtonBuscar" runat="server" Text="Buscar" OnClick="ButtonBuscar_Click" />
        </div>
    </div>
    
    <label for="CuentaDropDownList">Cuenta</label>
    <div class="row">
        <div class="form-group col-md-7"">
            <div class="form-group col-md-7">
                <asp:DropDownList ID="CuentaDropDownList" CssClass="form-control" runat="server">
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        <asp:RequiredFieldValidator ForeColor="red" ID="RequiredFieldValidator" runat="server" Display="Dynamic" ControlToValidate="CuentaDropDownList" Font-Bold="True" ErrorMessage="No puede dejar la cuenta vacia"></asp:RequiredFieldValidator>
        <div class="form-group col-md-7">
            <label for="TextBoxFecha">Fecha</label>
            <asp:TextBox TextMode="Date" class="form-control" ID="TextBoxFecha" runat="server" placeholder="Fecha"></asp:TextBox>
        </div>
        <asp:RequiredFieldValidator ForeColor="red" ID="RequiredFieldValidator1" runat="server" Display="Dynamic" ControlToValidate="TextBoxFecha" Font-Bold="True" ErrorMessage="No puede dejar la fecha vacia"></asp:RequiredFieldValidator>
        <div class="form-group col-md-7">
            <label for="TextBoxConcepto">Concepto</label>
            <asp:TextBox TextMode="MultiLine" class="form-control" ID="TextBoxConcepto" runat="server" placeholder="Concepto"></asp:TextBox>
        </div>
        <asp:RequiredFieldValidator ForeColor="red" ID="RequiredFieldValidator2" runat="server" Display="Dynamic" ControlToValidate="TextBoxConcepto" Font-Bold="True" ErrorMessage="No puede dejar el concepto vacio"></asp:RequiredFieldValidator>
        <div class="form-group col-md-7">
            <label for="TextBoxMonto">Monto</label>
            <asp:TextBox TextMode="Number" class="form-control" ID="TextBoxMonto" runat="server" placeholder="Monto"></asp:TextBox>
        </div>
        <asp:RequiredFieldValidator ForeColor="red" ID="RequiredFieldValidator3" runat="server" Display="Dynamic" ControlToValidate="TextBoxMonto" Font-Bold="True" ErrorMessage="No puede dejar el monto vacio"></asp:RequiredFieldValidator>
    </div>



    <asp:Button class="btn btn-primary" ID="ButtonNuevo" runat="server" Text="Nuevo" OnClick="ButtonNuevo_Click" />
    <asp:Button class="btn btn-success" ID="ButtonGuardar" runat="server" Text="Guardar" OnClick="ButtonGuardar_Click" />
    <asp:Button class="btn btn-danger" ID="ButtonEliminar" runat="server" Text="Eliminar" OnClick="ButtonEliminar_Click" />
</asp:Content>
