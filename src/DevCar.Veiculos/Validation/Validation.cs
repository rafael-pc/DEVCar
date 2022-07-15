using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCar.Vehicle.Validation
{
    public class Validation
    {
        public static string ValidaString(string texto)
        {
            if (String.IsNullOrWhiteSpace(texto))
            {
                Console.WriteLine("\n O campo informado é inválido.");
                Environment.Exit(0);
            }
            return texto;
        }
        public static decimal ValidaDecimal(decimal valor)
        {
            if (valor < 0)
            {
                Console.WriteLine("\n Valor invalido");
                Environment.Exit(0);
            }
            return valor;
        }
        public static int ValidaInt(int valor)
        {
            if (valor < 0)
            {
                Console.WriteLine("\n Valor invalido");
                Environment.Exit(0);
            }
            return valor;
        }
    }
}
