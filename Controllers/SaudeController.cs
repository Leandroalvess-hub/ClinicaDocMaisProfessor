using ClinicaDocMais.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaDocMais.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SaudeController : Controller
    {
        [HttpGet("retornoCasa")]
        public string casa()
        {
            return "casa";
        }

        [HttpGet("nomePaciente")]
        public string paciente()
        {
            string nome = "Giovanni";
            return "Paciente: " + nome;
        }

        [HttpGet("listaPacientes")]
        public List<string> listaNome()
        {
            List<string> listaPacientes = new List<string>();
            listaPacientes = ["Giovanni", "Carlos", "Pedro"];
            return listaPacientes;
        }

        [HttpGet("pacientes")]
        public List<Paciente> listaPaciente()
        {
            Paciente novoPaciente = new Paciente("1019210", "Giovanni", "10/04/1999", "Vermelha");
            List<Paciente> listaPaciente = new List<Paciente>();
            listaPaciente.Add(novoPaciente);
            novoPaciente = new Paciente("1020220", "Eduarda", "15/03/1990", "Verde");
            listaPaciente .Add(novoPaciente);
            return listaPaciente;
        }

    }
}
