<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaPrincipal.aspx.cs" Inherits="WebTarea6.PaginaPrincipal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 793px;
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <center><h2>Proyecto Analisis de Sistemas</h2>

            </center>
            <table>
                <tr>
                    <td>
                        Alumno: Ernie Hazzenn Vasquez Sosa
                    </td>
                </tr>
                <tr>
                    <td>
                        Aera: Analisis de Sistemas&nbsp;</td>
                </tr>
            </table>
            <br />
       <table>
           <tr>
               <td class="auto-style1">
                  <b> Listado de Modulos del Sistema &nbsp;</td></b>
           </tr>
       </table>
        


             <table>
           
           
            <tr>
               
             <td>
            &nbsp; <asp:Button ID="btnCliente" runat="server" Text="Clientes" Height="70px" Width="140px" OnClick="btnCliente_Click" />
             </td>
                <p>&nbsp;
                     <td>&nbsp;
                          <td>&nbsp;
                              <asp:Button ID="Button1" runat="server" Height="70px" OnClick="Button1_Click" Text="Productos" Width="140px" />
             </td>
                  <td>&nbsp;
                          <td>&nbsp;
                    <td>
                        <asp:Button ID="btnFactura" runat="server" Text="Ventas" Height="70px" Width="140px" OnClick="btnFactura_Click" />
                    </td>
<td>&nbsp;
                    <td> 
                     <asp:Button ID="Button2" runat="server" Text="Compras" Height="70px" OnClick="Button2_Click" Width="140px" />
                </td>
                <td>&nbsp;
                    <td> 
                     <asp:Button ID="btnControlAcceso" runat="server" Text="Control de Acceso" Height="70px" OnClick="btnControlAcceso_Click" Width="170px" />
                </td>
               </tr>
                
            
        </table>
    </form>
</body>
</html>
