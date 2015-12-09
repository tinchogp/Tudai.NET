using System;
using DAL;

namespace TUDAI
{
    public partial class AltaCategoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {            
        }

        protected void Publicar_Categoria(object sender, EventArgs e)
        {
            if (Page.IsValid) { 
                var oCategoria = new Categoria()
                {                
                    Nombre = txt_nombre.Text
                };
                try {  
                    new CategoriaBusiness().InsertCategoria(oCategoria);
                    lbl_resultado.Text = "Categoria publicada correctamente";
                }
                catch(Exception ex) {
                    lbl_resultado.Text = "Hubo un error: "+ex.Message;
                }
            }
            else {  
                lbl_resultado.Text = "Por favor, complete los campos obligatorios del formulario";
            }
        }
    }
}