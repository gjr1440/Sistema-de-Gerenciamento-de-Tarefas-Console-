class Gerenciador
{
    public List<List<string>> tarefas = new List<List<string>>();

    public void CriarTarefa(string titulo, string descricao, DateTime dataVencimento)
    {
        List<string> novaTarefa = new List<string>
        {
            $"Título: {titulo}",
            $"Descrição: {descricao}",
            $"Data de Vencimento: {dataVencimento:dd/MM/yyyy}"
        };

        tarefas.Add(novaTarefa);
        Console.WriteLine("Tarefa adicionada com sucesso!");
    }

    public void ListarTarefas()
    {
        if (tarefas.Count == 0)
        {
            Console.WriteLine("Nenhuma tarefa cadastrada.");
            return;
        }

        for (int i = 0; i < tarefas.Count; i++)
        {
            Console.WriteLine($"TAREFA ({i + 1})");
            foreach (var detalhe in tarefas[i])
            {
                Console.WriteLine(detalhe);
            }
            Console.WriteLine(); // Para separar as tarefas
        }
    }
}