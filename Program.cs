using System.Globalization;

string? input;
bool programaFinalizado = false;

string titulo;
string descricao;
string dataVencimento;

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
        Console.Clear();
        Console.WriteLine("ADICIONAR TAREFA");

        Console.WriteLine();

        titulo = Adicionar("Título");
        descricao = Adicionar("Descrição");
        dataVencimento = AdicionarData("Data de vencimento").ToString();

        Tarefa novaTarefa = new Tarefa();
        novaTarefa.titulo = titulo;
        novaTarefa.descricao = descricao;
        novaTarefa.dataVencimento = dataVencimento;
    }
    else if (input?.Trim() == "2")
    {

    }
    else if (input?.Trim() == "3")
    {
        programaFinalizado = true; // Break
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
                    Console.WriteLine("<ERRO> Apenas 's' ou 'n'");
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

DateTime AdicionarData(string data)
{
    DateTime inputData;
    DateTime valorData;

    while (true)
    {
        try
        {
            Console.Write($"{data} (e.g. 10/02/2013): ");
            inputData = DateTime.ParseExact(Console.ReadLine() ?? "", "dd/MM/yyyy", CultureInfo.InvariantCulture);

            if (inputData > DateTime.Now) // Verifica se a data é futura
            {
                Console.WriteLine($"Confirma? {data}: {inputData}");
                Console.WriteLine("(s/n)");
                string input = Console.ReadLine() ?? "";

                if (input.Trim().ToLower() == "s")
                {
                    valorData = inputData;
                    return valorData;
                }
                else if (input.Trim().ToLower() == "n")
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("<ERRO> Apenas 's' ou 'n'");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("<ERRO> A data deve ser futura");
                Console.WriteLine();
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("<ERRO> Digite uma data válida no formato 'dd/MM/yyyy'");
            Console.WriteLine();
        }
    }
}