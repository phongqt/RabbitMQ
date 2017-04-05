<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="RBMSDemo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Select
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Value="abc">Hello abc</asp:ListItem>
            <asp:ListItem Value="def">Hello def</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        Comment<br />
        <asp:TextBox ID="TextBox1" runat="server" Width="176px"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" Text="Ok" OnClick="Button1_Click" Width="71px" />
        <br />
    </div>
    </form>
</body>
</html>
