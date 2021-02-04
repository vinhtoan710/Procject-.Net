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
    public partial class MatSachChiTiet : System.Web.UI.Page
    {

        string address = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
        D:\ASP.net\baitapnhom\BANSACH\BANSACH\BANSACH\App_Data\BANSACH.mdf;Integrated Security=True";


        protected void Page_Load(object sender, EventArgs e)
        {

            if (Page.IsPostBack) return;
            if (Request.Cookies["TENDANGNHAP"] == null)
            {
                this.Label5.Text = "Anh Long phải đăng nhâp để xem mặt hàng";
                return;
            }

            if (Context.Items["ms"] == null) return;

            string masach = Context.Items["ms"].ToString();

            try
            {
                string q = "select * from SACH where MASACH='"+masach+"'";

                SqlDataAdapter sqlD = new SqlDataAdapter(q,address);

                DataTable dt = new DataTable();
                sqlD.Fill(dt);

                this.DataList1.DataSource = dt;
                this.DataList1.DataBind();

            }
            catch (SqlException ex)
            {
                Response.Write(ex.Errors);
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button mua = ((Button)sender);

            string masach = mua.CommandArgument.ToString();
            DataListItem item = (DataListItem)mua.Parent;

            string soluong = ((TextBox)item.FindControl("Textbox1")).Text;

            if (Request.Cookies["TENDANGNHAP"] == null) return;

            string ten = Request.Cookies["TENDANGNHAP"].Value;

            SqlConnection sqlC = null;
            try
            {
                sqlC = new SqlConnection(address);
                sqlC.Open();
                string q = "select * from DONHANG where TENDANGNHAP='" + ten + "' and MASACH='" + masach + "'";

                SqlCommand sqlcommand = new SqlCommand(q, sqlC);
                SqlDataReader sqlR = sqlcommand.ExecuteReader();
                if (sqlR.Read())
                {
                    sqlR.Close();
                    sqlcommand = new SqlCommand("Update DONHANG set SOLUONG=SOLUONG+'" + soluong + "' where TENDANGNHAP='" + ten + "' and MASACH='" + masach + "'", sqlC);


                }
                else
                {
                    sqlR.Close();
                    sqlcommand = new SqlCommand("Insert into DONHANG (TENDANGNHAP,MASACH,SOLUONG) values ('" + ten + "','" + masach + "','" + soluong + "')", sqlC);
                }
                sqlcommand.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                Response.Write(ex.Errors);

            }
            finally { sqlC.Close(); };

        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            
            Server.Transfer("GioHang.aspx");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Server.Transfer("MatHang.aspx");
        }
    }
}