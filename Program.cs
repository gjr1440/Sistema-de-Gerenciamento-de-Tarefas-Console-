string? input;
bool programaFinalizado = false;

string titulo = "";
string descricao = "";
string dia = "";
string mes = "";
string ano = "";

while (programaFinalizado == false)
{
    Console.Clear();
    Console.WriteLine("GERENCIADOR DE TAREFAS");

    Console.WriteLine();

    Console.WriteLine("1 - Adicionar tarefa");
    Console.WriteLine("2 - Listar tarefas");
    Console.WriteLine("3 - Sair");

    Console.WriteLine();

    Console.Write("> ");
    input = Console.ReadLine();
    if (input?.Trim() == "1")
    {
        Tarefa tarefa = new Tarefa();

        Console.Clear();
        Console.WriteLine("ADICIONAR TAREFA");

        Console.WriteLine();

        titulo = Adicionar("Título");
        descricao = Adicionar("Descrição");
        ano = Adicionar("Ano");
        mes = Adicionar("Mês");
        dia = Adicionar("Dia");
        
    }
    else if (input?.Trim() == "2")
    {

    }
    else if (input?.Trim() == "3")
    {
        Console.Clear();
        Console.WriteLine(titulo);
        Console.WriteLine(descricao);
        break;
    }
    else
    {
        continue;
    }
}

string Adicionar(string dado)
{
    string? inputDado;
    string valorDado;

    while (true)
    {
        Console.Write($"{dado}: ");
        inputDado = Console.ReadLine();

        if (!string.IsNullOrEmpty(inputDado))
        {
            while (true)
            {
                Console.WriteLine($"Confirma? {dado}: {inputDado}");
                Console.WriteLine("(s/n)");
                input = Console.ReadLine() ?? ""; // input diferente
                if (input.Trim().ToLower() == "s")
                {
                    valorDado = inputDado;
                    return valorDado;
                }
                else if (input.Trim().ToLower() == "n")
                {
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Apenas 's' ou 'n'");
                    Console.WriteLine();
                }
            }
        }
        else
        {
            continue;
        }
    }
}