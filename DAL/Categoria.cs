using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL
{
    [Serializable]
    public class Categoria
    {
        #region Properties
        public int Id { get; set; }
        public string Nombre{ get; set; }
        #endregion

        #region Constructor
        public Categoria() : base(){ }

        #endregion
    }
}
