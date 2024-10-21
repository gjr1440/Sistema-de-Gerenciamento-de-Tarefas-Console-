string? input;
bool programaFinalizado = false;

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
        string titulo;
        string descricao;
        string dia, mes, ano;

        Console.Clear();
        Console.WriteLine("ADICIONAR TAREFA");

        Console.WriteLine();

        titulo = Adicionar("Título");
        /*while (true) // Título
        {
            Console.Write("Título: ");
            input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                Console.WriteLine($"Confirma? Título: {input}");
                Console.WriteLine("(s/n)");
                input = Console.ReadLine() ?? "";
                if (input.Trim().ToLower() == "s")
                {
                    break;
                }
                else if (input.Trim().ToLower() == "n")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Apenas 's' ou 'n'");
                }
            }
            else
            {
                continue;
            }
        }*/

        /*while (true) // Descrição
        {
            Console.Write("Descrição: ");
            input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                Console.WriteLine($"Confirma? Descrição: {input}");
                Console.WriteLine("(s/n)");
                input = Console.ReadLine() ?? "";
                if (input.Trim().ToLower() == "s")
                {
                    break;
                }
                else if (input.Trim().ToLower() == "n")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Apenas 's' ou 'n'");
                }
            }
            else
            {
                continue;
            }
        }

        while (true) // Data de vencimento
        {

        }*/
    }
    else if (input?.Trim() == "2")
    {

    }
    else
    {
        continue;
    }
}

string Adicionar(string dado)
{
    while (true)
    {
        Console.Write($"{dado}: ");
        input = Console.ReadLine();

        if (!string.IsNullOrEmpty(input))
        {
            Console.WriteLine($"Confirma? {dado}: {input}");
            Console.WriteLine("(s/n)");
            input = Console.ReadLine() ?? "";
            if (input.Trim().ToLower() == "s")
            {
                return dado;
            }
            else if (input.Trim().ToLower() == "n")
            {
                continue;
            }
            else
            {
                Console.WriteLine("Apenas 's' ou 'n'");
            }
        }
        else
        {
            continue;
        }
    }
}