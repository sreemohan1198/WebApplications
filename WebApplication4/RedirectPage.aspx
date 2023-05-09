<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RedirectPage.aspx.cs" Inherits="WebApplication4.RedirectPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddlRedirect" runat="server" OnSelectedIndexChanged="ddlRedirect_SelectedIndexChanged"></asp:DropDownList>
        </div>
    </form>
</body>
</html>
