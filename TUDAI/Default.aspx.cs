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

        protected void gvNoticias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gvNoticias_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void gvNoticias_SelectedIndexChanged2(object sender, EventArgs e)
        {

        }
    }
}