using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarCenter.Infrastructure.Persistence.Entities
{
    [Table("Mecanicos")]
    public class Mechanic
    {
        [Required]
        [Column("tipo_documento")]
        [StringLength(2)]
        public string tipo_documento { get; set; }

        [Required]
        [Column("documento")]
        public int documento { get; set; }

        [Required]
        [StringLength(30)]
        [Column("primer_nombre")]
        public string primer_nombre { get; set; }

        [Column("segundo_nombre")]
        [StringLength(30)]
        public string segundo_nombre { get; set; }

        [Required]
        [Column("primer_apellido")]
        [StringLength(30)]
        public string primer_apellido { get; set; }

        [Required]
        [Column("segundo_apellido")]
        [StringLength(30)]
        public string segundo_apellido { get; set; }

        [Required]
        [Column("celular")]
        [StringLength(10)]
        public string celular { get; set; }

        [Column("email")]
        [StringLength(100)]
        public string email { get; set; }

        [Required]
        [StringLength(200)]
        [Column("direccion")]
        public string direccion { get; set; }

        [Column("estado")]
        public char estado { get; set; }
    }
}
