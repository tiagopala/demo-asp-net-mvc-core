using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAspNetMvcCore.Models
{
    public class Filme
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Título é obrigatório")]
        [StringLength(60, MinimumLength = 6, ErrorMessage = "O Título precisa estar entre 6 e 60 caracteres")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo Data de Lançamento é obrigatório")]
        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Display(Name = "Data de Lançamento")]
        public DateTime DataLancamento { get; set; }

        [Required(ErrorMessage = "Preencha o campo Gênero")]
        [StringLength(30, ErrorMessage = "Máximo de 30 caracteres")]
        [Display(Name = "Genêro")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "O campo Valor é obrigatório")]
        [Range(1,1000, ErrorMessage = "Valor de 1 a 1000")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Preencha o campo Avaliação")]
        [RegularExpression(@"^[0-5]*$", ErrorMessage = "Somente números de 0 a 5")]
        [Display(Name = "Avaliação")]
        public int Avaliacao { get; set; }
    }
}
