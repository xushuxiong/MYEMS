<%@ Page Title="" Language="C#" MasterPageFile="~/view/public.Master" AutoEventWireup="true" CodeBehind="index1.aspx.cs" Inherits="MYEMS.view.index1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   <main role="main" class="col-md-9 ml-sm-auto col-lg-10 px-4">
             <h1 class="h2">员工管理</h1><br />
        <h2>
            <a class="btn btn-sm btn-success" href="emp">添加</a>
        </h2>
        <form id="form1" runat="server">
        <table class="table table-striped table-sm">
            <thead>
            <tr>
                <th>ID</th>
                <th>编号</th>
                <th>姓名</th>
                <th>密码</th>
                <th>电话号码</th>
                <th>是否为管理员</th>
                <th>操作</th>
            </tr>
            </thead>
            <tbody>
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
                    <a href="update.aspx?emp_no=<%= page1.PT1[i].Emp_no%>" class="btn btn-sm btn-primary">修改</a>
                </td>
            </tr>
        <%
            }
            %>

            </tbody>
        </table>
            <center>
                <asp:Button ID="Button5" runat="server" Text="首页" OnClick="Button5_Click" />
                <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="上一页" />
                <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="下一页" />
                <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="尾页" />
            </center>
       
            </form>
    </main>
<!--    <form method="post" id="deleteForm" >-->
<!--        <input type="hidden" name="_method" value="DELETE"/>-->
<!--    </form>-->
</asp:Content>
