using WebApi.Models;

namespace WebApi.Infraestrutura
{
    public class RepositorioFuncionario : IRepositorioFuncionario
    {
        private readonly ConnectionContext _context = new ConnectionContext();
        public void Add(Funcionarios funcionario)
        {
            _context.Funcionarios.Add(funcionario);
            _context.SaveChanges();
        }

        public List<Funcionarios> Get()
        {
            return _context.Funcionarios.ToList();
        }

        public void Atualizar(Funcionarios funcionario)
        {
            _context.Funcionarios.Update(funcionario);
            _context.SaveChanges();
        }

        public void Delete(Funcionarios funcionario)
        {
            _context.Funcionarios.Remove(funcionario);
            _context.SaveChanges();
        }

        public Funcionarios GetById(int id)
        {
            return _context.Funcionarios.FirstOrDefault(f => f.Id == id);
        }

        public void Update(Funcionarios funcionario)
        {
            throw new NotImplementedException();
        }
    }
}
