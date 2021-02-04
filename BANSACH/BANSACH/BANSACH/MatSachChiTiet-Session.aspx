<%@ Page Title="" Language="C#" MasterPageFile="~/MATSACH.Master" AutoEventWireup="true" CodeBehind="MatSachChiTiet-Session.aspx.cs" Inherits="BANSACH.MatSachChiTiet_Session" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:DataList ID="DataList1" runat="server" DataKeyField="MASACH" OnSelectedIndexChanged="DataList1_SelectedIndexChanged">
        <ItemTemplate>
            <div id="tong">
                <div id="mid-left">
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Giỏ hàng</asp:LinkButton>
                </div>

                
                    
                <asp:Image ID="Image1" runat="server" ImageUrl='<%#"~/Hinh/"+Eval("HINH") %>' Width="100px" Height="150px"/>
                

                <div id="mid-right">
                    <p>TÊN SÁCH: <asp:Label ID="Label1" runat="server" Text='<%#Eval("TENSACH") %>'></asp:Label></p>
                    <p>MÔ TẢ: <asp:Label ID="Label2" runat="server" Text='<%#Eval("MOTA") %>'></asp:Label></p>
                    <p>ĐƠN GIÁ: <asp:Label ID="Label3" runat="server" Text='<%#Eval("DONGIA") %>'></asp:Label></p>
                    <p>THỂ LOẠI: <asp:Label ID="Label4" runat="server" Text='<%#Eval("MALOAI") %>'></asp:Label></p>
                    <p>SỐ LƯỢNG: <br /><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="Button1" runat="server" Text="MUA" OnClick="Button1_Click" /></p>
                    
                    
                </div>
            </div>
        </ItemTemplate>


    </asp:DataList>

    <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [MASACH], [TENSACH], [MOTA], [DONGIA], [MALOAI], [HINH] FROM [SACH]"></asp:SqlDataSource>


</asp:Content>
