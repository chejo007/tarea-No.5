using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ApiEmpresa.Models
{
    public class Clientes{
        [Key]
         public int Id { get; set; }
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public DateTime? FechaNacimiento { get; set; } 
    }
}
