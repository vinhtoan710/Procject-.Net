<%@ Page Title="" Language="C#" MasterPageFile="~/MATSACH.Master" AutoEventWireup="true" CodeBehind="GioHangXoaSua.aspx.cs" Inherits="BANSACH.GioHangXoaSua" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">         
        <Columns>             
            <asp:TemplateField HeaderText="Xóa">                 
                <ItemTemplate>                     
                    <asp:CheckBox ID="CheckBox1" runat="server" />                     
                    <asp:HiddenField ID="HiddenField1" runat="server" Value='<%# Eval("MASACH") %>' />                 

                </ItemTemplate>             

            </asp:TemplateField>
             <asp:BoundField DataField="TENSACH" HeaderText="Tên sách" />             
            <asp:BoundField DataField="MOTA" HeaderText="Mô tả" />             
            <asp:BoundField DataField="DONGIA" HeaderText="Đơn giá" />             
            <asp:TemplateField HeaderText="Số lượng">                 
                <ItemTemplate>                     
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("SOLUONG") %>'></asp:TextBox>                 

                </ItemTemplate>             

            </asp:TemplateField>             
            <asp:BoundField DataField="thanhtien" HeaderText="Thành tiền" />         

        </Columns>
        </asp:GridView>     
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br /> 
    &nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Xóa" /> 
    &nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Sửa" /> 
</asp:Content>
