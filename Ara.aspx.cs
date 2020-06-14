using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using DiziYorumProje.Entity;
using System.Web.WebSockets;

namespace DiziYorumProje.AdminSayfalar
{
    public partial class Ara : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

            string Kelime = Request.QueryString["q"].ToString();
            SqlConnection con = new SqlConnection("Data Source=CRIMSONLADY\\SQLEXPRESS;Initial Catalog=BlogDizi; Integrated Security=True;");

            SqlDataAdapter da = new SqlDataAdapter("Select* from TBLBLOG where BLOGBASLIK like  '%" + Kelime + "%'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Repeater11.DataSource = dt;
            Repeater11.DataBind();
        }
    }
}