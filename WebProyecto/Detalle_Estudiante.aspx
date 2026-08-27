<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detalle_Estudiante.aspx.cs" Inherits="WebTarea6.Detalle_Estudiante" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-1.4.4.min.js"></script>



    <link href="Content/bootstrap.min.css" rel="stylesheet" />

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        d<div>
            <center>
                <tr>
                 <td>
                     <h2><asp:Label ID="Label1" runat="server" Text="Detalle de Pesos"></asp:Label></h2>
                 </td> 
                     </center>
                </tr>
             
<tr>
    <td>
       &nbsp;  <b> <asp:Label ID="Label2" runat="server" Text="Listado de Estudiantes"></asp:Label>  </b>
    </td>

</tr>        
            <br />
            <br />
             <asp:GridView ID="gvEstu" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
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
             <br />
       
              
                <br />
                <table>
                 <tr>
                     <td>

                        &nbsp;   <asp:Label ID="Label3" runat="server" Text="Codigo Estudiante:"></asp:Label>
                     </td>
                     <td>

                         &nbsp;  <asp:TextBox ID="txtModificar" runat="server" Text=""></asp:TextBox>
                        

                     </td>
                     <td>
                           &nbsp; <asp:Button ID="BtnModificarEstudiante" runat="server" Text="Modificar" OnClick="BtnModificarEstudiante_Click" Height="50px" Width="100px" />
                     </td>

                     <td>
                       &nbsp;     <asp:Button ID="BtnEliminar" runat="server" Text="Eliminar" Height="50px" OnClick="BtnEliminar_Click" Width="100px" />

                     </td>

                       <td>
                       &nbsp;     <asp:Button ID="btnRegresar" runat="server" Text="Regresar" OnClick="btnRegresar_Click" Height="50px" Width="100px" />

                     </td>

                      
                      
        </div>
    </form>
    </form>
        </body>
</html>
