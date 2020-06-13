<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EquipmentDayQuery.aspx.cs" Inherits="MYEMS.view.EquipmentDayQuery" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
head>
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
             <h1 class="h2">设备日期查询</h1><br />
               <form id="form1" runat="server">
                   <table class="table table-striped table-sm">
                        <tr>
                            <th><label>购入年份</label></th>
                            <td>
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="必须输入年份" ForeColor="Red"></asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="年份必须大于1949小于2050" ForeColor="Red" MaximumValue="2050" MinimumValue="1949"></asp:RangeValidator>

                            </td>
                        </tr>
                       <tr>
                            <th><label>购入月份</label></th>
                            <td>
                                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="必须输入月份" ForeColor="Red"></asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="月份必须大于等于1小于等于12" ForeColor="Red" MaximumValue="12" MinimumValue="1"></asp:RangeValidator>

                            </td>
                        </tr>
                       <tr>
                            <th><label>购入天数</label></th>
                            <td>
                                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" Display="Dynamic" ErrorMessage="必须输入天数" ForeColor="Red"></asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="TextBox3" Display="Dynamic" ErrorMessage="日期必须大于等于1小于等于31" ForeColor="Red" MaximumValue="31" MinimumValue="1"></asp:RangeValidator>

                            </td>
                        </tr>
                    </table>
                    <asp:Button ID="Button1" runat="server" Text="查询" OnClick="Button1_Click" />
               </form>
             <%=error %>
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
