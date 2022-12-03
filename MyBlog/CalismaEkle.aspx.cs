using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyBlog
{
    public partial class CalismaEkle : System.Web.UI.Page
    {
        DbCvEntities st = new DbCvEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Calismalar c = new Calismalar();
            c.Calisma = TextBox1.Text;
            st.Calismalar.Add(c);
            st.SaveChanges();
            Response.Redirect("Calismalarim.aspx");
        }
    }
}