namespace ControleClientes
{
    partial class CidadeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabCidade = new TabControl();
            tpCidadeConsulta = new TabPage();
            gridCidade = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNome = new DataGridViewTextBoxColumn();
            colUf = new DataGridViewTextBoxColumn();
            pnlAcao = new Panel();
            btnVisualizar = new Button();
            btnNovo = new Button();
            pnlPesquisa = new Panel();
            btnPesquisar = new Button();
            txtPesquisa = new TextBox();
            tpCidadeCadastro = new TabPage();
            cmbUf = new ComboBox();
            label2 = new Label();
            txtNome = new TextBox();
            label1 = new Label();
            pnlAcaoCadastro = new Panel();
            btnExcluir = new Button();
            btnCancelar = new Button();
            btnSalvar = new Button();
            tabCidade.SuspendLayout();
            tpCidadeConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridCidade).BeginInit();
            pnlAcao.SuspendLayout();
            pnlPesquisa.SuspendLayout();
            tpCidadeCadastro.SuspendLayout();
            pnlAcaoCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tabCidade
            // 
            tabCidade.Controls.Add(tpCidadeConsulta);
            tabCidade.Controls.Add(tpCidadeCadastro);
            tabCidade.Dock = DockStyle.Fill;
            tabCidade.Location = new Point(0, 0);
            tabCidade.Margin = new Padding(3, 4, 3, 4);
            tabCidade.Name = "tabCidade";
            tabCidade.SelectedIndex = 0;
            tabCidade.Size = new Size(914, 461);
            tabCidade.TabIndex = 0;
            // 
            // tpCidadeConsulta
            // 
            tpCidadeConsulta.Controls.Add(gridCidade);
            tpCidadeConsulta.Controls.Add(pnlAcao);
            tpCidadeConsulta.Controls.Add(pnlPesquisa);
            tpCidadeConsulta.Location = new Point(4, 29);
            tpCidadeConsulta.Margin = new Padding(3, 4, 3, 4);
            tpCidadeConsulta.Name = "tpCidadeConsulta";
            tpCidadeConsulta.Padding = new Padding(3, 4, 3, 4);
            tpCidadeConsulta.Size = new Size(906, 428);
            tpCidadeConsulta.TabIndex = 0;
            tpCidadeConsulta.Text = "Consulta";
            tpCidadeConsulta.UseVisualStyleBackColor = true;
            // 
            // gridCidade
            // 
            gridCidade.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridCidade.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCidade.Columns.AddRange(new DataGridViewColumn[] { colId, colNome, colUf });
            gridCidade.Dock = DockStyle.Fill;
            gridCidade.Location = new Point(3, 45);
            gridCidade.Margin = new Padding(3, 4, 3, 4);
            gridCidade.Name = "gridCidade";
            gridCidade.RowHeadersWidth = 20;
            gridCidade.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridCidade.Size = new Size(900, 338);
            gridCidade.TabIndex = 7;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            // 
            // colNome
            // 
            colNome.HeaderText = "Nome";
            colNome.MinimumWidth = 6;
            colNome.Name = "colNome";
            // 
            // colUf
            // 
            colUf.HeaderText = "UF";
            colUf.MinimumWidth = 6;
            colUf.Name = "colUf";
            // 
            // pnlAcao
            // 
            pnlAcao.Controls.Add(btnVisualizar);
            pnlAcao.Controls.Add(btnNovo);
            pnlAcao.Dock = DockStyle.Bottom;
            pnlAcao.Location = new Point(3, 383);
            pnlAcao.Margin = new Padding(3, 4, 3, 4);
            pnlAcao.Name = "pnlAcao";
            pnlAcao.Size = new Size(900, 41);
            pnlAcao.TabIndex = 6;
            // 
            // btnVisualizar
            // 
            btnVisualizar.Image = Properties.Resources.icons8_visível_16;
            btnVisualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVisualizar.Location = new Point(665, 7);
            btnVisualizar.Margin = new Padding(3, 4, 3, 4);
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Size = new Size(123, 31);
            btnVisualizar.TabIndex = 0;
            btnVisualizar.Text = "Visualizar";
            btnVisualizar.UseVisualStyleBackColor = true;
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Image = Properties.Resources.icons8_adicionar_16;
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.Location = new Point(794, 7);
            btnNovo.Margin = new Padding(3, 4, 3, 4);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(86, 31);
            btnNovo.TabIndex = 1;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // pnlPesquisa
            // 
            pnlPesquisa.Controls.Add(btnPesquisar);
            pnlPesquisa.Controls.Add(txtPesquisa);
            pnlPesquisa.Dock = DockStyle.Top;
            pnlPesquisa.Location = new Point(3, 4);
            pnlPesquisa.Margin = new Padding(3, 4, 3, 4);
            pnlPesquisa.Name = "pnlPesquisa";
            pnlPesquisa.Size = new Size(900, 41);
            pnlPesquisa.TabIndex = 5;
            // 
            // btnPesquisar
            // 
            btnPesquisar.ForeColor = SystemColors.ControlText;
            btnPesquisar.Image = Properties.Resources.icons8_pesquisar_16;
            btnPesquisar.ImageAlign = ContentAlignment.MiddleLeft;
            btnPesquisar.Location = new Point(753, 4);
            btnPesquisar.Margin = new Padding(3, 4, 3, 4);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(129, 31);
            btnPesquisar.TabIndex = 3;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(0, 4);
            txtPesquisa.Margin = new Padding(3, 4, 3, 4);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PlaceholderText = "Pesquisar por nome";
            txtPesquisa.Size = new Size(746, 27);
            txtPesquisa.TabIndex = 2;
            // 
            // tpCidadeCadastro
            // 
            tpCidadeCadastro.Controls.Add(cmbUf);
            tpCidadeCadastro.Controls.Add(label2);
            tpCidadeCadastro.Controls.Add(txtNome);
            tpCidadeCadastro.Controls.Add(label1);
            tpCidadeCadastro.Controls.Add(pnlAcaoCadastro);
            tpCidadeCadastro.Location = new Point(4, 29);
            tpCidadeCadastro.Margin = new Padding(3, 4, 3, 4);
            tpCidadeCadastro.Name = "tpCidadeCadastro";
            tpCidadeCadastro.Padding = new Padding(3, 4, 3, 4);
            tpCidadeCadastro.Size = new Size(906, 428);
            tpCidadeCadastro.TabIndex = 1;
            tpCidadeCadastro.Text = "Cadastro";
            tpCidadeCadastro.UseVisualStyleBackColor = true;
            // 
            // cmbUf
            // 
            cmbUf.FormattingEnabled = true;
            cmbUf.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cmbUf.Location = new Point(29, 135);
            cmbUf.Margin = new Padding(3, 4, 3, 4);
            cmbUf.Name = "cmbUf";
            cmbUf.Size = new Size(66, 28);
            cmbUf.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 111);
            label2.Name = "label2";
            label2.Size = new Size(26, 20);
            label2.TabIndex = 8;
            label2.Text = "UF";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(29, 60);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(335, 27);
            txtNome.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 36);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 6;
            label1.Text = "Cidade";
            // 
            // pnlAcaoCadastro
            // 
            pnlAcaoCadastro.Controls.Add(btnExcluir);
            pnlAcaoCadastro.Controls.Add(btnCancelar);
            pnlAcaoCadastro.Controls.Add(btnSalvar);
            pnlAcaoCadastro.Dock = DockStyle.Bottom;
            pnlAcaoCadastro.Location = new Point(3, 387);
            pnlAcaoCadastro.Margin = new Padding(3, 4, 3, 4);
            pnlAcaoCadastro.Name = "pnlAcaoCadastro";
            pnlAcaoCadastro.Size = new Size(900, 37);
            pnlAcaoCadastro.TabIndex = 5;
            // 
            // btnExcluir
            // 
            btnExcluir.Image = Properties.Resources.icons8_lixo_16;
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.Location = new Point(6, 4);
            btnExcluir.Margin = new Padding(3, 4, 3, 4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(86, 31);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.icons8_cancelar_16;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(781, 3);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 31);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = Properties.Resources.icons8_salvar_16;
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(678, 3);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(97, 31);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // CidadeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 461);
            Controls.Add(tabCidade);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CidadeForm";
            Text = "Cadastro de Cidades";
            tabCidade.ResumeLayout(false);
            tpCidadeConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridCidade).EndInit();
            pnlAcao.ResumeLayout(false);
            pnlPesquisa.ResumeLayout(false);
            pnlPesquisa.PerformLayout();
            tpCidadeCadastro.ResumeLayout(false);
            tpCidadeCadastro.PerformLayout();
            pnlAcaoCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabCidade;
        private TabPage tpCidadeConsulta;
        private TabPage tpCidadeCadastro;
        private DataGridView gridCidade;
        private Panel pnlAcao;
        private Button btnVisualizar;
        private Button btnNovo;
        private Panel pnlPesquisa;
        private Button btnPesquisar;
        private TextBox txtPesquisa;
        private Panel pnlAcaoCadastro;
        private Button btnExcluir;
        private Button btnCancelar;
        private Button btnSalvar;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colUf;
        private ComboBox cmbUf;
        private Label label2;
        private TextBox txtNome;
        private Label label1;
    }
}