﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCVenta.ViewModels
{
    public class Usuario
    {

        public int IdUsuario { get; set; }
        public string Uusuario { get; set; }
        public string Clave { get; set; }
  

        public Usuario(int idusuario, string uusario,string clave)
        {
            this.IdUsuario = idusuario; this.Uusuario = uusario;
            this.Clave = clave;
        }

        public Usuario()
        {
        }

    }
}