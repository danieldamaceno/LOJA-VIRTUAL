<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LOJAVIRTUAL.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1170px;
            height: 588px;
        }
        .auto-style2 {
            width: 643px;
            height: 507px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <img alt="" class="auto-style1" src="img/camisa.jpg" /></div>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>

<h1 style="text-align: center" >CAMISETA1</h1>
        <img alt="" class="auto-style2" src="img/produto.jpg" />
        <div style="margin-left: 200px">
            <asp:Button ID="Button1" runat="server" Text="Adicionar ao Carrinho" OnClick="Button1_Click" style="margin-left: 0px" />
            <br />
            <br />
        </div>
        <div style="margin-left: 200px">
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click1" Text="LIMPAR CARRINHO" />
            <br />
        </div>

        <p>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true" Width="100%" />
        </p>
        <p style="margin-left: 160px">
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="VER CARRINHO DE COMPRAS" />
        </p>
    </form>
    
</body>
</html>
