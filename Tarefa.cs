class Tarefa
{
    // Atributos
    public string? titulo;
    public string? descricao;
    public string? dataVencimento;

    // Mandar pra Gerenciador
    protected List<string> tarefa = new List<string>(); // Enviar para Gerenciador como um bloco 
}