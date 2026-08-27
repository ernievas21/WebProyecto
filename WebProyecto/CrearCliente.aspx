<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrearCliente.aspx.cs" Inherits="WebTarea6.CrearCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
  <div class="row">
                 <CENTER><h3> <asp:Label ID="Label9" runat="server" Text="Registro Cliente"></asp:Label></h3></CENTER>
                <div class="col-4">
                   
                </div>
                <div class="col-4">
                   
                </div>
                <div class="col-4">
                    
                </div>
            </div>
        </div>
             
                &nbsp;      <b><asp:Label ID="Label6" runat="server" Text="Datos Cliente"></asp:Label>
        <br />
        </b>
               
        
        <br />

                <div>

                    &nbsp;
           &nbsp;  <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
                    &nbsp;
                </div>
               &nbsp; <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>

                <div>
                  &nbsp;   <asp:Label ID="Label2" runat="server" Text="Apellido"></asp:Label>
                    &nbsp;
                </div>
               &nbsp;  <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
                <div>
                </div>

                <div>
                  &nbsp;   <asp:Label ID="Label3" runat="server" Text="Direccion"></asp:Label>
                    &nbsp;
                </div>
              &nbsp;   <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
                <div>
                </div>

                <div>
               &nbsp;      <asp:Label ID="Label4" runat="server" Text="Telefono"></asp:Label>
                    &nbsp;
                </div>
             &nbsp;    <asp:TextBox ID="txttelefono" runat="server"></asp:TextBox>
                <div>
                </div>

                <div>
                &nbsp;     <asp:Label ID="Label7" runat="server" Text="Edad"></asp:Label>
                    &nbsp;
                </div>
              &nbsp;   <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
                <div>
                </div>
        <br />       
        &nbsp;
        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" Height="50px" OnClick="btnGuardar_Click" Width="100px" />  
         &nbsp;<asp:Button ID="btnListar" runat="server" Text="Listar" Height="50px" Width="100px" OnClick="btnListar_Click" />
        &nbsp;<asp:Button ID="btnRegresar" runat="server" Text="Regresar" Height="50px" OnClick="btnRegresar_Click" />
    </form>
</body>
</html>
