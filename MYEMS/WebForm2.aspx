<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="MYEMS.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table border="1">
            <tr>
                <th>ID</th>
                <th>编号</th>
                <th>姓名</th>
                <th>密码</th>
                <th>电话号码</th>
                <th>是否为管理员</th>
            </tr>
        <%
            for (int i = 0; i < page1.PT1.Count; i++)
            {
                %>
            <tr>
                <td><%=page1.PT1[i].Emp_id %></td>
                <td><%=page1.PT1[i].Emp_no %></td>
                <td><%=page1.PT1[i].Emp_name %></td>
                <td><%=page1.PT1[i].Emp_pwd %></td>
                <td><%=page1.PT1[i].Emp_mobile %></td>
                <td><%=page1.PT1[i].Emp_is_manager %></td>
                <td>
                    <asp:Button ID="Button9" runat="server" Text="删除" />
                    <!--<asp:Button ID="Button10" runat="server" Text="修改"  OnClick="Button10_Click" />-->
                    <a href="update.aspx?emp_no=<%= page1.PT1[i].Emp_no%>">修改</a>
                </td>
                <!--<td><input type="hidden" value="<%=page1.PT1[i].Emp_no %>" name="emp_no"/></td>-->
            </tr>
        <%
            }
            %>

        </table>
        <asp:Button ID="Button5" runat="server" Text="首页" OnClick="Button5_Click" />
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="上一页" />
        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="下一页" />
        <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="尾页" />
        <br />
        <table>
            <tr>
                <th>部门ID</th>
                <th>部门编号</th>
                <th>部门名字</th>
                <th>部门经理</th>
            </tr>
        <%
            for(int i = 0; i < page.PT1.Count; i++)
            {
                %>
            <tr>
                <td><%=page.PT1[i].Dept_id %></td>
                <td><%=page.PT1[i].Dept_no %></td>
                <td><%=page.PT1[i].Dept_name %></td>
                <td><%=page.PT1[i].Dept_manager %></td>
            </tr>
       <%
            }

              %>
        </table>
        <asp:Button ID="Button1" runat="server" Text="首页" OnClick="Button1_Click" />


        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="上一页" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="下一页" />
        <asp:Button ID="Button4" runat="server" Text="尾页" OnClick="Button4_Click" />
        <p style="color:red"><%=error%></p>

    </form>
</body>
</html>
