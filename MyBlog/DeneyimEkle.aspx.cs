using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyBlog
{
    public partial class DeneyimEkle : System.Web.UI.Page
    {
        DbCvEntities st = new DbCvEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Deneyim d = new Deneyim();
            d.IsDeneyimi = TextBox1.Text;
            st.Deneyim.Add(d);
            st.SaveChanges();
            Response.Redirect("Deneyimler.aspx");
        }
    }
}