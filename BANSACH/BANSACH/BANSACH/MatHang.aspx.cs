using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace BANSACH
{
    public partial class MatHang : System.Web.UI.Page
    {
        string address = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
        D:\ASP.net\baitapnhom\BANSACH\BANSACH\BANSACH\App_Data\BANSACH.mdf;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            string q;
            if (Context.Items["ml"] == null)
                q = "select * from SACH";
            else
            {
                string maloai = Context.Items["ml"].ToString();
                q = "select * from SACH where MALOAI='"+maloai+"'";
            }
            

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(q,address);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataList1.DataSource = dt;
                DataList1.DataBind();
            }catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
        }



        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            string masach = ((ImageButton)sender).CommandArgument;
            Context.Items["ms"] = masach;
            Server.Transfer("MatSachChiTiet.aspx");

        }

        protected void LinkButton1_Click1(object sender, EventArgs e)
        {
            string masach = ((LinkButton)sender).CommandArgument;
            Context.Items["ms"] = masach;
            Server.Transfer("MatSachChiTiet.aspx");
        }

        protected void LinkButton2_Click1(object sender, EventArgs e)
        {
            string masach = ((LinkButton)sender).CommandArgument;
            Context.Items["ms"] = masach;
            Server.Transfer("MatSachChiTiet-Session.aspx");
        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}