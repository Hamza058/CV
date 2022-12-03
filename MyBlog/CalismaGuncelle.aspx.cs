using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyBlog
{
    public partial class CalismaGuncelle : System.Web.UI.Page
    {
        DbCvEntities st = new DbCvEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);
            if (Page.IsPostBack == false)
            {
                var cls = st.Calismalar.Find(id);
                TextBox1.Text = cls.Calisma;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);
            var deger = st.Calismalar.Find(id);
            deger.Calisma = TextBox1.Text;
            st.SaveChanges();
            Response.Redirect("Calismalarim.aspx");
        }
    }
}