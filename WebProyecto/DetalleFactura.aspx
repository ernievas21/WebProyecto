<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetalleFactura.aspx.cs" Inherits="WebTarea6.DetalleFactura" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          
            <b>Detalle de factura</b>
              <br />
              <br />

            <asp:GridView ID="gvDetalleFactura" runat="server"></asp:GridView>
            <br />
           &nbsp;
&nbsp;<asp:TextBox ID="txtIdFactura" runat="server"></asp:TextBox>
           &nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="consultar" Height="50px" Width="120px" />
            &nbsp
             <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Regresar" Height="50px" Width="120px" />
        </div>
    </form>
</body>
</html>
