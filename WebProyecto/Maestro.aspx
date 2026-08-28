<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Maestro.aspx.cs" Inherits="WebTarea6.Maestro" %>

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
              <b><h4><center> <asp:Label ID="Label5" runat="server" Text="Pagina Cliente" ></asp:Label></center> </h4> </b>
        
        
        <div>
            &nbsp;
            
          
           <b><asp:Label ID="Label6" runat="server" Text="Datos Cliente"></asp:Label></b>
        </div> <br />

        <div>
            &nbsp;
            <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
        &nbsp;</div>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
       
        <div>
            <asp:Label ID="Label2" runat="server" Text="Apellido"></asp:Label>
        &nbsp;</div>
        <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
         <div>
       </div>

            <div>
            <asp:Label ID="Label3" runat="server" Text="Direccion"></asp:Label>
        &nbsp;</div>
        <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
       
        <div>
            <asp:Label ID="Label4" runat="server" Text="Telefono"></asp:Label>
        &nbsp;</div>
         <div>
        <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
     </div>

          
     

      
        <div>
            <asp:Label ID="Label8" runat="server" Text="Edad"></asp:Label>
        &nbsp;</div>
        <div>
        <asp:TextBox ID="txtnumero_cuenta" runat="server"></asp:TextBox>
             <asp:Label ID="Label9" runat="server" Text="Label" Visible="False"></asp:Label>
     </div>

        <br />
           <div>
           
               <asp:Button ID="btnAgregar" runat="server" Text="Agregar" Height="50px" OnClick="btnAgregar_Click" Width="120px" />  &nbsp;
               <asp:Button ID="btnDetalle" runat="server" Text="Listado" Height="50px" OnClick="btnDetalle_Click" Width="120px" />
                &nbsp;
               <asp:Button ID="btnPrincipal" runat="server" Text="Menu Principal" Height="50px" OnClick="btnPrincipal_Click" Width="120px" />
               <br />
              
               <br />
               <br />
               <asp:Button ID="btnProducto" runat="server" Text="Producto" OnClick="btnProducto_Click" />
     </div>
         <br />
         <div>
          &nbsp;&nbsp;
             </div>
    </form>
</body>
</html>
