<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MYEMS.view.index1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
 <head>
     <title></title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    
    <link rel="canonical" href="https://getbootstrap.com/docs/4.4/examples/dashboard/">
    <link rel='stylesheet' href='assets/css/split.css' type='text/css' media='screen' />
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
             <h1 class="h2">网站介绍</h1><br />
                <div class="container">
                    <div class="row">
                        <div class="col-sm-12  col-md-9">
                            <h5>About Me....</h5>
                            <div class="fakeimg" class="col-sm-9">
                                <img src="assets/img/my1.jpg" height="350px" width="480px" />
                            </div><br /><br />
                            <p>本人是肇庆学院17届网络工程的一名学生，在学习了asp.net之后，通过近一个星期的时间完成了这个网站，Baer设备管理系统,本系统可以
                                进行设备的管理，人员管理以及部门管理，提同时不同权限的用户可以执行的操作是不一样的，管理员可以进行所有的操作，而非管理员只能
                                进行查询。当然本系统还有不太完善的地方，比如页面真的很丑，但是本人花了较多时间用于处理后台逻辑。
                            </p>
                        </div>
                    </div>
                </div>
 
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
