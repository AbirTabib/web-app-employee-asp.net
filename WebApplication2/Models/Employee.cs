using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = Microsoft.Build.Framework.RequiredAttribute;

namespace WebApplication2.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required,StringLength(100,ErrorMessage ="Taille max 10 characters")]
        public string Name { get; set; }
        [Required]
        public string Departement { get; set; }
        [Range(200,5000)]
        public int Salary { get; set; }
        public bool Equals(Employee other)
        {
            return this.Id == other.Id;
        }
    }
}
