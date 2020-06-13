<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EquipmentAdd.aspx.cs" Inherits="MYEMS.view.EquipmentAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml"> 
 <head>
     <title></title>
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
                        <a class="nav-link" href="index.aspx">
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
             <h1 class="h2">设备添加</h1><br />
               <form id="form1" runat="server">
                   <table class="table table-striped table-sm">
                        <tr>
                            <th><label for="exampleFormControlInput1">设备编号</label></th>
                            <td> <input type="text" name="equ_no" placeholder="编号:2019**" id="exampleFormControlInput1" required="required"/></td>
                        </tr>
                        <tr>
                            <th><label for="exampleFormControlInput3">设备名字</label></th>
                            <td><input type="text" name="equ_name"  placeholder="设备名字:***" id="exampleFormControlInput3" required="required" /></td>
                        </tr>
                        <tr>
                            <th><label for="exampleFormControlInput2">设备型号</label></th>
                            <td><input type="text" name="equ_specification"  placeholder="设备型号:***" id="exampleFormControlInput2" required="required" /></td>
                        </tr>
                        <tr>
                            <th><label for="exampleFormControlInput4">设备价格</label></th>
                            <td><input type="text" name="equ_price"  placeholder="设备价格:***" id="exampleFormControlInput4" required="required" /></td>
                        </tr>
                        <tr>
                            <th><label for="exampleFormControlInput5">设备位置</label></th>
                            <td><input type="text" name="equ_position"  placeholder="设备位置:***" id="exampleFormControlInput5" required="required" /></td>
                        </tr>
                        <tr>
                            <th><label >设备图片</label></th>
                            <td>
                                <asp:FileUpload ID="FileUpload1" runat="server"  />
                            </td>
                        </tr>
                        <tr>
                            <th><label>设备负责人</label></th>
                             <td>
                                <select name="equ_emp" id="equ_emp">
                                    <%
                                        for(int i = 0; i < emps.Count; i++)
                                        {
                                            %>
                                     <option value="<%=emps[i].Emp_no %>"><%=emps[i].Emp_name %></option>
                                    <%
                                        }
                                        %>
                                </select>
                            </td>
                        </tr>
                    </table>
                    <asp:Button ID="Button1" runat="server" Text="添加" OnClick="Button1_Click" />
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
