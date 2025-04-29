namespace WebApi.Models
{
    public class Funcionarios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int RG { get; set; }
        public int DepartamentoId { get; set; }


        public Funcionarios(string Nome, int RG, int DepartamentoId)
        {
            this.Nome = Nome ?? throw new ArgumentNullException(nameof(Nome));
            this.RG = RG;
            this.DepartamentoId = DepartamentoId;

        }
        public void Atualizar(string nome, int rg, int departamentoId)
        {
            this.Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            this.RG = rg;
            this.DepartamentoId = departamentoId;
        }
    }
}
