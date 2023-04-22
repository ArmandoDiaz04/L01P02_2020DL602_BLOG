using static L01P02_2020DL602.Models.usuarios;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace L01P02_2020DL602.Models
{
    public class calificaciones
    
        {
            [Key]
         
            public int calificacionId { get; set; }

            
            public int publicacionId { get; set; }
            
            
            public int usuarioId { get; set; }

            public int calificacion { get; set; }
        }
    }

