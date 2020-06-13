<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DepartmentIndex.aspx.cs" Inherits="MYEMS.view.DepartmentIndex" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
  <head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    
    <link rel="canonical" href="https://getbootstrap.com/docs/4.4/examples/dashboard/">
    <link href="assets/css/bootstrap.min.css" rel="stylesheet"  crossorigin="anonymous">
    
    <meta name="msapplication-config" content="assets/img/favicons/browserconfig.xml">
    <meta name="theme-color" content="#563d7c">
    <style>
        .bd-placeholder-img {
            font-size: 1.125rem;
            text-anchor: middle;
            -webkit-user-select: none;
            -moz-user-select: none;
            -ms-user-select: none;
            user-select: none;
        }

        @media (min-width: 768px) {
            .bd-placeholder-img-lg {
                font-size: 3.5rem;
            }
        }
    </style>
    <link href="assets/css/dashboard.css" rel="stylesheet">
</head>
<body>


<div class="container-fluid">
    <div class="row" >
        <nav class="col-md-2 d-none d-md-block bg-light sidebar" id="sidebar">
            <div class="sidebar-sticky">
                <ul class="nav flex-column">
                    <li class="nav-item">
                        <a class="nav-link " href="index.aspx">
                            <span data-feather="home"></span>
                            主页 <span class="sr-only">(current)</span>
                        </a>
                    </li>
                    <li class="nav-item dropdown">
                        <a class="nav-link " href="EmployeeIndex.aspx">
                            <span data-feather="users"></span>
                            员工管理
                        </a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="EquipmentIndex.aspx">
                            <span data-feather="shopping-cart"></span>
                            设备管理
                        </a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="DepartmentIndex.aspx">
                            <span data-feather="users"></span>
                            部门管理
                        </a>
                    </li>
                </ul>
            </div>
        </nav>
         <main role="main" class="col-md-9 ml-sm-auto col-lg-10 px-4">
             <h1 class="h2">部门管理</h1><br />
        <h2>
            <a class="btn btn-sm btn-success" href="DepartmentAdd.aspx">添加</a>
            <a class="btn btn-sm btn-info" href="DepartmentQuery.aspx">查询</a>
        </h2>
        <form id="form1" runat="server">
        <table class="table table-striped table-sm">
            <thead>
            <tr>
                <th>ID</th>
                <th>部门编号</th>
                <th>部门名字</th>
                <th>部门经理</th>
                <th>操作</th>
            </tr>
            </thead>
            <tbody>
              <%
            for(int i = 0; i < page.PT1.Count; i++)
            {
                %>
            <tr>
                <td><%=page.PT1[i].Dept_id %></td>
                <td><%=page.PT1[i].Dept_no %></td>
                <td><%=page.PT1[i].Dept_name %></td>
                <td><%=(employeeService.selectEmployeeByNo(page.PT1[i].Dept_manager)).Emp_name %></td>
                 <td>
                    <input type="radio" hidden="hidden" checked="checked" name="del_no" value="<%=page.PT1[i].Dept_no %>"/>
                    <asp:Button ID="Button9" runat="server" Text="删除" class="btn btn-sm btn-danger deleteBtn" OnClick="Button9_Click"/>
                    <a href="DepartmentUpdate.aspx?dept_no=<%= page.PT1[i].Dept_no%>" class="btn btn-sm btn-primary">修改</a>
                </td>
            </tr>
       <%
            }

              %>
            </tbody>
        </table>
            <center>
                <asp:Button ID="Button1" runat="server" Text="首页" OnClick="Button1_Click" />
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="上一页" />
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="下一页" />
                <asp:Button ID="Button4" runat="server" Text="尾页" OnClick="Button4_Click" />
            </center>
       
            </form>
            <p style="color:red"><%=error%></p>
    </main>
    </div>
</div>
<script src="assets/js/jquery-3.4.1.slim.min.js"></script>
<script>window.jQuery || document.write('<script src="assets/js/vendor/jquery.slim.min.js"><\/script>')</script>
<script src="assets/js/bootstrap.bundle.min.js" ></script>
<script src="assets/js/feather.min.js"></script>
<script src="assets/js/Chart.min.js"></script>
<script src="assets/js/dashboard.js"></script>
</body>
</html>
