namespace TaskManager
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime Data { get; set; }
        public bool Concluida { get; set; }

        public override string ToString()
        {
            string status = Concluida ? "✔ Concluída" : "⏳ Pendente";
            return $"{status} | {Titulo} | {Data:dd/MM/yyyy}";
        }

    }
}
