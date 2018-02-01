<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webform.aspx.cs" Inherits="ZacharyToneyProject1Part3.webform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Total Quiz Score</p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <p>Total Assignment Score</p>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <p>Midterm Exam Score</p>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <p>Final Exam Score</p>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Calculate" OnClick="Button1_Click" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Answer will display here"></asp:Label>
        </p>
    </form>
</body>
</html>
