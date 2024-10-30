namespace ControleClientes
{
    public enum EstadoCivil
    {
        Solteiro,
        Casado,
        Divorciado,
        Viuvo
    }

    public class ItemEstadoCivil
    {
        public EstadoCivil Valor { get; set; }
        public string Descricao { get; set; }
    }
}
