using System.ComponentModel.DataAnnotations;

namespace AppSaresp_2024.Models
{
    public class Aluno
    {
        [Display(Name = "Código")]
        public int? IdAluno { get; set; }

        [Display(Name = "Nome Completo")]
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string nome { get; set; }

        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "O campo Telefone é obrigatório")]
        public Decimal telefone { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "O campo email é obrigatório")]
        public string email { get; set; }

        [Display(Name = "Turma")]
        [Required(ErrorMessage = "O campo Turma é obrigatório")]
        public string turma { get; set; }

        [Display(Name = "Serie")]
        [Required(ErrorMessage = "O campo Sala é obrigatório")]
        public string serie { get; set; }

        [Display(Name = "Nascimento")]
        [Required(ErrorMessage = "O campo nascimento é obrigatório")]
        [DataType(DataType.DateTime)]
        public DateTime data_nasc { get; set; }
    }
}
