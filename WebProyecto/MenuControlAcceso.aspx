<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuControlAcceso.aspx.cs" Inherits="WebTarea6.MenuControlAcceso" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>||Menu Control de Acceso || </h3>
            <table>
         <tr>
               <td>
                     <asp:Button ID="btnEmpleados" runat="server" Text="Listado Empleados" Height="59px" OnClick="btnEmpleados_Click" />
            </td>  
             <td>
             &nbsp;
             <td>
                 <asp:Button ID="btnUsuarios" runat="server" Text="Listado Usuarios" Height="59px" OnClick="btnUsuarios_Click" />

             </td>
                  &nbsp;</td>
             <td>

             </td>
             <td>
                 <asp:Button ID="btnRegresar" runat="server" Text="Regresar" Height="57px" Width="135px" OnClick="btnRegresar_Click" />

             </td>

         </tr>
               
          
        
       

          </table>
&nbsp;</div>

    </form>
</body>
</html>
