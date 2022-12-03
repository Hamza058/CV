using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyBlog
{
    public partial class DeneyimGuncelle : System.Web.UI.Page
    {
        DbCvEntities st = new DbCvEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);
            if (Page.IsPostBack == false)
            {
                var dny = st.Deneyim.Find(id);
                TextBox1.Text = dny.IsDeneyimi;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);
            var deger = st.Deneyim.Find(id);
            deger.IsDeneyimi = TextBox1.Text;
            st.SaveChanges();
            Response.Redirect("Deneyimler.aspx");
        }
    }
}