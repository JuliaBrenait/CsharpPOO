using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class ConversorMoeda
    {
        public static double Conversao(double reais, double dolar)
        {
            double calculo = reais * dolar;
            return calculo + calculo * 6 / 100 ;
        }

    }
}
