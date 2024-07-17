
namespace Teste_desenvolvimento
{
    partial class Form1
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
            dgPessoa = new DataGridView();
            label1 = new Label();
            txtID = new TextBox();
            txtNome = new TextBox();
            label2 = new Label();
            txtCpf = new TextBox();
            label3 = new Label();
            txtTelefone = new TextBox();
            label4 = new Label();
            btnAdicionar = new Button();
            btnEditar = new Button();
            btnRemover = new Button();
            ((System.ComponentModel.ISupportInitialize)dgPessoa).BeginInit();
            SuspendLayout();
            // 
            // dgPessoa
            // 
            dgPessoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPessoa.Location = new Point(9, 122);
            dgPessoa.Name = "dgPessoa";
            dgPessoa.Size = new Size(581, 120);
            dgPessoa.TabIndex = 0;
            dgPessoa.CellClick += dgPessoa_CellClick;
            dgPessoa.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 1;
            label1.Text = "Id";
            label1.Click += label1_Click;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(12, 36);
            txtID.Name = "txtID";
            txtID.Size = new Size(78, 23);
            txtID.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(105, 36);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(301, 23);
            txtNome.TabIndex = 4;
            txtNome.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 18);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Nome";
            label2.Click += label2_Click;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(12, 80);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(266, 23);
            txtCpf.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 62);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 5;
            label3.Text = "CPF";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(424, 36);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(166, 23);
            txtTelefone.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(421, 18);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 7;
            label4.Text = "Telefone";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(331, 80);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 9;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += button1_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(424, 80);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(515, 80);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 11;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 251);
            Controls.Add(btnRemover);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            Controls.Add(txtTelefone);
            Controls.Add(label4);
            Controls.Add(txtCpf);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(label1);
            Controls.Add(dgPessoa);
            Name = "Form1";
            Text = "Cadastro";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgPessoa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DataGridView dgPessoa;
        private Label label1;
        private TextBox txtID;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtCpf;
        private Label label3;
        private TextBox txtTelefone;
        private Label label4;
        private Button btnAdicionar;
        private Button btnEditar;
        private Button btnRemover;
    }
}
