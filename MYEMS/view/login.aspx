<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="MYEMS.view.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="assets/css/bootstrap.min.css" rel="stylesheet" crossorigin="anonymous"/>
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
    <link href="assets/css/signin.css" rel="stylesheet">
</head>
<body class="text-center">
    
    <form id="form1" runat="server"  class="form-signin">
        <h1 class="h3 mb-3 font-weight-normal">Baer设备管理系统</h1>
        <img class="mb-4" src="assets/brand/equiment.gif" alt="" width="72" height="72"/>
        <h3 class="h4 mb-4 font-weight-normal">请登录</h3>
        <label for="username" class="sr-only">用户名</label>
        <input type="text" id="username" name="username" class="form-control" placeholder="Username"  required="required"/>
        <label for="inputPassword" class="sr-only">密码</label>
        <input type="password" id="inputPassword" name="password" class="form-control" placeholder="Password" required="required"/>
        <asp:Button ID="Button1" runat="server" Text="登陆" class="btn btn-lg btn-primary btn-block" OnClick="Button1_Click"/>
        <p style="color:red"><%=msg%></p>
    </form>
</body>
</html>
