<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductoCrear.aspx.cs" Inherits="WebTarea6.ProductoCrear" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
           <center><b><asp:Label ID="Label4" runat="server" Text="Pagina Productos" Font-Size="Medium"></asp:Label></b></center>

            <h4> Datos Producto</h4>
            <br />
            
            
             <div>
	
<table>	
	<tr>
		<td> 
		    <asp:Label ID="Label1" runat="server" Text="Descripcion"></asp:Label>  
         </td>    
		<td> 
		   <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
        </td>  
	   
	   </tr>
		      
        <tr>
		   <td> 
             <asp:Label ID="Label2" runat="server" Text="Precio"></asp:Label>           
            </td> 
			 <td> 
			  <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
			</td> 
        </tr>
          
 	  <tr>
		   <td> 
             <asp:Label ID="Label3" runat="server" Text="Marca"></asp:Label>  
               
           </td> 
		   <td> 
			  <asp:TextBox ID="txtMarca" runat="server"></asp:TextBox>
		    </td> 
        </tr>
		 
		 <tr>
		   <td> 
             <asp:Label ID="Label5" runat="server" Text="Lote"></asp:Label>  
           </td> 
			 <td> 
			   <asp:TextBox ID="txtLote" runat="server"></asp:TextBox>
			</td> 
        </tr>

        <tr>
		    <td>            
             <asp:Label ID="Label6" runat="server" Text="Codigo Barras"></asp:Label>  
		     </td> 
			   <td> 
			   <asp:TextBox ID="txtCodigoBarras" runat="server"></asp:TextBox>
			 </td> 
        </tr>
		
		<tr>
		    <td>
             <asp:Label ID="Label7" runat="server" Text="Fecha Vencimiento"></asp:Label>  
		   </td> 
		   <td>
		     <asp:TextBox ID="txtFechaVencimiento" runat="server"></asp:TextBox>
			</td>
		   
        </tr>	
</table>	
                 <br />
		
  </div>
            
               
          
           
            
                
           
               

          
            
          

           
                <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" Height="50px" Width="120px" />
            &nbsp; &nbsp;
            <asp:Button ID="btnDetalle" runat="server" Text="Detalle" OnClick="btnDetalle_Click" Height="50px" Width="120px" />
            
            &nbsp;
            <asp:Button ID="btnPrincipal" runat="server" Text="Menu Principal" Height="50px" Width="120px" OnClick="btnPrincipal_Click" />
           <h4>&nbsp;</h4>
            <br />
            <div>


            </div>
        </div>
    </form>
</body>
</html>
