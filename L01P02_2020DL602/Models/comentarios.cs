using static L01P02_2020DL602.Models.usuarios;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace L01P02_2020DL602.Models
{
    public class comentarios
    {
        
            [Key]
      
            public int comentarioId { get; set; }

         
            public int publicacionId { get; set; }

            public string comentario { get; set; }

           
            public int usuarioId { get; set; }
        }

    }

