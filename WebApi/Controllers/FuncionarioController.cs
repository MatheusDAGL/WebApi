using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.ViewModel;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/v1/Funcionario")]
    public class FuncionarioController : ControllerBase
    {
        private readonly IRepositorioFuncionario _RepositorioFuncionario;

        public FuncionarioController(IRepositorioFuncionario repositorioFuncionario) 
        {
            _RepositorioFuncionario = repositorioFuncionario ?? throw new ArgumentNullException();
        }

        [HttpPost]
        public IActionResult Add(FuncionarioViewModel FuncionarioView)
        {
            var funcionario = new Funcionarios(FuncionarioView.Nome, FuncionarioView.RG,FuncionarioView.DepartamentoID);
            _RepositorioFuncionario.Add(funcionario);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get() 
        {
            var funcionarios = _RepositorioFuncionario.Get();
            
            return Ok(funcionarios);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, FuncionarioViewModel funcionarioView)
        {
            var funcionario = _RepositorioFuncionario.GetById(id);
            if (funcionario == null)
            {
                return NotFound("Funcionário não encontrado.");
            }

            funcionario.Atualizar(funcionarioView.Nome, funcionarioView.RG, funcionarioView.DepartamentoID);
            _RepositorioFuncionario.Update(funcionario);

            return Ok("Funcionário atualizado com sucesso.");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var funcionario = _RepositorioFuncionario.GetById(id);
            if (funcionario == null)
            {
                return NotFound("Funcionário não encontrado.");
            }

            _RepositorioFuncionario.Delete(funcionario);

            return Ok("Funcionário deletado com sucesso.");
        }
    }
}
