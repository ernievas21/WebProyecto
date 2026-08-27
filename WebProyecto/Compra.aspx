<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Compra.aspx.cs" Inherits="WebTarea6.Compra" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
              
                    <h3>
                   || Modulo Compras ||
                        </h3>
               
            </p>
           <b><asp:Label ID="Label1" runat="server" Text="Encabezado Compra"></asp:Label></b> 
             &nbsp;
             &nbsp;
            <br />
              <br />
           <table> 
         <tr>
             <td>
                 <asp:Label ID="Label7" runat="server" Text="Fecha Compra"></asp:Label>
             </td>
             <td>
                 <asp:TextBox ID="txtfecha_compra" runat="server"></asp:TextBox>
             </td>
         </tr>
             <tr>
                <td>
                   <asp:Label ID="Label6" runat="server" Text="Codigo Compra:"></asp:Label>
                </td>
                 <td>
                     <asp:TextBox ID="txtIdCompra" runat="server"></asp:TextBox>
                 </td>
               <tr>
                <td>
                   <asp:Label ID="Label2" runat="server" Text="Codigo Proveedor:"></asp:Label>
                </td>
                 <td>
                     <asp:TextBox ID="txtCodigoProveedor" runat="server"></asp:TextBox>
                 </td>
               <td>
                   <asp:Button ID="btnBuscarProveedor" runat="server" Text="Buscar" OnClick="btnBuscarProveedor_Click" />  
                 </td>
           </tr>

               <tr>
                <td>
                   <asp:Label ID="Label3" runat="server" Text="Nombre Proveedor:"></asp:Label>
                </td>
                 <td>
                     <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                 </td>
               <td>

                    <tr>
                <td>
                   <asp:Label ID="Label4" runat="server" Text="Codigo CAJA:"></asp:Label>
                </td>
                 <td>
                     <asp:TextBox ID="txtCaja" runat="server"></asp:TextBox>
                 </td>
               <td>
              
        </table>
            <br />
            <br />
           <%-- detalle --%>
            <b> <asp:Label ID="Label5" runat="server" Text="Detalle de Compra"></asp:Label> </b>
            <br />
            <br />

            <table>
            <tr>
                    <td>
                        <asp:Label ID="Label8" runat="server" Text="Codigo Producto: "></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtidProducto" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style1">
                        <asp:Button ID="btnBuscarProducto" runat="server" Text="Buscar " OnClick="btnBuscarProducto_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label9" runat="server" Text="Descripcion"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
                    </td>
                </tr>

                 <tr>
                    <td>
                        <asp:Label ID="Label10" runat="server" Text="Precio"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:Label ID="Label11" runat="server" Text="Cantidad"></asp:Label>
                    </td>
                    <td class="auto-style2">

                        <asp:TextBox ID="txtCantidad" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style1">
                        <asp:Button ID="btnCalcular" runat="server" Text="Calcular" OnClick="btnCalcular_Click"  />
                    </td>
                </tr>

                 <tr>
                    <td>
                        <asp:Label ID="Label12" runat="server" Text="Total"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtTotal" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <br />
          
   <%-- botones --%>
            <table>
                <tr>
                    <td>
                     <asp:Button ID="btnAgregar" runat="server" Text="Agregar" Height="70px" OnClick="btnAgregar_Click" />
                    </td>

                     <td>
                            &nbsp;  <asp:Button ID="Detalle" runat="server" Text="Detalle" Height="70px" Width="86px" OnClick="Detalle_Click" />
                    </td>
                     <td>
                             &nbsp; <asp:Button ID="btnMenu" runat="server" Text="MenuPrincipal" Height="70px" Width="138px" OnClick="btnMenu_Click" />
                    </td>

                </tr>

            </table>
            <br />

            <asp:GridView ID="gvEncabezado" runat="server"></asp:GridView>



        </div>
    </form>
</body>
</html>
