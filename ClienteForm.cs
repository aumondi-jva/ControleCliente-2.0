using System.Text.Json;

namespace ControleClientes
{
    public partial class ClienteForm : Form
    {
        private Cliente clienteSelecionado;
        private List<Cidade> cidades;
        private ClienteRepository clienteRepository = new ClienteRepository();
        private CidadeRepository cidadeRepository = new CidadeRepository();
        private EnderecoRepository enderecoRepository = new EnderecoRepository();

        List<ItemEstadoCivil> estadoCivilItens = new List<ItemEstadoCivil>()
        {
            new ItemEstadoCivil() {Valor = EstadoCivil.Solteiro, Descricao = "Solteiro"},
            new ItemEstadoCivil() {Valor = EstadoCivil.Casado, Descricao = "Casado"},
            new ItemEstadoCivil() {Valor = EstadoCivil.Divorciado, Descricao = "Divorciado"},
            new ItemEstadoCivil() {Valor = EstadoCivil.Viuvo, Descricao = "Viúvo"}
        };

        List<ItemGenero> generoItens = new List<ItemGenero>()
        {
            new ItemGenero() {Valor = Genero.Masculino, Descricao = "Masculino"},
            new ItemGenero() {Valor = Genero.Feminino, Descricao = "Feminino"}
        };

        private void LoadComboBoxEstadoCivil()
        {
            cmbEstadoCivil.DataSource = estadoCivilItens;
            cmbEstadoCivil.DisplayMember = "Descricao";
            cmbEstadoCivil.ValueMember = "Valor";
        }

        private void LoadComboBoxGenero()
        {
            cmbGenero.DataSource = generoItens;
            cmbGenero.DisplayMember = "Descricao";
            cmbGenero.ValueMember = "Valor";
        }

        private void LoadComboBoxCidade()
        {
            var cidadeRepostory = new CidadeRepository();
            cidades = cidadeRepostory.ReadAll();
            cmbCidade.DataSource = cidades;
            cmbCidade.DisplayMember = "Nome";
            cmbCidade.ValueMember = "Id";

        }

        public ClienteForm()
        {
            InitializeComponent();
            LoadData();
            LoadComboBoxEstadoCivil();
            LoadComboBoxGenero();
            LoadComboBoxCidade();
        }
        private void LoadData()
        {
            gridCliente.Rows.Clear();
            foreach (var cliente in clienteRepository.ReadAll())
            {
                gridCliente.Rows.Add(cliente.Id, cliente.Nome, cliente.Email);
            }
        }
        private void Limpar()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtBairro.Clear();
            txtCep.Clear();
            txtComplemento.Clear();
            txtLogadouro.Clear();
            txtNumero.Clear();
            txtUf.Clear();
            cmbEstadoCivil.Text = string.Empty;
            cmbGenero.Text = string.Empty;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            clienteSelecionado = null;
            tabCliente.SelectTab(tpClienteCadastro);
            Limpar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ItemEstadoCivil estadoCivil = (ItemEstadoCivil)cmbEstadoCivil.SelectedItem;
            ItemGenero genero = (ItemGenero)cmbGenero.SelectedItem;
            if (clienteSelecionado == null)
            {
                var endereco = new Endereco
                {
                    Cep = txtCep.Text,
                    Logradouro = txtLogadouro.Text,
                    Numero = Convert.ToInt32(txtNumero.Text),
                    Complemento = txtComplemento.Text,
                    Bairro = txtBairro.Text,
                    CidadeId = ValidarCidade(cmbCidade.Text, txtUf.Text),
                    Uf = txtUf.Text
                };

                var enderecoId = enderecoRepository.Create(endereco);

                var cliente = new Cliente
                {
                    Nome = txtNome.Text,
                    Email = txtEmail.Text,
                    EstadoCivil = estadoCivil.Valor,
                    Genero = genero.Valor,
                    EnderecoId = enderecoId
                };
                clienteRepository.Create(cliente);
            }
            else
            {
                clienteSelecionado.Nome = txtNome.Text;
                clienteSelecionado.Email = txtEmail.Text;
                clienteSelecionado.EstadoCivil = estadoCivil.Valor;
                clienteSelecionado.Genero = genero.Valor;
                clienteRepository.Update(clienteSelecionado);
            }
            LoadData();
            tabCliente.SelectTab(tpClienteConsulta);
        }

        private int ValidarCidade(string nomeCidade, string uf)
        {
            var cidadeRepostory = new CidadeRepository();
            var cidade = cidadeRepostory.GetByName(nomeCidade);

            if (cidade == null)
            {
                var cidadeId = cidadeRepostory.Create(new Cidade
                {
                    Nome = nomeCidade,
                    Uf = uf
                });

                return cidadeId;
            }

            return cidade.Id;
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (gridCliente.SelectedRows.Count > 0)
            {
                int id = (int)gridCliente.SelectedRows[0].Cells[0].Value;
                clienteSelecionado = clienteRepository.BuscaClienteComEndereco(id);
                txtNome.Text = clienteSelecionado.Nome;
                txtEmail.Text = clienteSelecionado.Email;
                cmbEstadoCivil.SelectedItem = estadoCivilItens.FirstOrDefault(e => e.Valor == clienteSelecionado.EstadoCivil);
                cmbGenero.SelectedItem = generoItens.FirstOrDefault(g => g.Valor == clienteSelecionado.Genero);
                txtCep.Text = clienteSelecionado.Endereco.Cep;
                txtLogadouro.Text = clienteSelecionado.Endereco.Logradouro;
                txtNumero.Text = clienteSelecionado.Endereco.Numero.ToString();
                txtComplemento.Text = clienteSelecionado.Endereco.Complemento;
                txtBairro.Text = clienteSelecionado.Endereco.Bairro;
                cmbCidade.Text = cidadeRepository.GetById(clienteSelecionado.Endereco.CidadeId).Nome;
                txtUf.Text = clienteSelecionado.Endereco.Uf;

                tabCliente.SelectTab(tpClienteCadastro);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
            tabCliente.SelectTab(tpClienteConsulta);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (clienteSelecionado != null)
            {
                if (MessageBox.Show("Excluir?", "Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clienteRepository.Delete(clienteSelecionado);
                    Limpar();
                    LoadData();
                    tabCliente.SelectTab(tpClienteConsulta);
                }

            }
        }

        private async Task<Endereco> BuscarEnderecoPorCep(string cep)
        {
            string url = $"https://viacep.com.br/ws/{cep}/json/";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<Endereco>(responseBody);

                }
                else
                {
                    throw new Exception($"Consultando o CEP, Código de status: {response.StatusCode}");
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tpClienteCadastro_Click(object sender, EventArgs e)
        {

        }

        private async void btnBuscarCep_Click(object sender, EventArgs e)
        {
            string cep = txtCep.Text.Trim();

            if (string.IsNullOrEmpty(cep))
            {
                MessageBox.Show("Por favor, insira um CEP válido. ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Endereco endereco = await BuscarEnderecoPorCep(cep);
                txtLogadouro.Text = endereco.Logradouro;
                txtBairro.Text = endereco.Bairro;
                cmbCidade.Text = endereco.Localidade;
                //cmbCidade.SelectedItem = cidades.FirstOrDefault(c => c.Nome.Contains(endereco.Localidade));
                txtUf.Text = endereco.Uf;
                txtNumero.Focus();
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Erro da requisição HTTP: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (JsonException ex)
            {
                MessageBox.Show($"Desserializando o JSON: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nomeCliente = txtPesquisa.Text.Trim();

            gridCliente.Rows.Clear();

            var clientesEncontrados = clienteRepository.BuscarPorNome(nomeCliente);

            foreach (var cliente in clientesEncontrados)
            {
                gridCliente.Rows.Add(cliente.Id, cliente.Nome, cliente.Email);
            }

            if (clientesEncontrados.Count == 0)
            {
                MessageBox.Show("Nenhum cliente encontrado com esse nome.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
