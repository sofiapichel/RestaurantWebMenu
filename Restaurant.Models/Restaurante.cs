using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Restaurant.Models
{
    [Table(name: "Restaurants")]
    public class Restaurante
    {
        //ID
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Column("id")]
        [Display(Name = "Id de la consulta")]
        public int Id { get; set; }

        //NOMBRE
        [StringLength(200)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Column("Nombre")]
        [Display(Name = "Nombre del consultante")]
        [DataType(DataType.Text)]
        public string Nombre { get; set; }

        //NOMBRE
        [StringLength(200)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Column("Apellido")]
        [Display(Name = "Apellido del consultante")]
        [DataType(DataType.Text)]
        public string Apellido { get; set; }


        //EDAD
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Edad del consultante")]
        [Column("Edad")]
        public int Edad { get; set; }

        //EMAIL
        [Required]
        [StringLength(18, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]    
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [StringLength(200)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Column("Puesto")]
        [Display(Name = "Puesto del consultante")]
        [DataType(DataType.Text)]
        public string Puesto { get; set; }

    }
}
