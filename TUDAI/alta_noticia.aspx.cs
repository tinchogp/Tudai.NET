using System;
using DAL;
using System.Collections.Generic;
using System.Linq;

namespace TUDAI
{
    public partial class AltaNoticia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarDdls();
            }
        }

        private void CargarDdls()
        {
            ddl_categorias.DataSource = new CategoriaBusiness().GetCategorias();
            ddl_categorias.DataBind();   
        }

        protected void Publicar_Noticia(object sender, EventArgs e)
        {
            var oNoticia = new Noticia()
            {
                Titulo = txt_titulo.Text,
                Cuerpo = txt_cuerpo.Text,
                Fecha = date_fecha.SelectedDate,
                IdCategoria = int.Parse(ddl_categorias.SelectedValue)
            };
            using (NoticiaBusiness n = new NoticiaBusiness())
            {
                n.InsertNoticia(oNoticia);
            }
            lbl_resultado.Text = "Noticia publicada correctamente";            
            
        }

    }
}