namespace Crud_Aluno_EM
{
    partial class FormCadastro
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
            this.gbxNovoAluno = new System.Windows.Forms.GroupBox();
            this.mtbNascimento = new System.Windows.Forms.MaskedTextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cbxSexo = new System.Windows.Forms.ComboBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.gbxDados = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvDadosAlunos = new System.Windows.Forms.DataGridView();
            this.dgvMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxNovoAluno.SuspendLayout();
            this.gbxDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxNovoAluno
            // 
            this.gbxNovoAluno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxNovoAluno.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gbxNovoAluno.Controls.Add(this.mtbNascimento);
            this.gbxNovoAluno.Controls.Add(this.btnAdicionar);
            this.gbxNovoAluno.Controls.Add(this.btnLimpar);
            this.gbxNovoAluno.Controls.Add(this.cbxSexo);
            this.gbxNovoAluno.Controls.Add(this.txtCPF);
            this.gbxNovoAluno.Controls.Add(this.txtNome);
            this.gbxNovoAluno.Controls.Add(this.txtMatricula);
            this.gbxNovoAluno.Controls.Add(this.lblNascimento);
            this.gbxNovoAluno.Controls.Add(this.lblCPF);
            this.gbxNovoAluno.Controls.Add(this.lblNome);
            this.gbxNovoAluno.Controls.Add(this.lblSexo);
            this.gbxNovoAluno.Controls.Add(this.lblMatricula);
            this.gbxNovoAluno.Location = new System.Drawing.Point(0, 12);
            this.gbxNovoAluno.Name = "gbxNovoAluno";
            this.gbxNovoAluno.Size = new System.Drawing.Size(800, 141);
            this.gbxNovoAluno.TabIndex = 0;
            this.gbxNovoAluno.TabStop = false;
            this.gbxNovoAluno.Text = "Novo Aluno";
            // 
            // mtbNascimento
            // 
            this.mtbNascimento.Location = new System.Drawing.Point(229, 100);
            this.mtbNascimento.Mask = "00/00/0000";
            this.mtbNascimento.Name = "mtbNascimento";
            this.mtbNascimento.Size = new System.Drawing.Size(154, 23);
            this.mtbNascimento.TabIndex = 4;
            this.mtbNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdicionar.Location = new System.Drawing.Point(710, 100);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 26);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLimpar.Location = new System.Drawing.Point(615, 100);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 25);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // cbxSexo
            // 
            this.cbxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSexo.Location = new System.Drawing.Point(20, 100);
            this.cbxSexo.Name = "cbxSexo";
            this.cbxSexo.Size = new System.Drawing.Size(174, 23);
            this.cbxSexo.TabIndex = 3;
            // 
            // txtCPF
            // 
            this.txtCPF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCPF.Location = new System.Drawing.Point(409, 99);
            this.txtCPF.MaxLength = 11;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.ShortcutsEnabled = false;
            this.txtCPF.Size = new System.Drawing.Size(186, 23);
            this.txtCPF.TabIndex = 5;
            this.txtCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPF_KeyPress);
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Location = new System.Drawing.Point(229, 45);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.ShortcutsEnabled = false;
            this.txtNome.Size = new System.Drawing.Size(556, 23);
            this.txtNome.TabIndex = 2;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(20, 45);
            this.txtMatricula.MaxLength = 9;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.ShortcutsEnabled = false;
            this.txtMatricula.Size = new System.Drawing.Size(174, 23);
            this.txtMatricula.TabIndex = 1;
            this.txtMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatricula_KeyPress);
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(229, 82);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(79, 15);
            this.lblNascimento.TabIndex = 4;
            this.lblNascimento.Text = "Nascimento *";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(409, 81);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(87, 15);
            this.lblCPF.TabIndex = 3;
            this.lblCPF.Text = "CPF (Opcional)";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(229, 27);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(48, 15);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome *";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(20, 82);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(40, 15);
            this.lblSexo.TabIndex = 1;
            this.lblSexo.Text = "Sexo *";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(20, 27);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(65, 15);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matricula *";
            // 
            // gbxDados
            // 
            this.gbxDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxDados.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gbxDados.Controls.Add(this.btnExcluir);
            this.gbxDados.Controls.Add(this.btnEditar);
            this.gbxDados.Controls.Add(this.txtPesquisa);
            this.gbxDados.Controls.Add(this.btnPesquisar);
            this.gbxDados.Controls.Add(this.dgvDadosAlunos);
            this.gbxDados.Location = new System.Drawing.Point(0, 170);
            this.gbxDados.Name = "gbxDados";
            this.gbxDados.Size = new System.Drawing.Size(800, 271);
            this.gbxDados.TabIndex = 1;
            this.gbxDados.TabStop = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Location = new System.Drawing.Point(710, 239);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Location = new System.Drawing.Point(615, 239);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.Location = new System.Drawing.Point(12, 22);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(678, 23);
            this.txtPesquisa.TabIndex = 8;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.Location = new System.Drawing.Point(696, 22);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(89, 23);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dgvDadosAlunos
            // 
            this.dgvDadosAlunos.AllowUserToAddRows = false;
            this.dgvDadosAlunos.AllowUserToDeleteRows = false;
            this.dgvDadosAlunos.AllowUserToOrderColumns = true;
            this.dgvDadosAlunos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDadosAlunos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDadosAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMatricula,
            this.dgvNome,
            this.dgvSexo,
            this.dgvNascimento,
            this.dgvCPF});
            this.dgvDadosAlunos.Location = new System.Drawing.Point(12, 60);
            this.dgvDadosAlunos.Name = "dgvDadosAlunos";
            this.dgvDadosAlunos.ReadOnly = true;
            this.dgvDadosAlunos.RowHeadersVisible = false;
            this.dgvDadosAlunos.RowTemplate.Height = 25;
            this.dgvDadosAlunos.Size = new System.Drawing.Size(773, 173);
            this.dgvDadosAlunos.TabIndex = 0;
            // 
            // dgvMatricula
            // 
            this.dgvMatricula.DataPropertyName = "Matricula";
            this.dgvMatricula.HeaderText = "Matricula";
            this.dgvMatricula.Name = "dgvMatricula";
            this.dgvMatricula.ReadOnly = true;
            // 
            // dgvNome
            // 
            this.dgvNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvNome.DataPropertyName = "Nome";
            this.dgvNome.HeaderText = "Nome";
            this.dgvNome.Name = "dgvNome";
            this.dgvNome.ReadOnly = true;
            // 
            // dgvSexo
            // 
            this.dgvSexo.DataPropertyName = "Sexo";
            this.dgvSexo.HeaderText = "Sexo";
            this.dgvSexo.Name = "dgvSexo";
            this.dgvSexo.ReadOnly = true;
            // 
            // dgvNascimento
            // 
            this.dgvNascimento.DataPropertyName = "Nascimento";
            this.dgvNascimento.HeaderText = "Nascimento";
            this.dgvNascimento.Name = "dgvNascimento";
            this.dgvNascimento.ReadOnly = true;
            // 
            // dgvCPF
            // 
            this.dgvCPF.DataPropertyName = "CPF";
            this.dgvCPF.HeaderText = "CPF";
            this.dgvCPF.Name = "dgvCPF";
            this.dgvCPF.ReadOnly = true;
            this.dgvCPF.Width = 110;
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(797, 453);
            this.Controls.Add(this.gbxDados);
            this.Controls.Add(this.gbxNovoAluno);
            this.Name = "FormCadastro";
            this.Text = "EM";
            this.gbxNovoAluno.ResumeLayout(false);
            this.gbxNovoAluno.PerformLayout();
            this.gbxDados.ResumeLayout(false);
            this.gbxDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosAlunos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbxNovoAluno;
        private Label lblNascimento;
        private Label lblCPF;
        private Label lblNome;
        private Label lblSexo;
        private Label lblMatricula;
        private Button btnAdicionar;
        private Button btnLimpar;
        private ComboBox cbxSexo;
        private TextBox txtCPF;
        private TextBox txtNome;
        private TextBox txtMatricula;
        private GroupBox gbxDados;
        private Button btnExcluir;
        private Button btnEditar;
        private TextBox txtPesquisa;
        private Button btnPesquisar;
        private DataGridView dgvDadosAlunos;
        private MaskedTextBox mtbNascimento;
        private DataGridViewTextBoxColumn dgvMatricula;
        private DataGridViewTextBoxColumn dgvNome;
        private DataGridViewTextBoxColumn dgvSexo;
        private DataGridViewTextBoxColumn dgvNascimento;
        private DataGridViewTextBoxColumn dgvCPF;
    }
}