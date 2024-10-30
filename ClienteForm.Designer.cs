namespace ControleClientes
{
    partial class ClienteForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabCliente = new TabControl();
            tpClienteConsulta = new TabPage();
            gridCliente = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNome = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            pnlPesquisa = new Panel();
            btnPesquisar = new Button();
            txtPesquisa = new TextBox();
            pnlAcao = new Panel();
            btnVisualizar = new Button();
            btnNovo = new Button();
            tpClienteCadastro = new TabPage();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            cmbCidade = new ComboBox();
            txtUf = new TextBox();
            txtBairro = new TextBox();
            txtComplemento = new TextBox();
            label7 = new Label();
            txtNumero = new TextBox();
            label6 = new Label();
            txtLogadouro = new TextBox();
            btnBuscarCep = new Button();
            label5 = new Label();
            txtCep = new MaskedTextBox();
            cmbGenero = new ComboBox();
            label4 = new Label();
            cmbEstadoCivil = new ComboBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            txtNome = new TextBox();
            label1 = new Label();
            pnlAcaoCadastro = new Panel();
            btnExcluir = new Button();
            btnCancelar = new Button();
            btnSalvar = new Button();
            tabCliente.SuspendLayout();
            tpClienteConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridCliente).BeginInit();
            pnlPesquisa.SuspendLayout();
            pnlAcao.SuspendLayout();
            tpClienteCadastro.SuspendLayout();
            pnlAcaoCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tabCliente
            // 
            tabCliente.Controls.Add(tpClienteConsulta);
            tabCliente.Controls.Add(tpClienteCadastro);
            tabCliente.Dock = DockStyle.Fill;
            tabCliente.Location = new Point(0, 0);
            tabCliente.Margin = new Padding(3, 4, 3, 4);
            tabCliente.Name = "tabCliente";
            tabCliente.SelectedIndex = 0;
            tabCliente.Size = new Size(902, 433);
            tabCliente.TabIndex = 0;
            // 
            // tpClienteConsulta
            // 
            tpClienteConsulta.Controls.Add(gridCliente);
            tpClienteConsulta.Controls.Add(pnlPesquisa);
            tpClienteConsulta.Controls.Add(pnlAcao);
            tpClienteConsulta.Location = new Point(4, 29);
            tpClienteConsulta.Margin = new Padding(3, 4, 3, 4);
            tpClienteConsulta.Name = "tpClienteConsulta";
            tpClienteConsulta.Padding = new Padding(3, 4, 3, 4);
            tpClienteConsulta.Size = new Size(894, 400);
            tpClienteConsulta.TabIndex = 0;
            tpClienteConsulta.Text = "Consulta";
            tpClienteConsulta.UseVisualStyleBackColor = true;
            // 
            // gridCliente
            // 
            gridCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCliente.Columns.AddRange(new DataGridViewColumn[] { colId, colNome, colEmail });
            gridCliente.Dock = DockStyle.Fill;
            gridCliente.Location = new Point(3, 45);
            gridCliente.Margin = new Padding(3, 4, 3, 4);
            gridCliente.Name = "gridCliente";
            gridCliente.RowHeadersWidth = 20;
            gridCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridCliente.Size = new Size(888, 310);
            gridCliente.TabIndex = 4;
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
            // colEmail
            // 
            colEmail.HeaderText = "E-mail";
            colEmail.MinimumWidth = 6;
            colEmail.Name = "colEmail";
            // 
            // pnlPesquisa
            // 
            pnlPesquisa.Controls.Add(btnPesquisar);
            pnlPesquisa.Controls.Add(txtPesquisa);
            pnlPesquisa.Dock = DockStyle.Top;
            pnlPesquisa.Location = new Point(3, 4);
            pnlPesquisa.Margin = new Padding(3, 4, 3, 4);
            pnlPesquisa.Name = "pnlPesquisa";
            pnlPesquisa.Size = new Size(888, 41);
            pnlPesquisa.TabIndex = 3;
            // 
            // btnPesquisar
            // 
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
            // pnlAcao
            // 
            pnlAcao.Controls.Add(btnVisualizar);
            pnlAcao.Controls.Add(btnNovo);
            pnlAcao.Dock = DockStyle.Bottom;
            pnlAcao.Location = new Point(3, 355);
            pnlAcao.Margin = new Padding(3, 4, 3, 4);
            pnlAcao.Name = "pnlAcao";
            pnlAcao.Size = new Size(888, 41);
            pnlAcao.TabIndex = 2;
            // 
            // btnVisualizar
            // 
            btnVisualizar.Image = Properties.Resources.icons8_visível_16;
            btnVisualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVisualizar.Location = new Point(669, 7);
            btnVisualizar.Margin = new Padding(3, 4, 3, 4);
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Size = new Size(119, 31);
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
            // tpClienteCadastro
            // 
            tpClienteCadastro.Controls.Add(label11);
            tpClienteCadastro.Controls.Add(label10);
            tpClienteCadastro.Controls.Add(label9);
            tpClienteCadastro.Controls.Add(label8);
            tpClienteCadastro.Controls.Add(cmbCidade);
            tpClienteCadastro.Controls.Add(txtUf);
            tpClienteCadastro.Controls.Add(txtBairro);
            tpClienteCadastro.Controls.Add(txtComplemento);
            tpClienteCadastro.Controls.Add(label7);
            tpClienteCadastro.Controls.Add(txtNumero);
            tpClienteCadastro.Controls.Add(label6);
            tpClienteCadastro.Controls.Add(txtLogadouro);
            tpClienteCadastro.Controls.Add(btnBuscarCep);
            tpClienteCadastro.Controls.Add(label5);
            tpClienteCadastro.Controls.Add(txtCep);
            tpClienteCadastro.Controls.Add(cmbGenero);
            tpClienteCadastro.Controls.Add(label4);
            tpClienteCadastro.Controls.Add(cmbEstadoCivil);
            tpClienteCadastro.Controls.Add(label3);
            tpClienteCadastro.Controls.Add(txtEmail);
            tpClienteCadastro.Controls.Add(label2);
            tpClienteCadastro.Controls.Add(txtNome);
            tpClienteCadastro.Controls.Add(label1);
            tpClienteCadastro.Controls.Add(pnlAcaoCadastro);
            tpClienteCadastro.Location = new Point(4, 29);
            tpClienteCadastro.Margin = new Padding(3, 4, 3, 4);
            tpClienteCadastro.Name = "tpClienteCadastro";
            tpClienteCadastro.Padding = new Padding(3, 4, 3, 4);
            tpClienteCadastro.Size = new Size(894, 400);
            tpClienteCadastro.TabIndex = 1;
            tpClienteCadastro.Text = "Cadastro";
            tpClienteCadastro.UseVisualStyleBackColor = true;
            tpClienteCadastro.Click += tpClienteCadastro_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(797, 241);
            label11.Name = "label11";
            label11.Size = new Size(26, 20);
            label11.TabIndex = 23;
            label11.Text = "UF";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(518, 241);
            label10.Name = "label10";
            label10.Size = new Size(56, 20);
            label10.TabIndex = 22;
            label10.Text = "Cidade";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(231, 241);
            label9.Name = "label9";
            label9.Size = new Size(49, 20);
            label9.TabIndex = 21;
            label9.Text = "Bairro";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 241);
            label8.Name = "label8";
            label8.Size = new Size(104, 20);
            label8.TabIndex = 20;
            label8.Text = "Complemento";
            // 
            // cmbCidade
            // 
            cmbCidade.FormattingEnabled = true;
            cmbCidade.Location = new Point(518, 263);
            cmbCidade.Margin = new Padding(3, 4, 3, 4);
            cmbCidade.Name = "cmbCidade";
            cmbCidade.Size = new Size(276, 28);
            cmbCidade.TabIndex = 19;
            // 
            // txtUf
            // 
            txtUf.Location = new Point(797, 264);
            txtUf.Name = "txtUf";
            txtUf.Size = new Size(69, 27);
            txtUf.TabIndex = 18;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(231, 264);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(281, 27);
            txtBairro.TabIndex = 16;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(24, 264);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(201, 27);
            txtComplemento.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(731, 177);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 14;
            label7.Text = "Numero";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(731, 200);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(125, 27);
            txtNumero.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(231, 177);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 12;
            label6.Text = "Logadouro";
            // 
            // txtLogadouro
            // 
            txtLogadouro.Location = new Point(231, 200);
            txtLogadouro.Name = "txtLogadouro";
            txtLogadouro.Size = new Size(494, 27);
            txtLogadouro.TabIndex = 11;
            // 
            // btnBuscarCep
            // 
            btnBuscarCep.Location = new Point(135, 200);
            btnBuscarCep.Name = "btnBuscarCep";
            btnBuscarCep.Size = new Size(90, 29);
            btnBuscarCep.TabIndex = 10;
            btnBuscarCep.Text = "Buscar";
            btnBuscarCep.UseVisualStyleBackColor = true;
            btnBuscarCep.Click += btnBuscarCep_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 177);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 9;
            label5.Text = "CEP";
            label5.Click += label5_Click;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(24, 200);
            txtCep.Mask = "99999-999";
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(105, 27);
            txtCep.TabIndex = 8;
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(718, 53);
            cmbGenero.Margin = new Padding(3, 4, 3, 4);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(138, 28);
            cmbGenero.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(718, 29);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 6;
            label4.Text = "Genero";
            // 
            // cmbEstadoCivil
            // 
            cmbEstadoCivil.FormattingEnabled = true;
            cmbEstadoCivil.Location = new Point(718, 129);
            cmbEstadoCivil.Margin = new Padding(3, 4, 3, 4);
            cmbEstadoCivil.Name = "cmbEstadoCivil";
            cmbEstadoCivil.Size = new Size(138, 28);
            cmbEstadoCivil.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(718, 105);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 4;
            label3.Text = "Estado civil";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(24, 129);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(688, 27);
            txtEmail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 105);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 2;
            label2.Text = "E-mail";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(24, 53);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(688, 27);
            txtNome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 29);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // pnlAcaoCadastro
            // 
            pnlAcaoCadastro.Controls.Add(btnExcluir);
            pnlAcaoCadastro.Controls.Add(btnCancelar);
            pnlAcaoCadastro.Controls.Add(btnSalvar);
            pnlAcaoCadastro.Dock = DockStyle.Bottom;
            pnlAcaoCadastro.Location = new Point(3, 359);
            pnlAcaoCadastro.Margin = new Padding(3, 4, 3, 4);
            pnlAcaoCadastro.Name = "pnlAcaoCadastro";
            pnlAcaoCadastro.Size = new Size(888, 37);
            pnlAcaoCadastro.TabIndex = 4;
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
            btnCancelar.Location = new Point(778, 3);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(102, 31);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = Properties.Resources.icons8_salvar_16;
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(686, 3);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(86, 31);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // ClienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 433);
            Controls.Add(tabCliente);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ClienteForm";
            Text = "Cadastro de Clientes";
            tabCliente.ResumeLayout(false);
            tpClienteConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridCliente).EndInit();
            pnlPesquisa.ResumeLayout(false);
            pnlPesquisa.PerformLayout();
            pnlAcao.ResumeLayout(false);
            tpClienteCadastro.ResumeLayout(false);
            tpClienteCadastro.PerformLayout();
            pnlAcaoCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabCliente;
        private TabPage tpClienteConsulta;
        private TabPage tpClienteCadastro;
        private Panel pnlAcao;
        private Button btnVisualizar;
        private Button btnNovo;
        private Panel pnlPesquisa;
        private Button btnPesquisar;
        private TextBox txtPesquisa;
        private DataGridView gridCliente;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colEmail;
        private Panel pnlAcaoCadastro;
        private Button btnCancelar;
        private Button btnSalvar;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtNome;
        private Label label1;
        private Button btnExcluir;
        private ComboBox cmbEstadoCivil;
        private Label label3;
        private Label label4;
        private ComboBox cmbGenero;
        private Label label5;
        private MaskedTextBox txtCep;
        private Label label6;
        private TextBox txtLogadouro;
        private Button btnBuscarCep;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private ComboBox cmbCidade;
        private TextBox txtUf;
        private TextBox txtBairro;
        private TextBox txtComplemento;
        private Label label7;
        private TextBox txtNumero;
    }
}
