using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        private string caminhoArquivo = "tarefas.json";
        private List<Tarefa> tarefas = new List<Tarefa>();
        private int proximoId = 1;

        public Form1()
        {
            InitializeComponent();
            CarregarTarefas();
        }

        // CREATE
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show("Informe o título da tarefa.");
                return;
            }

            Tarefa tarefa = new Tarefa
            {
                Id = proximoId++,
                Titulo = txtTitulo.Text,
                Data = dtpData.Value,
                Concluida = false
            };

            tarefas.Add(tarefa);
            SalvarTarefas();
            AtualizarLista();

            txtTitulo.Clear();
        }

        // READ
        private void AtualizarLista()
        {
            lstTarefas.Items.Clear();
            foreach (var tarefa in tarefas)
            {
                lstTarefas.Items.Add(tarefa);
            }
        }

        // UPDATE
        private void btnConcluir_Click(object sender, EventArgs e)
        {
            if (lstTarefas.SelectedItem is Tarefa tarefa)
            {
                tarefa.Concluida = true;
                SalvarTarefas();
                AtualizarLista();
            }
        }

        // DELETE
        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lstTarefas.SelectedItem is Tarefa tarefa)
            {
                tarefas.Remove(tarefa);
                SalvarTarefas();
                AtualizarLista();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lstTarefas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SalvarTarefas()
        {
            var json = JsonSerializer.Serialize(tarefas, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(caminhoArquivo, json);
        }

        private void CarregarTarefas()
        {
            if (!File.Exists(caminhoArquivo))
                return;

            var json = File.ReadAllText(caminhoArquivo);
            tarefas = JsonSerializer.Deserialize<List<Tarefa>>(json) ?? new List<Tarefa>();

            // Atualiza o próximo ID
            if (tarefas.Count > 0)
                proximoId = tarefas.Max(t => t.Id) + 1;

            AtualizarLista();
        }
    }
}
