using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyBlog
{
    public partial class AnaSayfa : System.Web.UI.Page
    {
        DbCvEntities st = new DbCvEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = st.Hakkinda.ToList();
            Repeater1.DataBind();
            Repeater2.DataSource = st.Hakkinda.ToList();
            Repeater2.DataBind();
            Repeater3.DataSource = st.Deneyim.ToList();
            Repeater3.DataBind();
            Repeater4.DataSource = st.Yetenekler.ToList();
            Repeater4.DataBind();
            Repeater5.DataSource = st.Calismalar.ToList();
            Repeater5.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Iletisim t = new Iletisim();
            t.AdSoyad = TextBox1.Text;
            t.Mail = TextBox2.Text;
            t.Konu = TextBox3.Text;
            t.Mesaj = TextBox4.Text;
            st.Iletisim.Add(t);
            st.SaveChanges();
        }
    }
}