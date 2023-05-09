<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddressWeb.aspx.cs" Inherits="WebApplication4.AddressWeb" %>

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
                    <td>Address Details : </td>                       
                    </tr>
                 <tr>   
                    <td>Address ID :
                         <asp:TextBox ID="txtAddressId" runat="server" OnTextChanged="txtAddressId_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Street :
                        <asp:TextBox ID="txtStreet" runat="server" OnTextChanged="txtStreet_TextChanged"></asp:TextBox>

                    </td>                                       
                </tr>
                <tr>
                    <td>City :
                         <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>

                    </td>                    
                </tr>
                <tr>
                    <td>State ID :
                      <%--  <asp:TextBox ID="txtStateid" runat="server"></asp:TextBox>--%>
                        <asp:DropDownList ID="ddlState" runat="server"></asp:DropDownList>

                    </td>
                </tr>
                <tr>
                    <td>ZipCode :
                        <asp:TextBox ID="txtZipcode" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Employee Number :
                     <%--  <asp:TextBox ID="txtEmpno" runat="server"></asp:TextBox>--%>
                        <asp:DropDownList ID="ddlEmpno" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit List" OnClick="btnSubmit_Click" />
                    </td>                    
                </tr>
                
                <tr>
                    <td>
                        <asp:Button ID="btnUpdate" runat="server" Text="Update Database" OnClick="btnUpdate_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="ddlSubmit" runat="server"></asp:DropDownList>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
