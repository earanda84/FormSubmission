#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;

namespace FormSubmission.Models
{
    public class User
    {
        [Required(ErrorMessage = "El campo Name es obligatorio")]
        [MinLength(4, ErrorMessage = "El nombre debe ser de al menos 4 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El campo Lastname es oblogatorio")]
        [MinLength(4, ErrorMessage = "El apellido debe tener al menos 4 caracteres")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "El campo Age es obligatorio")]
        [PlusAge]
        public int Age { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "No es un email válid")]
        public string Email { get; set; }
        
        [Required(ErrorMessage ="El Password es obligatorio")]
        [MinLength(8,ErrorMessage ="El Password debe ener un largo mínimo de 8 caracteres")]
        public string Password { get; set; }
    }

    public class PlusAgeAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is int age)
            {
                if (age < 0 || age == 0)
                {
                    return new ValidationResult("La edad debe ser un número mayor a 0");
                }
            }

            return ValidationResult.Success;
        }
    }
}