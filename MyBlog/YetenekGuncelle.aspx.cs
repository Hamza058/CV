using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyBlog
{
    public partial class YetenekGuncelle : System.Web.UI.Page
    {
        DbCvEntities st = new DbCvEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);
            if (Page.IsPostBack == false)
            {
                var ytnk = st.Yetenekler.Find(id);
                TextBox1.Text = ytnk.Yetenek;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);
            var deger = st.Yetenekler.Find(id);
            deger.Yetenek = TextBox1.Text;
            st.SaveChanges();
            Response.Redirect("Yeteneklerim.aspx");
        }
    }
}