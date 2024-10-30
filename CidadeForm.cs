namespace ControleClientes
{
    public partial class CidadeForm : Form
    {
        private Cidade cidadeSelecionada;
        private CidadeRepository cidadeRepository = new CidadeRepository();
        public CidadeForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (gridCidade.SelectedRows.Count > 0)
            {
                int id = (int)gridCidade.SelectedRows[0].Cells[0].Value;
                cidadeSelecionada = cidadeRepository.GetById(id);
                txtNome.Text = cidadeSelecionada.Nome;
                cmbUf.Text = cidadeSelecionada.Uf;
                tabCidade.SelectTab(tpCidadeCadastro);
            }
        }

        private void LoadData()
        {
            gridCidade.Rows.Clear();
            foreach (var cliente in cidadeRepository.ReadAll())
            {
                gridCidade.Rows.Add(cliente.Id, cliente.Nome, cliente.Uf);
            }
        }

        private void Limpar()
        {
            txtNome.Clear();
            cmbUf.SelectedIndex = -1;
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            cidadeSelecionada = null;
            tabCidade.SelectTab(tpCidadeCadastro);
            Limpar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cidadeSelecionada == null)
            {
                var cidade = new Cidade
                {
                    Nome = txtNome.Text,
                    Uf = cmbUf.Text
                };
                cidadeRepository.Create(cidade);
            }
            else
            {
                cidadeSelecionada.Nome = txtNome.Text;
                cidadeSelecionada.Uf = cmbUf.Text;
                cidadeRepository.Update(cidadeSelecionada);
            }
            LoadData();
            tabCidade.SelectTab(tpCidadeConsulta);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
            tabCidade.SelectTab(tpCidadeConsulta);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (cidadeSelecionada != null)
            {
                if (MessageBox.Show("Excluir?", "Cidades", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cidadeRepository.Delete(cidadeSelecionada);
                    Limpar();
                    LoadData();
                    tabCidade.SelectTab(tpCidadeConsulta);
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nomeCidade = txtPesquisa.Text.Trim();

            gridCidade.Rows.Clear();

            var cidadeencontrada = cidadeRepository.BuscarPorNomeCidade(nomeCidade);

            foreach (var cidade in cidadeencontrada)
            {
                gridCidade.Rows.Add(cidade.Id, cidade.Nome, cidade.Uf);
            }

            if (cidadeencontrada.Count == 0)
            {
                MessageBox.Show("Nenhuma cidade encontrada com esse nome.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    } 
    
}
