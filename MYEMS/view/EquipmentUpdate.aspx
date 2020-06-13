<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EquipmentUpdate.aspx.cs" Inherits="MYEMS.view.EquipmentUpdate" %>

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
    <link href="assets/css/dashboard.css" rel="stylesheet"/>
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
             <h1 class="h2">设备修改</h1><br />
                <form id="form1" runat="server">
                    <table class="table table-striped table-sm">
                        <tr>
                            <th><label for="exampleFormControlInput2" >ID</label></th>
                            <td><input type="text" name="equ_id"  value="<%=equ.Equ_id%>" id="exampleFormControlInput2" readonly="readonly" /></td>
                        </tr>
                        <tr>
                            <th><label for="exampleFormControlInput1">编号</label></th>
                            <td> <input type="text" name="equ_no" value="<%=equ.Equ_no%>" id="exampleFormControlInput1"  readonly="readonly"/></td>
                        </tr>
                        <tr>
                            <th><label for="exampleFormControlInput3">设备名称</label></th>
                            <td><input type="text" name="equ_name" value="<%=equ.Equ_name %>" id="exampleFormControlInput3" /></td>
                        </tr>
                         <tr>
                            <th><label for="exampleFormControlInput4">设备型号</label></th>
                            <td><input type="text" name="equ_specification" value="<%=equ.Equ_specification %>" id="exampleFormControlInput4" /></td>
                        </tr>
                         <tr>
                            <th><label for="exampleFormControlInput5">设备价格</label></th>
                            <td><input type="text" name="equ_price" value="<%=equ.Equ_price %>" id="exampleFormControlInput5" /></td>
                        </tr>
                        <tr>
                            <th><label for="exampleFormControlInput6">设备地点</label></th>
                            <td><input type="text" name="equ_position" value="<%=equ.Equ_position %>" id="exampleFormControlInput6" /></td>
                        </tr>
                        <tr>
                            <th><label>设备负责人</label></th>
                             <td>
                                <select name="equ_emp" id="equ_emp">
                                    <option value="<%=equ.Equ_emp%>"><%=equ.Equ_emp%></option>
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
                        <tr>
                            <th><label >设备图片</label></th>
                            <td>
                                <asp:Image ID="Image1" runat="server"  Width="150" Height="170"/>
                                <asp:FileUpload ID="FileUpload1" runat="server"  />
                            </td>
                        </tr>
                    </table>
                    <asp:Button ID="Button1" runat="server" Text="修改" OnClick="Button1_Click1" />
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
