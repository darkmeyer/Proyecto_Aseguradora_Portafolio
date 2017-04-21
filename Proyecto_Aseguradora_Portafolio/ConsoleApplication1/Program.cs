using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seguro.DALC;
using Seguro.Negocio;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {


            Cliente cli = new Cliente();
            cli.Rut = "17256155-1";

            cli.Leer();

            Console.WriteLine(cli.Apellidos);
            Console.ReadLine();

        }
    }
}
