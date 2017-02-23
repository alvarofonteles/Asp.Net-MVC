using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NewTISelvagem.Dominio
{
    public class Aluno
    {
        public int AlunoId { get; set; }

        [Required(ErrorMessage="O Nome do Aluno é Obrigatório.")]
        public string Nome { get; set; }

        [DisplayName("Mãe")]
        [Required(ErrorMessage="O Nome da Mãe é Obrigatório.")]
        public string Mae { get; set; }

        [DisplayName("Data de Nascimento")]
        [Required(ErrorMessage = "A Data de Nascimento é Obrigatória.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }
    }
}
