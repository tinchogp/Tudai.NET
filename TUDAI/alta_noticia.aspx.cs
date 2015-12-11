using System;
using DAL;
using System.Collections.Generic;
using System.Linq;

namespace TUDAI
{
    public partial class AltaNoticia : System.Web.UI.Page
    {
        public const string id_noticia = "id";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarDdls();
                if (Request.QueryString[id_noticia] != null)
                {
                    var oNoticia = new Noticia()
                {
                    Id = int.Parse(Request.QueryString[id_noticia]),

                };
                
                    NoticiaBusiness noticiaByID = new NoticiaBusiness();
                    var noticiaM = noticiaByID.GetNoticiaById(oNoticia);

                    txt_titulo.Text = noticiaM.Tables[0].Rows[0]["titulo"].ToString();
                    txt_cuerpo.Text = noticiaM.Tables[0].Rows[0]["cuerpo"].ToString();
                    date_fecha.SelectedDate = DateTime.Parse(noticiaM.Tables[0].Rows[0]["fecha"].ToString());
                    if (noticiaM.Tables[0].Rows[0]["autor"] != DBNull.Value)
                        txt_autor.Text= noticiaM.Tables[0].Rows[0]["autor"].ToString();
                    if (noticiaM.Tables[0].Rows[0]["id_categoria"] != DBNull.Value)
                        ddl_categorias.SelectedValue = noticiaM.Tables[0].Rows[0]["id_categoria"].ToString();
                }

            }

            if (Request.QueryString[id_noticia] != null)
            {
                accionNoticia.Text = "Editar Noticia";


                btn_submit.Click += Editar_Noticia;

            }
            else
            {
                btn_submit.Click += Publicar_Noticia;
            }

    }

        private void Editar_Noticia(object sender, EventArgs e)
        {
            var oNoticia = new Noticia()
            {
                Id = int.Parse(Request.QueryString[id_noticia]),
                Titulo = txt_titulo.Text,
                Cuerpo = txt_cuerpo.Text,
                Fecha = date_fecha.SelectedDate,
                IdCategoria = int.Parse(ddl_categorias.SelectedValue),
                Autor = txt_autor.Text
                
            };
            using (NoticiaBusiness n = new NoticiaBusiness())
            {
                n.updateNoticia(oNoticia);
            }
            lbl_resultado.Text = "Noticia actualizada correctamente";
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
                IdCategoria = int.Parse(ddl_categorias.SelectedValue),
                Autor = txt_autor.Text
            };
            using (NoticiaBusiness n = new NoticiaBusiness())
            {
                n.InsertNoticia(oNoticia);
            }
            lbl_resultado.Text = "Noticia publicada correctamente";            
            
        }

    }
}