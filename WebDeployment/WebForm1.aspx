<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebDeployment.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            My First web page Deployment
            <asp:GridView ID="GridView1" runat="server"  AutoGenerateColumns="False" DataKeyNames="EMPNO" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="EMPNO" HeaderText="EMPNO" ReadOnly="True" SortExpression="EMPNO"></asp:BoundField>
                    <asp:BoundField DataField="ENAME" HeaderText="ENAME" SortExpression="ENAME"></asp:BoundField>
                    <asp:BoundField DataField="SAL" HeaderText="SAL" SortExpression="SAL"></asp:BoundField>
                    <asp:BoundField DataField="JOB" HeaderText="JOB" SortExpression="JOB"></asp:BoundField>
                    <asp:BoundField DataField="DEPTNO" HeaderText="DEPTNO" SortExpression="DEPTNO"></asp:BoundField>
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString="<%$ ConnectionStrings:ScottdbConnectionString %>" ProviderName="<%$ ConnectionStrings:ScottdbConnectionString.ProviderName %>" SelectCommand="SELECT [EMPNO], [ENAME], [SAL], [JOB], [DEPTNO] FROM [EMP]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
