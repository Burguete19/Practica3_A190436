using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalcularAreaWS
{
    public class CalcularAreas
    {
        public decimal Lado1 { get; set; }
        public decimal Lado2 { get; set; }
        public decimal areacuadrado()
        {
            return Lado1 * Lado2;
        }

        public double areatriangulo(int B, int H)
        {
            var result = (B * H) / 2;
            return result;
        }

        public double areacirculo(int R)
        {
            var result = Math.PI * Math.Pow(R, 2);
            return result;
        }
    }
}