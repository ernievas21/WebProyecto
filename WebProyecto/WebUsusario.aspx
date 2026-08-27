<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebUsusario.aspx.cs" Inherits="WebTarea6.WebUsusario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        Sistema de Comercializacion Masiva 

                    </td>&nbsp;
                    <br />

                   
                </tr>
                <br />
              <tr>

                   <td>
                    <asp:Label ID="Label1" runat="server" Text="Usuario:"></asp:Label>
                  </td>
                <td>
                    <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                  </td>
              </tr>
               
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtpassword" runat="server" TextMode="Password"></asp:TextBox>
                    </td>

                </tr>
                
            </table>
            <br />
            <table>
                <tr>
                    <td>
                        <asp:Button ID="btnAcceder" runat="server" Text="Ingresar" Height="50px" OnClick="btnAcceder_Click" />
                    </td>
                    <td>

                    </td>
                    <td>
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Height="50px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
