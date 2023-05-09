<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FirstPage.aspx.cs" Inherits="WebApplication2.FirstPage" %>

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
                    <td> <asp:Label ID="lblFname" runat="server" Text="First Name"></asp:Label></td>
                    <td> <asp:TextBox ID="txtFname" runat="server"></asp:TextBox></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Last Name :</td>
                    <td><asp:TextBox ID="txtLname" runat="server"></asp:TextBox></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td> Salary: </td>
                    <td>  
          <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td> <asp:Button ID="btnSave" runat="server" Text="Add Employee" OnClick="btnSave_Click" /></td>
                    <td> <asp:Button ID="btnDelete" runat="server" Text="Delete Employee" OnClick="btnDelete_Click" /></td>
                   <%-- <td style="text-align:left"> <asp:Button ID="btnUpdate" runat="server" Text="Update Department" OnClick=" grdDepartment_SelectedIndexChanged" /></td>--%>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="ddlEmployees" runat="server"></asp:DropDownList>
                    </td>
                    <td>
                        <asp:CheckBoxList ID="cblEmployees" runat="server"></asp:CheckBoxList>
                    </td>
                    <td>
                        <asp:RadioButtonList ID="rdlEmployees" runat="server"></asp:RadioButtonList>
                    </td>
                    <td>
                        <asp:RadioButtonList ID="rdlDepartment" runat="server"></asp:RadioButtonList>
                    </td>
                </tr>
               <%-- <tr>
                    <td>
                        <asp:GridView ID="grdEmployees" runat="server" OnSelectedIndexChanged="grdEmployees_SelectedIndexChanged"></asp:GridView>
                    </td>
                </tr>--%>
                <tr>
                    <td>
                        <asp:GridView ID="grdDepartment" runat="server" OnSelectedIndexChanged="grdDepartment_SelectedIndexChanged"></asp:GridView>
                    </td>
                </tr>
                
                <tr>
                    <td>
                        <asp:TextBox ID="DeptNumber" runat="server" OnTextChanged="DeptDetails_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:TextBox ID="DeptName" runat="server" OnTextChanged="DeptDetails_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:TextBox ID="Location" runat="server" OnTextChanged="DeptDetails_TextChanged"></asp:TextBox>
                    </td>
                </tr>
               
            </table>
       
        </div>
    </form>
</body>
</html>
