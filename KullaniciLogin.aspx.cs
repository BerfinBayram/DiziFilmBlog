﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje
{


    public partial class KullaniciLogin : System.Web.UI.Page
    {
        BlogDiziEntities3 db = new BlogDiziEntities3();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            var sorgu = from x in db.TBLKULLANICI where
                            x.KULLANICI == TextBox1.Text && x.SIFRE == TextBox2.Text
                        select x;
            if (sorgu.Any())
            {
                Session.Add("KULLANICI",TextBox1.Text);
                Response.Redirect("Default.Aspx");
            }
            else
            {
                Response.Write("Hata");
            }
        }
    }
}