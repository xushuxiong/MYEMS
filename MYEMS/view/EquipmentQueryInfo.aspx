<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EquipmentQueryInfo.aspx.cs" Inherits="MYEMS.view.EquipmentQueryInfo" %>

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
                        <a class="nav-link" href="index.apsx">
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
             <h1 class="h2">查询结果</h1><br />
        <form id="form1" runat="server">
            <table class="table table-striped table-sm">
                <thead>
                <tr>
                    <th>ID</th>
                    <th>设备编号</th>
                    <th>设备名字</th>
                    <th>设备型号</th>
                    <th>设备价格</th>
                    <th>设备位置</th>
                    <th>购入日期</th>
                    <th>设备负责人</th>
                    <th>设备负责部门</th>
                    <th>操作</th>
                </tr>
                </thead>
                <tbody>
                  <%
                for(int i = 0; i < equs.Count; i++)
                {
                    %>
                <tr>
                    <td><%=equs[i].Equ_id %></td>
                    <td><%=equs[i].Equ_no %></td>
                    <td><%=equs[i].Equ_name %></td>
                    <td><%=equs[i].Equ_specification %></td>
                    <td><%=equs[i].Equ_price %></td>
                    <td><%=equs[i].Equ_position %></td>
                    <td><%=equs[i].Equ_day.ToString("yyyy-MM-dd ") %></td>
                    <td><%=employeeService.selectEmployeeByNo(equs[i].Equ_emp).Emp_name %></td>
                    <td><%=departmentService.selectDepartmentByNo ((employeeService.selectEmployeeByNo(equs[i].Equ_emp)).Emp_dept).Dept_name %></td>
                     <td>
                        <a href="EquipmentUpdate.aspx?equ_no=<%=equs[i].Equ_no%>" class="btn btn-sm btn-primary">修改</a>
                    </td>
                </tr>
           <%
                }

                  %>
                </tbody>
        </table>
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
