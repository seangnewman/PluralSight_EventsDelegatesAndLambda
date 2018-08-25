<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 214px">
            <asp:Label ID="CountriesLabel" runat="server" Font-Size="Large" Text="Countries"></asp:Label>
            <br />
            <br />
            <br />
            <asp:DropDownList ID="CountriesDropDownList" runat="server" AutoPostBack="true" OnSelectedIndexChanged="CountriesDropDownList_SelectedIndexChanged1" Font-Size="Large">
                <asp:ListItem>United States</asp:ListItem>
                <asp:ListItem>Mexico</asp:ListItem>
                <asp:ListItem>Canada</asp:ListItem>
                <asp:ListItem>Brazil</asp:ListItem>
                <asp:ListItem>Chile</asp:ListItem>
                <asp:ListItem>Argentina</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Font-Size="Large" OnClick="Button1_Click" Text="Submit" Width="106px" />
            <br />
            <br />
            <asp:Label ID="OutputLabel" runat="server" Font-Names="OutputLabel" Font-Size="Large" Text="OutputLabel"></asp:Label>
        </div>
    </form>
</body>
</html>
