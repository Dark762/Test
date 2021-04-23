using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Web.Models
{
    [DataContract]
    public class RegistrarClienteViewModel
    {

        [DataMember]
        [DisplayName("Codigo")]
        public int Id { get; set; }

     
        [DisplayName("Nombres")]
        public string Nombres { get; set; }

  
        [DisplayName("Apellidos")]
        public string Apellidos { get; set; }

        [DataMember]
        [DisplayName("Coreo")]
        public string Correo { get; set; }

        [DataMember]
        [DisplayName("Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [DataMember]
        [DisplayName("Dirección")]
        public string Direccion { get; set; }

        [DataMember]
        [DisplayName("Activo")]
        public bool Activo { get; set; }

        [DataMember]
        [DisplayName("Fecha de Registro")]
        public DateTime FechaRegistro { get; set; }
    }
}
