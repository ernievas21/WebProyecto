<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModificarProducto.aspx.cs" Inherits="WebTarea6.ModificarProducto" %>

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
              <center><h3> <asp:Label ID="Label5" runat="server" Text="Producto" ></asp:Label> </center> </h3>
      
        
        <div>
            &nbsp;
            
          
           <asp:Label ID="Label6" runat="server" Text="Modificar Producto"></asp:Label>
        </div> <br />

        <div>
            &nbsp;
            <asp:Label ID="Label1" runat="server" Text="Descripcion"></asp:Label>
        &nbsp;</div>
        <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
       
        <div>
            <asp:Label ID="Label2" runat="server" Text="Precio"></asp:Label>
        &nbsp;</div>
        <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
         <div>
       </div>

            <div>
            <asp:Label ID="Label3" runat="server" Text="Marca"></asp:Label>
        &nbsp;</div>
        <asp:TextBox ID="txtMarca" runat="server"></asp:TextBox>
       <br />


        <br />
           <div>

                  <div>
             <asp:Label ID="Label4" runat="server" Text="Lote"></asp:Label>  
                      &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
               <br />

                <asp:TextBox ID="txtLote" runat="server"></asp:TextBox>
                     &nbsp;
                   &nbsp;&nbsp;&nbsp;&nbsp;
              &nbsp;
          </div>
            <br />
               <div>
                 
             <asp:Label ID="Label7" runat="server" Text="Codigo Barras"></asp:Label>  
              <br />

                   &nbsp;<asp:TextBox ID="txtCodigoBarras" runat="server"></asp:TextBox>
          </div>

               <div>
                     <br />
             <asp:Label ID="Label8" runat="server" Text="Fecha Vencimiento"></asp:Label>  
              &nbsp;
           <br />
               
                <asp:TextBox ID="txtFechaVencimiento" runat="server"></asp:TextBox>
          </div>
           <br />
              
               <asp:Button ID="btnDetalle" runat="server" Text="Ir Detalle" Height="47px"  Width="170px" OnClick="btnDetalle_Click"  />
               
               <asp:Button ID="btnModificar" runat="server" Text="Modificar" Height="47px" OnClick="btnModificar_Click1"   />  &nbsp;
               <br />
     </div>
         <br />
         <div>
          &nbsp;&nbsp;
             </div>
    </form>
</body>
</html>
