<%@ Page Language="C#" AutoEventWireup="true" CodeFile="test.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="text-align: center">
    <form id="form1" runat="server">
    <div id="div1" runat="server">
    
        <asp:Label ID="lbResult" runat="server" Text="Label"></asp:Label>
    
    </div>
        <p>
            ชื่อลูกค้า :
            <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
        </p>
        <p>
            ชื่อสินค้า</p>
        <p>
            <asp:ListBox ID="lsProduct" runat="server" Height="176px" Width="175px" AutoPostBack="True" OnSelectedIndexChanged="lsProduct_SelectedIndexChanged">
                <asp:ListItem>Tablet</asp:ListItem>
                <asp:ListItem>IPHONE</asp:ListItem>
                <asp:ListItem>MACBOOK</asp:ListItem>
            </asp:ListBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </p>
        <asp:Calendar ID="cl1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" style="text-align: center"></asp:Calendar>
        <br />
        <asp:Label ID="lbResultC" runat="server" Text="Support Calendar"></asp:Label>
    </form>
</body>
</html>
