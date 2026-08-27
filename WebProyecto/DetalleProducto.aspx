<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetalleProducto.aspx.cs" Inherits="WebTarea6.DetalleProducto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
          <div>
              
                   <h4><center>
                     <b> <asp:Label ID="Label2" runat="server" Text="Pagina Productos"></asp:Label></center>
                       </b> 
                   </h4>
                
              <br />

           <b><asp:Label ID="Label1" runat="server" Text="Listado de Productos" ></asp:Label> </b>
        </div>
        <br />
        <asp:GridView ID="gvProductos" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
          </asp:GridView>

           <div>
        
        <div>
           
        </div>
          <br />
          <div>

                 <div>
             <table>
                 <tr>
                     <td>
                         <asp:Label ID="lblProducto" runat="server" Text="Codigo Producto:"></asp:Label>
                     </td>
                     <td>
                         &nbsp;
                           <asp:TextBox ID="txtModificar" runat="server" Text=""></asp:TextBox>
                     </td>
                     <td>
                          &nbsp;
                           <asp:Button ID="btnModificar" runat="server" Text="Modificar" Height="50px" Width="120px" OnClick="btnModificar_Click"  />
                     </td>
                     <td>
                          &nbsp;
                          &nbsp;
                         <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" Height="50px" OnClick="btnEliminar_Click" Width="120px" />
                     </td>
                     <td>
                         &nbsp;
                          &nbsp;
                          <asp:Button ID="btnRegresar" runat="server" Text="Regresar Producto" OnClick="btnRegresar_Click" Height="50px" Width="143px" />
                     </td>
                 </tr>

             </table>
             
            
            
              <br>
               <asp:TextBox ID="txtEliminar" runat="server" Text=" " Visible="False"></asp:TextBox>
               
              
          </div>


    </form>
</body>
</html>
