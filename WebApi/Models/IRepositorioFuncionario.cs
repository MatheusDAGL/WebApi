namespace WebApi.Models
{
    public interface IRepositorioFuncionario
    {
        void Add(Funcionarios funcionario);

        List<Funcionarios> Get();

        Funcionarios GetById(int id); 

        void Update(Funcionarios funcionario); 

        void Delete(Funcionarios funcionario); 
    }
}
