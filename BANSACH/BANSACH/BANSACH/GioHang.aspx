<%@ Page Title="" Language="C#" MasterPageFile="~/MATSACH.Master" AutoEventWireup="true" CodeBehind="GioHang.aspx.cs" Inherits="BANSACH.GioHang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" Width="550px" AutoGenerateColumns="False" DataKeyNames="MASACH">
        <Columns>
            <asp:BoundField DataField="MASACH" HeaderText="Mã sách" />
            <asp:BoundField DataField="TENSACH" HeaderText="Tên sách"/>
            <asp:BoundField DataField="MOTA" HeaderText="Mô tả"/>
            <asp:BoundField DataField="DONGIA" HeaderText="Đơn giá"/>
            
            
        </Columns>
    </asp:GridView>
    
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [MASACH], [TENSACH], [MOTA], [DONGIA], [MALOAI] FROM [SACH]"></asp:SqlDataSource>
    
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
</asp:Content>
