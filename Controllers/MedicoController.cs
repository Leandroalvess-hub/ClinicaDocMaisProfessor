using ClinicaDocMais.Data;
using ClinicaDocMais.Models;
using ClinicaDocMais.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaDocMais.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MedicoController : ControllerBase
    {
        private readonly ClinicaContext _context;
        public MedicoController(ClinicaContext context)
        {
            _context = context;
        }

        public static List<MedicoModel> listaMedicos = new List<MedicoModel>();

        [HttpPost("cadastroMedico")]
        public async Task<IActionResult> cadastrarMedico([FromBody] MedicoModel medico)
        {
            try
            {
                if (medico != null)
                {
                    
                    _context.Add(medico);
                    await _context.SaveChangesAsync();

                    return Ok($"Dr. {medico.nome} cadastrado com sucesso");
                }
                else
                {
                    throw new Exception("Dados do médico não podem ser nulos");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao cadastrar médico: {ex.Message}");
            }
        }

        //listar os médicos
        [HttpGet("listaMedicos")]
        public List<MedicoModel> listarMedicos()
        {
            return listaMedicos;
        }

        //editar médico
        [HttpPut("editarMedico/{crm}")]
        public string editarMedico([FromBody] MedicoModel medicoEditado, string crm) 
        {
            MedicoService medico = new MedicoService();
            medico.editarMedico(medicoEditado, crm);  

            if (medico == null)
            {
                return "Médico não encontrado";
            }
            else
            {
                return $"Médico de CRM Nº {crm} editado com sucesso";
            }
            //ou ele recebe um null caso dê errado
        }

        //buscar médico

        //excluir médico
    }
}
