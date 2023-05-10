<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarProducto.aspx.cs" Inherits="SitioProductos.EditarProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style type="text/css">
         .auto-style1 {
             width: 76px;
             height: 72px;
         }
     </style>
      <div>

        <h1>Nuevo Producto</h1>
            <asp:Label ID="lblDescripcion" runat="server" Text="Descripcion:"></asp:Label>
            <br />
            <asp:TextBox ID="txtDescripcion" runat="server" Width="300px"></asp:TextBox>
            <br />

            <asp:Label ID="LblMarca" runat="server" Text="Marca:"></asp:Label>
            <br />
            <asp:TextBox ID="txtMarca" runat="server" Width="300px"></asp:TextBox>
            <br /> 

            <asp:Label ID="lblRubro" runat="server" Text="Rubro:"></asp:Label>
            <br />
            <asp:TextBox ID="txtRubro" runat="server" Width="300px"></asp:TextBox>
            
            <br />

            <asp:Label ID="lblUnidadMedida" runat="server" Text="Unidad de Medida:"></asp:Label>
             <br />
             <asp:TextBox ID="txtUnidadMedida" runat="server" Width="300px"></asp:TextBox>
            <br />
            
            <asp:Label ID="lblPVP" runat="server" Text="Precio:"></asp:Label>
             <br />
               <asp:TextBox ID="txtPVP" runat="server" Width="300px"></asp:TextBox>
 
             <br />
            
            <asp:Label ID="lblCantidad" runat="server" Text="Cantidad:"></asp:Label>
             <br />
            <asp:TextBox ID="txtCantidad" runat="server" Width="300px"></asp:TextBox>

            <p />
            <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click"/>
            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click"/>

    </div>

</asp:Content>

