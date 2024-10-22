class Tarefa : Gerenciador
{
    protected List<string> tarefa = new List<string>();

    public Tarefa(string? titulo, string? descricao, string? dataVencimento)
    {
        CriarList(titulo, descricao, dataVencimento);
        PegarList(tarefa); // Isso vem do Gerenciador (herança)
    }

    private void CriarList(string? titulo, string? descricao, string? dataVencimento)
    {
        if (!string.IsNullOrWhiteSpace(titulo))
        {
            tarefa.Add(titulo);
        }

        if (!string.IsNullOrWhiteSpace(descricao))
        {
            tarefa.Add(descricao);
        }

        if (!string.IsNullOrWhiteSpace(dataVencimento))
        {
            tarefa.Add(dataVencimento);
        }
    }
}