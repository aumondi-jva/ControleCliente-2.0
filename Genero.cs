namespace ControleClientes
{
    public enum Genero
    {
        Masculino,
        Feminino
    }

    public class ItemGenero
    {
        public Genero Valor { get; set; }
        public string Descricao { get; set; }
    }
}
