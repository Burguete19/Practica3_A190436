using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using CalcularAreaWS;

namespace CalcularAreaWS
{
    /// <summary>
    /// Descripción breve de CalcularAreaWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class CalcularAreaWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod]
        public decimal areacuadrado(int valor1, int valor2)
        {
            CalcularAreas c = new CalcularAreas();
            c.Lado1 = valor1;
            c.Lado2 = valor2;
            return c.areacuadrado();
        }
        [WebMethod]
        public double areatriangulo(int B, int H)
        {
            CalcularAreas c = new CalcularAreas();
            return c.areatriangulo(B, H);
        }
        [WebMethod]
        public double areacirculo(int R)
        {
            CalcularAreas c = new CalcularAreas();
            return c.areacirculo(R);
        }
    }
}