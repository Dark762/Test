using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDDD.Domain.Entities
{
    public class Clientes
    {
        public int Id { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public string Correo { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string Direccion { get; set; }

        public bool Activo { get; set; }

        public DateTime FechaRegistro { get; set; }
    }
}
