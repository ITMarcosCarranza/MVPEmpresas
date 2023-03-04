using Microsoft.Build.Framework;
using NuGet.ProjectModel;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace MVPEmpresas.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="El nombre es obligatorio")]
        [Display(Name ="Nombre")]
        [MaxLength(50)]
        public string Description { get; set; }

        public bool isActive { get; set; } = true;
    }
}
