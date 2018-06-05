using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public static class Calc
    {
        public static double CalculaPotencia(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }

        public static double Calcula(String input)
        {
            var result = new DataTable().Compute(input, null);
            if(result == DBNull.Value)
            {
                throw new Exception("Calculo invalido");
            }
            return Convert.ToDouble(result);          
        }
    }    
}
