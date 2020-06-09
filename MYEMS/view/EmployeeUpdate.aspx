<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeUpdate.aspx.cs" Inherits="MYEMS.view.EmployeeUpdate" %>

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
        .auto-style1 {
            left: 0;
            right: 0;
            top: 0;
        }
    </style>
    <link href="assets/css/dashboard.css" rel="stylesheet"/>
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
                        <a class="nav-link" href="#">
                            <span data-feather="users"></span>
                            部门管理
                        </a>
                    </li>
                </ul>
            </div>
        </nav>
         <main role="main" class="col-md-9 ml-sm-auto col-lg-10 px-4">
             <h1 class="h2">员工修改</h1><br />
                <form id="form1" runat="server">
                    <table class="table table-striped table-sm">
                        <tr>
                            <th><label for="exampleFormControlInput2" >ID</label></th>
                            <td><input type="text" name="emp_id"  value="<%=emp.Emp_id%>" id="exampleFormControlInput2" /></td>
                        </tr>
                        <tr>
                            <th><label for="exampleFormControlInput1">编号</label></th>
                            <td> <input type="text" name="emp_no" value="<%=emp.Emp_no %>" id="exampleFormControlInput1"  /></td>
                        </tr>
                        <tr>
                            <th><label for="exampleFormControlInput3">姓名</label></th>
                            <td><input type="text" name="emp_name" value="<%=emp.Emp_name %>" id="exampleFormControlInput3" /></td>
                        </tr>
                        <tr>
                            <th><label for="exampleFormControlInput4">电话号码</label></th>
                            <td><input type="text" name="emp_mobile" value="<%=emp.Emp_mobile %>" id="exampleFormControlInput4" /></td>
                        </tr>
                        <tr>
                            <th><label for="exampleFormControlInput5">密码</label></th>
                            <td><input type="text" name="emp_pwd" value="<%=emp.Emp_pwd %>" id="exampleFormControlInput5" /></td>
                        </tr>
                        <tr>
                            <th><label>是否为管理员</label></th>
                            <td>
                                <div class="form-check">
                                    <input class="form-check-input" type="radio"  id="defaultCheck1" name="manager" value="true" checked="checked"/>
                                    <label class="form-check-label" for="defaultCheck1">
                                        是
                                    </label>
                                </div>
                                 <div class="form-check">
                                    <input class="form-check-input" type="radio"  id="defaultCheck2" name="manager" value="false" checked="<%=checkManager(emp.Emp_is_manager.ToString())%>"/>
                                    <label class="form-check-label" for="defaultCheck2">
                                        否
                                    </label>
                                </div>
                            </td>
                        </tr>
                    </table>
         
                        <%
                            string checkManager(string b)
                            {
                                if (b == "True")
                                    return "checked";
                                else
                                    return "unchecked";
                            }
                            %>
                    <%=checkManager(emp.Emp_is_manager.ToString()) %>
               </form>
              <p style="color:red"><%=msg%></p>
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
