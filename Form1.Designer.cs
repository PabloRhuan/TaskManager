namespace TaskManager
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
            btnAdicionar = new Button();
            btnConcluir = new Button();
            btnRemover = new Button();
            lstTarefas = new ListBox();
            txtTitulo = new TextBox();
            dtpData = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(494, 398);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(94, 29);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnConcluir
            // 
            btnConcluir.Location = new Point(594, 398);
            btnConcluir.Name = "btnConcluir";
            btnConcluir.Size = new Size(94, 29);
            btnConcluir.TabIndex = 1;
            btnConcluir.Text = "Concluir";
            btnConcluir.UseVisualStyleBackColor = true;
            btnConcluir.Click += btnConcluir_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(694, 398);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(94, 29);
            btnRemover.TabIndex = 2;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // lstTarefas
            // 
            lstTarefas.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstTarefas.FormattingEnabled = true;
            lstTarefas.ItemHeight = 23;
            lstTarefas.Location = new Point(12, 104);
            lstTarefas.Name = "lstTarefas";
            lstTarefas.Size = new Size(454, 303);
            lstTarefas.TabIndex = 3;
            lstTarefas.SelectedIndexChanged += lstTarefas_SelectedIndexChanged;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(12, 48);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.PlaceholderText = "Digite aqui...";
            txtTitulo.Size = new Size(194, 27);
            txtTitulo.TabIndex = 4;
            // 
            // dtpData
            // 
            dtpData.CustomFormat = "";
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(481, 37);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(307, 27);
            dtpData.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(55, 23);
            label1.TabIndex = 6;
            label1.Text = "Tarefa";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(481, 14);
            label2.Name = "label2";
            label2.Size = new Size(46, 23);
            label2.TabIndex = 7;
            label2.Text = "Data";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(12, 78);
            label3.Name = "label3";
            label3.Size = new Size(125, 23);
            label3.TabIndex = 8;
            label3.Text = "Lista de Tarefas";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 449);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpData);
            Controls.Add(txtTitulo);
            Controls.Add(lstTarefas);
            Controls.Add(btnRemover);
            Controls.Add(btnConcluir);
            Controls.Add(btnAdicionar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gerenciador de tarefas";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdicionar;
        private Button btnConcluir;
        private Button btnRemover;
        private ListBox lstTarefas;
        private TextBox txtTitulo;
        private DateTimePicker dtpData;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
