<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModificarAlumno.aspx.cs" Inherits="WebTarea6.ModificarAlumno" %>

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
        <div>

             <div class="container text-center">
            <div class="row">
                 <h3> <asp:Label ID="Label9" runat="server" Text="Modificar Cliente"></asp:Label></h3>
                <div class="col-4">
                  
                </div>
                <div class="col-4">
                   
                </div>
                <div class="col-4">
                    
                </div>
            </div>
        </div>
             
                &nbsp;      <b><asp:Label ID="Label6" runat="server" Text="Datos Estudiante"></asp:Label></b>
                &nbsp; 
        
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
                  &nbsp;   <asp:Label ID="Label3" runat="server" Text="Altura"></asp:Label>
                    &nbsp;
                </div>
              &nbsp;   <asp:TextBox ID="txtAltura" runat="server"></asp:TextBox>
                <div>
                </div>

                <div>
               &nbsp;      <asp:Label ID="Label4" runat="server" Text="Peso"></asp:Label>
                    &nbsp;
                </div>
             &nbsp;    <asp:TextBox ID="txtPeso" runat="server"></asp:TextBox>
                <div>
                </div>

                <div>
                &nbsp;     <asp:Label ID="Label7" runat="server" Text="Edad"></asp:Label>
                    &nbsp;
                </div>
              &nbsp;   <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
                <div>
                </div>
                <div>
               &nbsp;      <asp:Label ID="Label8" runat="server" Text="Genero"></asp:Label>
                    &nbsp;
                </div>
              &nbsp;   <asp:TextBox ID="txtGenero" runat="server"></asp:TextBox>
                <div>
                    <asp:Label ID="lblSobrepeso" runat="server" Text="Label"></asp:Label>
                </div>
        <br />
           &nbsp;   <asp:Button ID="BtnModificar" runat="server" Text="Modificar" OnClick="BtnModificar_Click" Height="50px" Width="100px" />
         &nbsp;     <asp:Button ID="BtnRegresar" runat="server" Text="Regresar" OnClick="BtnRegresar_Click" Height="50px" Width="100px" />
        </div>
    </form>
</body>
</html>
