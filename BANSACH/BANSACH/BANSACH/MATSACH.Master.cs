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
    public partial class MATSACH : System.Web.UI.MasterPage
    {
        string address = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
        D:\ASP.net\baitapnhom\BANSACH\BANSACH\BANSACH\App_Data\BANSACH.mdf;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            string sql = "select * from LOAISACH";
            try
            {

                SqlDataAdapter sqlD = new SqlDataAdapter(sql, address);
                DataTable dt = new DataTable();

                sqlD.Fill(dt);
                DataList1.DataSource = dt;
                DataList1.DataBind();

            }
            catch (SqlException ex)
            {
                Response.Write(ex.Errors);
            }
           
        }



        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string maloai = ((LinkButton)sender).CommandArgument;
            Context.Items["ml"] = maloai;
            Server.Transfer("MatHang.aspx");
        }

        public void CheckLogin()
        {
            
            if (Request.Cookies["TENDANGNHAP"] == null)
            {

                return;
            }
            else
            {
                this.Visible = false;
            }
        }
    }
}