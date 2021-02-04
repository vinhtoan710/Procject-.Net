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
    public partial class MatSachChiTiet_Session : System.Web.UI.Page
    {
        string address = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
        D:\ASP.net\baitapnhom\BANSACH\BANSACH\BANSACH\App_Data\BANSACH.mdf;Integrated Security=True";
        DataTable dt;
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
                string q = "select * from SACH where MASACH='" + masach + "'";

                SqlDataAdapter sqlD = new SqlDataAdapter(q, address);

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
        private void TaoGio() {
            dt = new DataTable();
            dt.Columns.Add("MASACH");
            dt.Columns.Add("SOLUONG");
            dt.Columns.Add("DONGIA");
            Session["GIOHANG"] = dt;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Server.Transfer("GioHang.aspx");
        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["TENDANGNHAP"] == null) return;
            Button mua = (Button)sender;
            string mahang = mua.CommandArgument.ToString();
            DataListItem item = (DataListItem)mua.Parent;
            string soluong = ((TextBox)item.FindControl("TextBox1")).Text;
            string dongia = ((Label)item.FindControl("Label3")).Text;
            dt = (DataTable)Session["GIOHANG"]; bool tim = false;
            if (dt == null) TaoGio();
            foreach (DataRow dataRow in dt.Rows)
            {
                if (dataRow["MASACH"].Equals(mahang))
                {
                    dataRow["SOLUONG"] = Convert.ToInt32(dataRow["SOLUONG"]) + Convert.ToInt32(soluong);
                    tim = true;
                    break;
                }
            }
            if (!tim)
            {
                DataRow dataRow = dt.NewRow();
                dataRow["MAHANG"] = mahang;
                dataRow["SOLUONG"] = soluong;
                dataRow["DONGIA"] = dongia;
                dt.Rows.Add(dataRow);
            }
            Session["GIOHANG"] = dt;

            
        }
    }
    }
