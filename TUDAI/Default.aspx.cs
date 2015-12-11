using System;
using DAL;

namespace TUDAI
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                gvNoticias.DataSource = new NoticiaBusiness().GetNoticias();
                gvNoticias.DataBind();
                lbl_nombre.Text = "Primera vez";
            }
            else
            {
                lbl_nombre.Text = "Segunda vez";
            }
            
        }

        protected void btn_filtrar_Click(object sender, EventArgs e)
        {
            var oNoticia = new Noticia()
            {
                Autor = txt_busqueda.Text
            };
            gvNoticias.DataSource = new NoticiaBusiness().GetNoticiaByAutor(oNoticia);
            gvNoticias.DataBind();
        }
    }

}