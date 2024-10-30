using Microsoft.EntityFrameworkCore;

namespace ControleClientes
{
    public class ClienteRepository
    {
        private ApplicationDBContext _dbContext = new ApplicationDBContext();
        
        public List<Cliente> ReadAll()
        { 
            return _dbContext.Clientes.ToList();            
        }

        public List<Cliente> BuscarPorNome(string nome)
        {
            return _dbContext.Clientes
                .Where(cliente => cliente.Nome.Contains(nome))
                .ToList();
        }

        public void Create(Cliente cliente)
        {
            _dbContext.Add(cliente);
            _dbContext.SaveChanges();
        }

        public Cliente GetById(int id) => _dbContext.Clientes.FirstOrDefault(c => c.Id == id);

        public Cliente BuscaClienteComEndereco(int id)
            => (from clientes in _dbContext.Clientes
                join endereco in _dbContext.Enderecos on clientes.EnderecoId equals endereco.Id
                where clientes.Id == id
                select new Cliente
                {
                    Id = clientes.Id,
                    Nome = clientes.Nome,
                    Email = clientes.Email,
                    Endereco = new Endereco
                    {
                        Logradouro = endereco.Logradouro,
                        Numero = endereco.Numero,
                        Complemento = endereco.Complemento,
                        Bairro = endereco.Bairro,
                        CidadeId = endereco.CidadeId,
                        Uf = endereco.Uf
                    }
                }).FirstOrDefault()!;

        public void Update(Cliente cliente)
        {
            Cliente clienteExistente = GetById(cliente.Id);
            if (clienteExistente != null) 
            { 
                clienteExistente.Nome = cliente.Nome;
                clienteExistente.Email = cliente.Email;
                _dbContext.SaveChanges();
            }
        }

        public void Delete(Cliente cliente)
        {
            Cliente clienteExistente = GetById(cliente.Id);
            if (clienteExistente != null)
            {
                _dbContext.Remove(clienteExistente);
                _dbContext.SaveChanges();
            }
        }
    }
}
