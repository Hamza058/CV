using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyBlog
{
    public partial class YeniYetenek : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        DbCvEntities st = new DbCvEntities();
        protected void Button1_Click(object sender, EventArgs e)
        {
            Yetenekler y = new Yetenekler();
            y.Yetenek = TextBox1.Text;
            st.Yetenekler.Add(y);
            st.SaveChanges();
            Response.Redirect("Yeteneklerim.aspx");
        }
    }
}