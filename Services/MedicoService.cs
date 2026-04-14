using ClinicaDocMais.Models;

namespace ClinicaDocMais.Services
{
    public class MedicoService
    {
        public static List<MedicoModel> listaMedicos = new List<MedicoModel>();
        //MÉTODOS
        public MedicoModel? editarMedico(MedicoModel medicoEditado, string crm)
        {
            foreach (var medico in listaMedicos)
            {
                if (medico.crm == crm)
                {
                    medico.crm = medicoEditado.crm;
                    medico.nome = medicoEditado.nome;
                    medico.telefone = medicoEditado.telefone;
                    medico.dataNascimento = medicoEditado.dataNascimento;
                    medico.especialidade = medicoEditado.especialidade;
                    return medico;
                }
            }
            return null;
        }
    }
}
