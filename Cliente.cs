namespace ControleClientes
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public Genero Genero { get; set; }
        public int EnderecoId { get; set; }

        public Endereco Endereco { get; set; }
    }
}
