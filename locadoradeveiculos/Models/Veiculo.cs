using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace locadoradeveiculos.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id: ")]
        public int id { get; set; }

        [StringLength(35)]
        [Required(ErrorMessage = "Campo placa é obrigatório!")]
        [Display(Name = "Placa: ")]
        public String placa { get; set; }

        [Display(Name = "Ano: ")]
        [Range(1980, 2025, ErrorMessage = "Ano inválido!")]
        public int ano { get; set; }

        [Display(Name = "Modelo: ")]
        public String modelo { get; set; }

        [Display(Name = "Fabricante: ")]
        public String fabricante { get; set; }

    }
}
