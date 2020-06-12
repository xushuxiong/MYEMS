<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MYEMS.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       //asp:Image 控件
        <div>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/lmage_4.jpeg" Width="150" Height="170"/>  
        </div>


        <div>
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <asp:Label ID="lbl" runat="server" Text="Label"></asp:Label>
            <asp:Button ID="Button1" runat="server" Text="上传" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
