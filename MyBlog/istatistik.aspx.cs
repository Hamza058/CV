using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyBlog
{
    public partial class istatistik : System.Web.UI.Page
    {
        DbCvEntities st = new DbCvEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = st.Yetenekler.Count().ToString();
            Label2.Text = st.Iletisim.Count().ToString();
            Label3.Text = Math.Round(Convert.ToDouble(st.Yetenekler.Average(x => x.Derece)), 2).ToString();
            Label4.Text = st.Yetenekler.Max(x => x.Derece).ToString();
        }
    }
}