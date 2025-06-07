namespace MBExemploEmpresa.Entidades
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Sigla {  get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;

        // elementos de navegacao e relacionamento

        public List<Funcionario> Funcionarios { get; set; }

        public List<Cargo> Cargos { get; set; }



    }
}
