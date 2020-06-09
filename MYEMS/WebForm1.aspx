<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MYEMS.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" AllowPaging="True">
            <Columns>
                <asp:BoundField DataField="Emp_id" HeaderText="Emp_id" SortExpression="Emp_id" />
                <asp:BoundField DataField="Emp_no" HeaderText="Emp_no" SortExpression="Emp_no" />
                <asp:BoundField DataField="Emp_name" HeaderText="Emp_name" SortExpression="Emp_name" />
                <asp:BoundField DataField="Emp_mobile" HeaderText="Emp_mobile" SortExpression="Emp_mobile" />
                <asp:CheckBoxField DataField="Emp_is_manager" HeaderText="Emp_is_manager" SortExpression="Emp_is_manager" />
                <asp:BoundField DataField="Emp_dept" HeaderText="Emp_dept" SortExpression="Emp_dept" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="selectAllEmployee" TypeName="MYEMS.service.impl.EmployeeServiceImpl"></asp:ObjectDataSource>
    </form>
</body>
</html>
