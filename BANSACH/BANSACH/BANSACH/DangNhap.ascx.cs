using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BANSACH
{
    public partial class DangNhap : System.Web.UI.UserControl
    {
        string address = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
        D:\ASP.net\baitapnhom\BANSACH\BANSACH\BANSACH\App_Data\BANSACH.mdf;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "Username")
                txtTaiKhoan.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ten = this.txtTaiKhoan.Text;
            string matkhau = this.txtMatKhau.Text;


            string sql = "select * from TAIKHOAN where TENDANGNHAP='" + ten + "' and MATKHAU='" + matkhau + "'";

            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter sqlD = new SqlDataAdapter(sql, address);
                sqlD.Fill(dt);

            }
            catch (SqlException ex)
            {
                Response.Write("<b>Error</b>" + ex.Message + "<p/>");
            }
            if (dt.Rows.Count != 0)
            {
                Response.Cookies["TENDANGNHAP"].Value = ten;
                
                Server.Transfer("MatHang.aspx");
                
            }
            else
            {
                this.Label1.Text = "Tên đăng nhập hay mật khẩu không đúng!";
            }
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
           
        }

        public void CheckLogin()
        {
            if (Request.Cookies["TENDANGNHAP"] == null)
                return;
            else
            {
                this.Visible = false;
            }
        }

    }
}