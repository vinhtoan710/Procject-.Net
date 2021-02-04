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
    public partial class BanHang : System.Web.UI.Page
    {
        string address = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
        D:\ASP.net\baitapnhom\BANSACH\BANSACH\BANSACH\App_Data\BANSACH.mdf;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            string sql = "select * from LOAISACH";
            try
            {
                
                SqlDataAdapter sqlD = new SqlDataAdapter(sql,address);
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
    }
}