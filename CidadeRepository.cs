namespace ControleClientes
{
    public class CidadeRepository
    {
        private ApplicationDBContext _dbContext = new ApplicationDBContext();

        public List<Cidade> ReadAll()
        {
            return _dbContext.Cidades.ToList();
        }

        public List<Cidade> BuscarPorNomeCidade(string nome)
        {
            return _dbContext.Cidades
                .Where(cidade => cidade.Nome.Contains(nome))
                .ToList();
        }

        public int Create(Cidade cidade)
        {
            _dbContext.Add(cidade);
            _dbContext.SaveChanges();

            return cidade.Id;
        }

        public Cidade GetById(int id) => _dbContext.Cidades.FirstOrDefault(c => c.Id == id);
        public Cidade GetByName(string nome) => _dbContext.Cidades.FirstOrDefault(c => c.Nome == nome);

        public void Update(Cidade cidade)
        {
            Cidade clienteExistente = GetById(cidade.Id);
            if (clienteExistente != null)
            {
                clienteExistente.Nome = cidade.Nome;
                clienteExistente.Uf = cidade.Uf;
                _dbContext.SaveChanges();
            }
        }

        public void Delete(Cidade cidade)
        {
            Cidade clienteExistente = GetById(cidade.Id);
            if (clienteExistente != null)
            {
                _dbContext.Remove(clienteExistente);
                _dbContext.SaveChanges();
            }
        }
    }
}
