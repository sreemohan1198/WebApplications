<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StageMgt.aspx.cs" Inherits="WebApplication4.StageMgt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%;">             
                  
                   <tr>                  
                    <td>
                        <asp:Button ID="btnDetails" runat="server" Text="Show Details" OnClick="btnDetails_Click" />
                    </td>
                   </tr>
               <%--<tr>
                   <td>
                       <asp:GridView ID="grdDetails" runat="server" OnSelectedIndexChanged="grdDetails_SelectedIndexChanged"></asp:GridView>
                   </td>
               </tr>--%>
                <tr>
                    <td>
                        Show Details:
                        <asp:Button ID="btnShow" runat="server" Text="Show" OnClick="btnShow_Click" />
                    </td>
                </tr>
              
            </table>
        </div>
    </form>
</body>
</html>
