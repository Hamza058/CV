using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyBlog
{
    public partial class Yeteneklerim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DbCvEntities st = new DbCvEntities();
            Repeater1.DataSource = st.Yetenekler.ToList();
            Repeater1.DataBind();
        }
    }
}