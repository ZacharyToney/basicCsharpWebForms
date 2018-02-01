<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TargetHeartRate.aspx.cs" Inherits="ZacharyToneyProject1Part1.TargetHeartRate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Resting Heart Rate:</p>
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Number"></asp:TextBox>
            <p>Age:</p>
            <asp:TextBox ID="TextBox3" runat="server" TextMode="Number"></asp:TextBox>
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        </p>
        <asp:Label ID="Label1" runat="server" Text="Answer will display here"></asp:Label>
    </form>
</body>
</html>
