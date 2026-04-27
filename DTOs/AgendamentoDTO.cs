
using ClinicaDocMais.Models;

namespace ClinicaDocMais.DTOs
{
    public class AgendamentoDTO
    {
        public string? cpfpaciente { get; set; }
        public string? crmmedico { get; set; }
        public DateTime dataHoraAgendada { get; set; }
    }
}
