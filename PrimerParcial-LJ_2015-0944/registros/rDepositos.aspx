<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="rDepositos.aspx.cs" Inherits="PrimerParcial_LJ_2015_0944.registros.rDepositos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <div class="form-group col-md-1">
            <label for="TextBoxDepositoID">Deposito ID</label>
            <asp:TextBox TextMode="Number" class="form-control" ID="TextBoxDepositoID" runat="server" placeholder="ID"></asp:TextBox>
        </div>
    </div>
    <div class="form-group col-md-6">
        <label for="TextBoxCuentaID">Cuenta ID</label>
        <asp:TextBox TextMode="Number" class="form-control" ID="TextBoxCuentaID" runat="server" placeholder="Cuenta ID"></asp:TextBox>
    </div>
    <div class="form-group col-md-7">
        <label for="TextBoxFecha">Fecha</label>
        <asp:TextBox TextMode="Date" class="form-control" ID="TextBoxFecha" runat="server" placeholder="Fecha"></asp:TextBox>
    </div>
    <div class="form-group col-md-7">
        <label for="TextBoxConcepto">Concepto</label>
        <asp:TextBox TextMode="MultiLine" class="form-control" ID="TextBoxConcepto" runat="server" placeholder="Concepto"></asp:TextBox>
    </div>
    <div class="form-group col-md-7">
        <label for="TextBoxMonto">Monto</label>
        <asp:TextBox TextMode="Number" class="form-control" ID="TextBoxMonto" runat="server" placeholder="Monto"></asp:TextBox>
    </div>
    <button type="submit" class="btn btn-primary"></button>
    <asp:Button class="btn btn-primary" ID="ButtonGuardar" runat="server" Text="Guardar" />
</asp:Content>
