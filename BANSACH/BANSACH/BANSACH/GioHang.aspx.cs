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
    public partial class GioHang : System.Web.UI.Page
    {
        string address = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
        D:\ASP.net\baitapnhom\BANSACH\BANSACH\BANSACH\App_Data\BANSACH.mdf;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string q = "select  DONHANG.MASACH,TENSACH,MOTA,DONGIA,SOLUONG,SOLUONG*DONGIA as THANHTIEN  from DONHANG,MAHANG where SACH.MASACH = DONHANG.MASACH";
                SqlDataAdapter sqlD = new SqlDataAdapter(q, address);
                DataTable dt = new DataTable();
                sqlD.Fill(dt);
                this.GridView1.DataSource = dt;
                this.GridView1.DataBind();
                double tong = 0;
                foreach (DataRow row in dt.Rows)
                {
                    double thanhtien = Convert.ToDouble(row["THANHTIEN"]);
                    tong = tong + thanhtien;
                }

                this.Label1.Text = "Tổng thành tiền: " + tong + " đồng";

            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }

        }
    }
}