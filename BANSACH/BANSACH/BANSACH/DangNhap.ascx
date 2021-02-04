<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DangNhap.ascx.cs" Inherits="BANSACH.DangNhap" %>
<form id="myLogin">
    <h1>Login</h1>
        
        <asp:TextBox ID="txtTaiKhoan" runat="server" Text="Username" OnTextChanged="txtTaiKhoan_TextChanged" placeholder="hint"></asp:TextBox>
        <asp:TextBox ID="txtMatKhau" runat="server" Text="Password" TextMode="Password"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
        
    <asp:Label ID="Label1" runat="server" ForeColor="#FF5050"></asp:Label>
</form>