<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="asp3array20003529.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" Font-Bold="true" Text="Use Category Array" /><br />

            <br />
            <asp:TextBox ID="txtIndex" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnLookup" runat="server" OnClick="btnLookup_Click" Text="Lookup" />
            <asp:Label ID="lblCategory" runat="server" Text="Label"></asp:Label>

        </div>
    </form>
</body>
</html>
