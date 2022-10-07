using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace locadoradeveiculos.Models
{
    [Table("Alugueis")]
    public class Aluguel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id: ")]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo data aluguel é obrigatório!")]
        [Display(Name = "Data aluguel: ")]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}")]
        public DateTime dataAluguel { get; set; }

        [Required(ErrorMessage = "Campo funcionário é obrigatório!")]
        [Display(Name = "Funcionário: ")]
        [ForeignKey("id_funcionario")]
        public int funcionarioid { get; set; }
        public Funcionario funcionario { get; set; }

        [Required(ErrorMessage = "Campo cliente é obrigatório!")]
        [Display(Name = "Cliente: ")]
        [ForeignKey("id_cliente")]
        public int clienteid { get; set; }
        public Cliente cliente { get; set; }

        [Required(ErrorMessage = "Campo veículo é obrigatório!")]
        [Display(Name = "Veículo: ")]
        [ForeignKey("id_veiculo")]
        public Veiculo veiculo { get; set; }
    }
}
