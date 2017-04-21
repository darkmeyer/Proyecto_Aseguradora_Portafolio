using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seguro.DALC;

namespace Seguro.Negocio
{
    public class CommonBC
    {
        private static SeguroEntities _ModeloSeguro;

        public static SeguroEntities ModeloSeguro
        {
            get 
            { 
                if(_ModeloSeguro == null)
                {
                    _ModeloSeguro = new SeguroEntities();
                }
                return _ModeloSeguro; 
            }
        }
        
    }
}
