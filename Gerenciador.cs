class Gerenciador
{
    public List<string> tarefas = new List<string>();

    protected void PegarList(List<string> lista)
    {
        AdicionarTarefa(lista);
    }

    private void AdicionarTarefa(List<string> lista)
    {
        tarefas.AddRange(lista);
        Console.WriteLine("Pegou");
    }
}