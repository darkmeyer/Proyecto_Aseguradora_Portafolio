using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguro.Negocio
{
    public class Ciudad
    {
        public int IdCiudad { get; set; }
        public string Nombre { get; set; }
        public int IdRegion { get; set; }

        public Ciudad()
        {

        }

        public bool leer()
        {
            try
            {
                Seguro.DALC.CIUDAD ciudad = CommonBC.ModeloSeguro.CIUDAD.Where(c => c.ID_CIUDAD == this.IdCiudad).FirstOrDefault();

                this.Nombre = ciudad.NOMBRE;
                this.IdRegion = IdRegion;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
