using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace MVPEmpresas.Models
{
    public class Company
    {
        public int Id { get; set; }

        [Required(ErrorMessage="La clave es obligatoria")]
        [Display(Name="Clave")]
        [MaxLength(10)]
        public string Key { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [Display(Name = "Nombre")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "El alias es obligatorio")]
        [Display(Name = "Alias")]
        [MaxLength(20)] 
        public string Alias { get; set; }
        
        [Display(Name="Direccion")]
        [MaxLength(50)]
        public string? Address { get; set; }
      
        [Display(Name = "País")]
        [MaxLength(30)]
        public string? Country { get; set; }
        
        [Display(Name="Estado")]
        [MaxLength(30)]
        public string? State { get; set; }
        [Display(Name="Ciudad")]
        [MaxLength(30)]
        public string? City { get; set; }

        [Required(ErrorMessage ="El contacto es obligatorio")]
        [Display(Name = "Contacto")]
        [MaxLength(50)]
        public string Contact { get; set; }
        
        [Display(Name ="Email")]
        [DataType(DataType.EmailAddress)]
        [MaxLength (50)]
        public string? Email { get; set; }

        [Required(ErrorMessage = "El telefono es obligatorio")]
        [Display(Name="Telefono")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression("[0-9]{10,12}",ErrorMessage ="El formato telefonico no es valido")]
        public string Telephone { get; set; }

        [Required(ErrorMessage = "El celular es obligatorio")]
        [Display(Name="Celular")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression("[0-9]{10,12}",ErrorMessage ="El formato telefonico no es valido")]
        public string Cellphone { get; set; }

        public int CategoryId { get; set; }

        [Display(Name ="Categoria")]
        public Category? Category { get; set; }
    }
}
