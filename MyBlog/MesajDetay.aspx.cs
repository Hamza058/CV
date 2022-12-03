using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyBlog
{
    public partial class MesajDetay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DbCvEntities st = new DbCvEntities();
            int x = int.Parse(Request.QueryString["ID"]);
            var mesaj = st.Iletisim.Find(x);
            txtAdSoyad.Text = mesaj.AdSoyad;
            txtMail.Text = mesaj.Mail;
            txtKonu.Text = mesaj.Konu;
            txtMesaj.Text = mesaj.Mesaj;
        }
    }
}