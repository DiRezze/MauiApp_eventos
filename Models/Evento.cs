using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiGerenteDeEventos.Models
{
    public class Evento
    {
        public required string nome { get; set; }
        public DateTime dataInicio { get; set; }
        public DateTime dataTermino { get; set;}
        public int numeroParticipantes { get; set; }
        public string local { get; set; }
        public decimal custoPorParticipante { get; set; }

        public TimeSpan duracaoEmDias => dataTermino - dataInicio;

        public decimal custoTotal => numeroParticipantes * custoPorParticipante;

    }
}
