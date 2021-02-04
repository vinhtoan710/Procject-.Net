<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDangnhap.aspx.cs" Inherits="BANSACH.frmDangnhap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="DangNhap.css" rel="stylesheet"/>
</head>
<body>
    <form class="box" action="frmDangnhap.aspx" runat="server">
        <div class="containter">
            <span class="text1">Welcome to</span>
            <br />
            <span class="text2">Book store</span>
        </div>

        <h1>Login</h1>
        
        <asp:TextBox ID="txtTaiKhoan" runat="server" Text="Username"></asp:TextBox>
        <asp:TextBox ID="txtMatKhau" runat="server" Text="Password" TextMode="Password"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
        
        <asp:Label ID="Label1" runat="server" ForeColor="#FF5050"></asp:Label>    
        
        

    </form>
</body>
</html>
