﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeQueryInfo.aspx.cs" Inherits="MYEMS.view.EmployeeQueryInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
  <head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    
    <link rel="canonical" href="https://getbootstrap.com/docs/4.4/examples/dashboard/">
    <link href="assets/css/bootstrap.min.css" rel="stylesheet"  crossorigin="anonymous"/>
    
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
    <nav class="navbar navbar-dark fixed-top bg-dark flex-md-nowrap p-0 shadow">
        <a class="navbar-brand col-sm-3 col-md-2 mr-0" href="#"></a>
        <input class="form-control form-control-dark w-100" type="text" placeholder="Search" aria-label="Search"/>
        <ul class="navbar-nav px-3">
            <li class="nav-item text-nowrap">
                <a class="nav-link" href="#">Sign out</a>
            </li>
        </ul>
    </nav>

<div class="container-fluid">
    <div class="row" >
        <nav class="col-md-2 d-none d-md-block bg-light sidebar" id="sidebar">
            <div class="sidebar-sticky">
                <ul class="nav flex-column">
                    <li class="nav-item">
                        <a class="nav-link active" href="#">
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
                        <a class="nav-link" href="#">
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
             <h1 class="h2">查询结果</h1><br />
        <form id="form1" runat="server">
        <table class="table table-striped table-sm">
            <thead>
            <tr>
                <th>ID</th>
                <th>编号</th>
                <th>姓名</th>
                <th>密码</th>
                <th>所在部门</th>
                <th>电话号码</th>
                <th>是否为管理员</th>
                <th>操作</th>
            </tr>
            </thead>
            <tbody>
              <%
            for (int i = 0; i < emps.Count; i++)
            {
                %>
            <tr>
                <td><%=emps[i].Emp_id %></td>
                <td><%=emps[i].Emp_no %></td>
                <td><%=emps[i].Emp_name %></td>
                <td><%=emps[i].Emp_pwd %></td>
                <td><%=(departmentService.selectDepartmentByNo(emps[i].Emp_dept)).Dept_name%></td>
                <td><%=emps[i].Emp_mobile %></td>
                <td><%=emps[i].Emp_is_manager %></td>
                <td>
                    <a href="EmployeeUpdate.aspx?emp_no=<%= emps[i].Emp_no%>" class="btn btn-sm btn-primary">修改</a>
                </td>
            </tr>
        <%
            }
            %>

            </tbody>
        </table>
        <p style="color:red"><%=error%></p>
            </form>
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
