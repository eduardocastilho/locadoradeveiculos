using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace locadoradeveiculos.Models
{
    public enum Estado { AC, AL, AP, AM, BA, CE, DF, ES, GO, MA, MT, MS, MG, PA, PB, PR, PE, PI, RJ, RN, RS, RO, RR, SC, SP, SE, TO }

    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id: ")]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo CNH é obrigatório!")]
        [Display(Name = "CNH: ")]
        public String cnh { get; set; }

        [StringLength(35)]
        [Display(Name = "Nome: ")]
        public String nome { get; set; }

        [Required(ErrorMessage = "Campo idade é obrigatório!")]
        [Display(Name = "Idade: ")]
        [Range(21, 100, ErrorMessage = "Idade entre 21 e 100")]
        public int idade { get; set; }

        [StringLength(60)]
        [Display(Name = "Endereço: ")]
        public String endereco { get; set; }

        [StringLength(25)]
        [Display(Name = "Cidade: ")]
        public String cidade { get; set; }

        [Display(Name = "Estado: ")]
        public Estado estado { get; set; }

        [StringLength(25)]
        [Display(Name = "CEP: ")]
        public String cep { get; set; }

    }
}
