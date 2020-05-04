
using System;

namespace AulaMVC.Models
{
    public class Cliente
    {
        public string Nome{get;set;}
        public DateTime DataDeNascimento {get;set;}
        public string DiaDaSemana {get;set;}

        [Display(Name = "Data de Retorno")]

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]

        [DataType(DataType.Date, ErrorMessage="Data em formato inválido")]

    public DateTime? DataRetorno { get; set; }

}
