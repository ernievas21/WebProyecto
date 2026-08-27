<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EliminarProducto.aspx.cs" Inherits="WebTarea6.EliminarProducto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                 &nbsp;
          <div>
              <center> <asp:Label ID="Label5" runat="server" Text="Productos" ></asp:Label> </center> 
        &nbsp;</div>
        
        <div>
            &nbsp;
            
          
           <asp:Label ID="Label6" runat="server" Text="Eliminar Producto"></asp:Label>
        </div> <br />

        <div>
            &nbsp;
            <asp:Label ID="Label1" runat="server" Text="Descripcion"></asp:Label>
        &nbsp;</div>
        <asp:TextBox ID="txtDescripcion" runat="server" Enabled="false"></asp:TextBox>
       
        <div>
            <asp:Label ID="Label2" runat="server" Text="Precio"></asp:Label>
        &nbsp;</div>
        <asp:TextBox ID="txtPrecio" runat="server" Enabled="false"></asp:TextBox>
         <div>
       </div>

            <div>
            <asp:Label ID="Label3" runat="server" Text="Marca"></asp:Label>
        &nbsp;</div>
        <asp:TextBox ID="txtMarca" runat="server" Enabled="false"></asp:TextBox>
        &nbsp;
                <div>
            <asp:Label ID="Label4" runat="server" Text="lote"></asp:Label>
        &nbsp;</div>
        <asp:TextBox ID="txtLote" runat="server" Enabled="false"></asp:TextBox>

 &nbsp;
                <div>
            <asp:Label ID="Label7" runat="server" Text="CodigoBarra"></asp:Label>
        &nbsp;</div>
        <asp:TextBox ID="txtCodigoBarra" runat="server" Enabled="false"></asp:TextBox>

                <div>
            <asp:Label ID="Label8" runat="server" Text="Fecha Vencimiento"></asp:Label>
        &nbsp;</div>
        <asp:TextBox ID="txtFechaVencimiento" runat="server" Enabled="false"></asp:TextBox>


        <br />
            <br />

           <div>
           
              
               <asp:Button ID="btnDetalle" runat="server" Text="Ir Detalle" Height="47px"  Width="170px" OnClick="btnDetalle_Click"  />
               
               <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" Height="47px" OnClick="btnEliminar_Click"    />  &nbsp;
               <br />
     </div>
         <br />
         <div>
          &nbsp;&nbsp;
             </div>
        </div>
    </form>
</body>
</html>
