using static L01P02_2020DL602.Models.usuarios;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace L01P02_2020DL602.Models
{
    public class publicaciones
        {
            [Key]

            public int publicacionId { get; set; }

            [Required]
            [StringLength(255)]
            public string titulo { get; set; }

            [Required]
            public string descripcion { get; set; }

           
            public int usuarioId { get; set; }
        }
    }

