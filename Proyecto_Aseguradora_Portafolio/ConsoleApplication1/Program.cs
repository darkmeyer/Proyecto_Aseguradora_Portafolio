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
            //Pruebas de conexion
            try
            {
                Seguro.DALC.CLIENTE cli = CommonBC.ModeloSeguro.CLIENTE.FirstOrDefault();
                
                Console.WriteLine(cli.NOMBRES);               
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();

        }
    }
}
