using Microsoft.Build.Framework;
using System.ComponentModel;

namespace MVPEmpresas.Models
{
    public class Company
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Clave")]
        public string Key { get; set; }

        [Required]
        [DisplayName("Nombre")]
        public string Name { get; set; }
    
        public string Alias { get; set; }
        [Required]
        [DisplayName("Direccion")]
        public string Address { get; set; }
        [Required]
        [DisplayName("País")]
        public string Country { get; set; }
        [Required]
        [DisplayName("Estado")]
        public string State { get; set; }
        [Required]
        [DisplayName("Ciudad")]
        public string City { get; set; }
        [Required]
        [DisplayName("Contacto")]
        public string Contact { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [DisplayName("Telefono")]
        public string Telephone { get; set; }
        [Required]
        [DisplayName("Celular")]
        public string Cellphone { get; set; }






    }
}
