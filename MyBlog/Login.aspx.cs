using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyBlog
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        DbCvEntities st = new DbCvEntities();

        protected void Button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in st.Admin where x.KullaniciAd == TextBox1.Text && x.Sifre == TextBox2.Text select x;
            if (sorgu.Any())
            {
                Response.Redirect("istatistik.aspx");
            }
            else
            {
                Response.Write("Hatalı Kullanıcı Adı veya Şifre");
            }
        }
    }
}