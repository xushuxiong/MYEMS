<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="update.aspx.cs" Inherits="MYEMS.update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        ID:<input type="text" name="emp_id"  value="<%=emp.Emp_id%>"/><br />
        编号：<input type="text" name="emp_no" value="<%=emp.Emp_no %>" /><br />
        姓名：<input type="text" name="emp_name" value="<%=emp.Emp_name %>" /><br />
        电话号码：<input type="text" name="emp_mobile" value="<%=emp.Emp_mobile %>"/><br />
        密码：<input type="text" name="emp_pwd" value="<%=emp.Emp_pwd %>" /><br />
        是否为管理员：<input type="text" name="emp_is_manager" value="<%=emp.Emp_is_manager%>"/><br />
    </form>
    <p style="color:red"><%=msg%></p>
</body>
</html>
