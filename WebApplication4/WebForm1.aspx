<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication4.WebForm1" %>

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
                        <td>EMPLOYEE DETAILS : </td>
                          <td>&nbsp;</td>                        
                    </tr>
                    <tr>
                        <td>Employee Number :
                            <asp:TextBox ID="txtEmpno" runat="server"></asp:TextBox></td>
                       <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>Employee Name :
                          <asp:TextBox ID="txtEname" runat="server"></asp:TextBox></td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            Job :
                            <asp:TextBox ID="txtJob" runat="server"></asp:TextBox></td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                         <td>
                            Manager :
                            <asp:TextBox ID="txtMgr" runat="server" ></asp:TextBox></td>
                         <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>HireDate :
                           <%--<asp:TextBox ID="txtHiredate" runat="server" OnTextChanged="txtHiredate_TextChanged"></asp:TextBox>--%>
                            <asp:Calendar ID="CalHiredate" runat="server" ></asp:Calendar>                            
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            Salary :
                            <asp:TextBox ID="txtSalary" runat="server" ></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Comm :
                            <asp:TextBox ID="txtComm" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Departments:
                            <asp:DropDownList ID="ddlDeptname" runat="server"  OnLoad="Page_Load"></asp:DropDownList>
                        </td>
                    </tr>
                    
                    <tr>
                        <td>Email :
                            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                       <td>
                           <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                       </td>
                   </tr>
                   <%-- <tr>
                        <td>
                            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click1" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
                        </td>
                    </tr>--%>
                    <tr>
                        <td>
                            <asp:Button ID="btnAddEmp" runat="server" Text="Add Employee" OnClick="btnAddEmp_Click" />
                        </td>
                    </tr>                    
                    <tr>
                        <td>
                            <asp:Button ID="btnRedirect" runat="server" Text="Redirect" OnClick="btnRedirect_Click" />
                        </td>
                    </tr>
                </table>  
      
        </div>
    </form>
</body>
</html>
