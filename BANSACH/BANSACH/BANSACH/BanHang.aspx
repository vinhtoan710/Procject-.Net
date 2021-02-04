<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BanHang.aspx.cs" Inherits="BANSACH.BanHang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="BanSach.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">

        <div id="outer">
                <div id="header">
                    <h2>Books are powerful</h2>                    
                </div>
                <div id="menu">
                    <asp:HyperLink ID="HyperLink1" runat="server">Trang chủ</asp:HyperLink>
                    <asp:HyperLink ID="HyperLink2" runat="server">Giới thiệu</asp:HyperLink>
                    <asp:HyperLink ID="HyperLink3" runat="server">Sách</asp:HyperLink>
                    <asp:HyperLink ID="HyperLink4" runat="server">Hỗ trợ</asp:HyperLink>
                    
                    <input type="text" placeholder="Tìm kiếm"/>
                </div>
                

                <div id="content">
                    <div id="left" style="float:left">
                        <h3>Thể loại</h3>
                        <br />
                        <asp:DataList ID="DataList1" runat="server" DataKeyField="MALOAI" >
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" Text='<%#Eval("TENLOAI") %>'></asp:LinkButton>
                            </ItemTemplate>

                        </asp:DataList>
                        
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [MALOAI], [TENLOAI] FROM [LOAISACH]"></asp:SqlDataSource>
                        
                    </div>
                    <div id="right" style="float:right">

                    </div>
                    <div id="mid">

                    </div>
                </div>
            </div>
        <div id="footer">
            <h3>Copyright &copy NHÓM FAN ANH ĐÔNG</h3>
        </div>
    </form>
</body>
</html>
