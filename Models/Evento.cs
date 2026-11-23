using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace ExercícioAspNetMvc.Models
{
    public class Evento
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [StringLength(80, MinimumLength = 5, ErrorMessage = "Nome deve ter entre 5 e 80 caracteres")]
        public string Nome { get; set; } = "";

        [Required(ErrorMessage = "A descrição é obrigatória")]
        [StringLenght(int.MaxValue, MinimumLength = 10, ErrorMessage = "Descrição com mínimo de 10 caracteres")]
        public string Descricao { get; set; } = "";

        [Required(ErrorMessage = "O Local é obrigatório")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O local deve ter entre 3 a 100 caracteres")]
        public string Local { get; set; } = "";

        [Range(1, 1000, ErrorMessage = "A quantidade de vagas deve ser entre 1 à 1000")]
        public int QuantidadeVagas { get; set; } = "";

        [Range(0, int.MaxValue, ErrorMessage = "Valor do ingresso deve ser maior ou igual a zero")]
        public decimal ValorIngresso { get; set; } = "";


    }
}