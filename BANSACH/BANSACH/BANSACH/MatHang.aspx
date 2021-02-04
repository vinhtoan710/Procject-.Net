<%@ Page Title="" Language="C#" MasterPageFile="~/MATSACH.Master" AutoEventWireup="true" CodeBehind="MatHang.aspx.cs" Inherits="BANSACH.MatHang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    &nbsp;&nbsp;&nbsp;    <asp:DataList ID="DataList1" runat="server" DataKeyField="MASACH" RepeatColumns="2" OnSelectedIndexChanged="DataList1_SelectedIndexChanged">
        <ItemTemplate>
            <div class="image">
            <asp:ImageButton ID="ImageButton1" runat="server"  CommandArgument='<%#Eval("MASACH") %>' ImageUrl='<%#"~/Hinh/"+Eval("HINH") %>' Width="100px" Height="100px" OnClick="ImageButton1_Click"/>
            </div>
            <div class="content-link" >
                
                <ul>
                    <li><asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("MASACH") %>' Text='<%#Eval("TENSACH") %>' OnClick="LinkButton1_Click1"></asp:LinkButton></li>
                    <li><asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%#Eval("MASACH") %>' OnClick="LinkButton2_Click1">Chi tiet...</asp:LinkButton></li>
                </ul>
                
                
            </div>
        </ItemTemplate>

    </asp:DataList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [MASACH], [TENSACH], [HINH] FROM [SACH]"></asp:SqlDataSource>
</asp:Content>
