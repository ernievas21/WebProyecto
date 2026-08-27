<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Eliminar.aspx.cs" Inherits="WebTarea6.Eliminar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         &nbsp;
         &nbsp;
          <div>
              <center> <asp:Label ID="Label5" runat="server" Text="Pagina Eliminar" ></asp:Label> </center> 
        &nbsp;</div>
        
        <div>
            &nbsp;
            
          
           <asp:Label ID="Label6" runat="server" Text="Eliminar Cliente"></asp:Label>
        </div> <br />

        <div>
            &nbsp;
            <asp:Label ID="Label1" runat="server" Text="Nombre" ></asp:Label>
        &nbsp;</div>
        <asp:TextBox ID="txtNombre" runat="server" Enabled="false"></asp:TextBox>
       
        <div>
            <asp:Label ID="Label2" runat="server" Text="Apellido"></asp:Label>
        &nbsp;</div>
        <asp:TextBox ID="txtApellido" runat="server" Enabled="false"></asp:TextBox>
         <div>
       </div>

            <div>
            <asp:Label ID="Label3" runat="server" Text="Direccion" ></asp:Label>
        &nbsp;</div>
        <asp:TextBox ID="txtDireccion" runat="server" Enabled="false"></asp:TextBox>
       
        <div>
            <asp:Label ID="Label4" runat="server" Text="Telefono"></asp:Label>
        &nbsp;</div>
         <div>
        <asp:TextBox ID="txtTelefono" runat="server" Enabled="false"></asp:TextBox>
     </div>

           
       
            
           
     

        <br />
        <div>
            <asp:Label ID="Label8" runat="server" Text="Edad"></asp:Label>
        &nbsp;</div>
        <div>
        <asp:TextBox ID="txtEdad" runat="server" Enabled="false"></asp:TextBox>
     </div>

        <br />
           <div>
           
              
               <asp:Button ID="btnDetalle" runat="server" Text="Ir Detalle" Height="47px" OnClick="btnDetalle_Click" Width="170px" />
               
               <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" Height="47px" OnClick="btnEliminar_Click"  />  &nbsp;
               <br />
     </div>
         <br />
         <div>
          &nbsp;&nbsp;
             </div>
    </form>
</body>
</html>
