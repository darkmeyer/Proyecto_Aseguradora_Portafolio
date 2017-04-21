using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Seguro.Negocio
{
    public class Cliente
    {
        public string Id_cliente { get; set; }
        public string Rut { get; set; }
        public string Pass { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string IdVehiculo { get; set; }
        public string IdSeguro { get; set; }
        public int IdCiudad { get; set; }



        public Cliente()
        {

        }

        public Cliente(string xml)
        {
            XmlSerializer serializador = new XmlSerializer(typeof(Cliente));
            StringReader reader = new StringReader(xml);
            Cliente cliente = (Cliente)serializador.Deserialize(reader);
            this.Rut = cliente.Rut;
            this.Nombres = cliente.Nombres;
            this.Apellidos = cliente.Apellidos;
            this.Correo = cliente.Correo;
            this.FechaNacimiento = cliente.FechaNacimiento;
            this.Direccion = cliente.Direccion;
            this.IdVehiculo = cliente.IdVehiculo;
            this.IdSeguro = cliente.IdSeguro;
            this.IdCiudad = cliente.IdCiudad;
        }

        public string Serializar()
        {
            XmlSerializer serializador = new XmlSerializer(typeof(Cliente));
            StringWriter writer = new StringWriter();
            serializador.Serialize(writer, this);
            writer.Close();
            return writer.ToString();
        }


        public bool Leer()
        {
            try
            {
                Seguro.DALC.CLIENTE cli = CommonBC.ModeloSeguro.CLIENTE.Where(c => c.RUT.Equals(this.Rut)).FirstOrDefault();
                this.Rut = cli.RUT;
                this.Nombres = cli.NOMBRES;
                this.Apellidos = cli.APELLIDOS;
                this.Correo = cli.CORREO;
                this.FechaNacimiento = cli.FECHA_NACIMIENTO;
                this.Direccion = cli.DIRECCION;
                this.IdVehiculo = cli.VEHICULO_ID_VEHICULO;
                this.IdSeguro = cli.SEGURO_ID_SEGURO;
                this.IdCiudad = cli.ID_CIUDAD;

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool validarCliente()
        {
            try
            {
                Seguro.DALC.CLIENTE cli = CommonBC.ModeloSeguro.CLIENTE.Where(c => c.RUT.Equals(this.Rut) && c.PASS.Equals(this.Pass)).FirstOrDefault();
                if (cli != null)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
