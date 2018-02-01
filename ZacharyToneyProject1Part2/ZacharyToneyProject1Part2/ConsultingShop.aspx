<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultingShop.aspx.cs" Inherits="ZacharyToneyProject1Part2.ConsultingShop" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="125" Selected="True">Makeover</asp:ListItem>
                <asp:ListItem Value="60">Hair Styling</asp:ListItem>
                <asp:ListItem Value="35">Manicure</asp:ListItem>
                <asp:ListItem Value="200">Permanent Makeup</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem Value="0.1">10 percent</asp:ListItem>
                <asp:ListItem Value="0.2">20 percent</asp:ListItem>
                <asp:ListItem Value="0" Selected="True">None</asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="Button1" runat="server" Text="Calculate" OnClick="Button1_Click" />
        </div>
        <asp:Label ID="Label1" runat="server" Text="Answer will display here"></asp:Label>
    </form>
</body>
</html>
