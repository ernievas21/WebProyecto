<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="WebTarea6.Detalle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
              <center> <h4>d<asp:Label ID="Label5" runat="server" Text="Pagina Detalle" ></asp:Label> </h4></center> 
        </div>
          &nbsp;
         <div>
           <b><asp:Label ID="Label1" runat="server" Text="Listado de Clientes" ></asp:Label> </b>
        </div>
        <br />
        <asp:GridView ID="gvClientes" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
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
              
        </div>
       
        <div>
            
        </div>
         
          <div>
             
             <table>
                 <tr>
                     <td>

                         <asp:Label ID="Label2" runat="server" Text="Codigo Cliente:"></asp:Label>
                     </td>
                     <td>

                         <asp:TextBox ID="txtModificar" runat="server" Text=""></asp:TextBox>

                     </td>
                      <td>
                          
                   &nbsp;
                          &nbsp;
                     <asp:Button ID="btnModificar" runat="server" Text="Modificar" Height="50" Width="120" OnClick="btnModificar_Click"  />
                          </td>
                        <td>
                          
                          &nbsp;
                          &nbsp;
                         
                             <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" Height="50px" OnClick="btnEliminar_Click" Width="120px" />
                            </td>
                      <td>
                          
                          &nbsp;
                          &nbsp;
                          <asp:Button ID="btnRegresar" runat="server" Text="Regresar" OnClick="btnRegresar_Click" Height="50px" Width="120px" />
                          </td>

                 </tr>

             </table>
              
              <br>
               <asp:TextBox ID="txtEliminar" runat="server" Text="Eliminar" Visible="False"></asp:TextBox>
              
              
          </div>
          <br />
          <div>
             
          </div>
      
    </form>
</body>
</html>
