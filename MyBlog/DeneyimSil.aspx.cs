using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyBlog
{
    public partial class DeneyimSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DbCvEntities st = new DbCvEntities();
            int x = Convert.ToInt32(Request.QueryString["ID"]);
            var dny = st.Deneyim.Find(x);
            st.Deneyim.Remove(dny);
            st.SaveChanges();
            Response.Redirect("Deneyimler.aspx");
        }
    }
}