﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
namespace WebServices
{
    /// <summary>
    /// Descripción breve de WS_Entradas
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Entradas : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet VendoH()
        {

            Conexion cone = new Conexion();
         DataSet s = cone.Open();
            return  s;
        }
    }
}
