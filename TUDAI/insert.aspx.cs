using System;
using DAL;

namespace TUDAI
{
    public partial class insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Publicar_Noticia(object sender, EventArgs e)
        {
            var oNoticia = new Noticia()
            {
                Titulo = txt_titulo.Text,
                Cuerpo = txt_cuerpo.Text,
                Fecha = date_fecha.SelectedDate
            };
            new NoticiaBusiness().InsertNoticia(oNoticia);
            
            lbl_resultado.Text = "Noticia publicada correctamente";            
            
        }
    }
}