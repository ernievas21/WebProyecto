<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Factura.aspx.cs" Inherits="WebTarea6.Factura" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 70px;
        }
        .auto-style2 {
            width: 145px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          
               
                    
                        <b><h3>|| Modulo Ventas ||</h3></b>
                    
                
           
         &nbsp;

            <table>

                <tr>
                   <td>
                       <asp:Label ID="Label13" runat="server" Text="Codigo Factura"></asp:Label> 
                   </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtcodigoFactura" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style1">
                        <asp:Label ID="Label1" runat="server" Text="Fecha"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtFecha" runat="server" Width="155px"></asp:TextBox>
                        
                       

                    </td>
                    <td>
                         <asp:Label ID="Label5" runat="server" Text="Serie"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtSerie" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Tipo"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtTipo" runat="server"></asp:TextBox>
                    </td>
                     <td>
                        <asp:Label ID="Label14" runat="server" Text="Tienda"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtid_tienda" runat="server"></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Codigo Cliente: "></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtidCliente" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style1">
                        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Nombre"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Apellido"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <br>
               <tr>
                   <td>
                       <b><asp:Label ID="Label7" runat="server" Text="Detalle"></asp:Label></b>
                   </td>
               </tr>
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
                        <asp:Button ID="btnCalcular" runat="server" Text="Calcular" OnClick="btnCalcular_Click" />
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
                <br />
               

                <tr>
                    <td>
                        <asp:Button ID="tbnAgregar" runat="server" Text="Agregar" OnClick="tbnAgregar_Click" Height="50px" Width="120px" />
                    </td>
                    <td class="auto-style2"> <asp:Button ID="tbnDetalle" runat="server" Text="Detalle" OnClick="tbnDetalle_Click" Height="50px" Width="120px" /></td>
               <td>
                   <asp:Button ID="btnPrincipal" runat="server" Text="Menu Principal" Height="50px" Width="120px" OnClick="btnPrincipal_Click" />

               </td>
                    </tr>


            </table>



        </div>
        <asp:GridView ID="gvEncabezado" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
