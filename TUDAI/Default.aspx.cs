using System;
using DAL;

namespace TUDAI
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gvNoticias.DataSource = new NoticiaBusiness().GetNoticias();

            gvNoticias.DataBind();
        }
    }
}