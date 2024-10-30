namespace ControleClientes
{
    public class EnderecoRepository
    {
        private ApplicationDBContext _dbContext = new ApplicationDBContext();

        public List<Endereco> ReadAll()
        {
            return _dbContext.Enderecos.ToList();
        }

        public int Create(Endereco endereco)
        {
            _dbContext.Add(endereco);
            _dbContext.SaveChanges();

            return endereco.Id;
        }

        public Endereco GetById(int id) => _dbContext.Enderecos.FirstOrDefault(e => e.Id == id);

        public void Update(Endereco endereco)
        {
            Endereco enderecoExistente = GetById(endereco.Id);
            if (enderecoExistente != null)
            {
                enderecoExistente.Cep = endereco.Cep;
                enderecoExistente.Logradouro = endereco.Logradouro;
                enderecoExistente.Complemento = endereco.Complemento;
                enderecoExistente.Numero = endereco.Numero;
                enderecoExistente.Unidade = endereco.Unidade;
                enderecoExistente.Bairro = endereco.Bairro;
                enderecoExistente.Localidade = endereco.Localidade;
                enderecoExistente.Uf = endereco.Uf;
                enderecoExistente.Estado = endereco.Estado;
                enderecoExistente.Regiao = endereco.Regiao;
                enderecoExistente.CidadeId = endereco.CidadeId; // Chave estrangeira
                _dbContext.SaveChanges();
            }
        }

        public void Delete(Endereco endereco)
        {
            Endereco enderecoExistente = GetById(endereco.Id);
            if (enderecoExistente != null)
            {
                _dbContext.Remove(enderecoExistente);
                _dbContext.SaveChanges();
            }
        }
    }
}
