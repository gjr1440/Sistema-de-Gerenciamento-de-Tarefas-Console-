using System.Globalization;

// This fixes the accented characters bug
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;

string? input;
bool programaFinalizado = false;

Gerenciador gerenciador = new Gerenciador();

string titulo;
string descricao;
DateTime dataVencimento;

bool sairListar = true;

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
        dataVencimento = AdicionarData("Data de vencimento");

        gerenciador.CriarTarefa(titulo, descricao, dataVencimento);
    }
    else if (input?.Trim() == "2")
    {
        sairListar = false;
        while (sairListar == false)
        {
            Console.Clear();
            gerenciador.ListarTarefas();

            if (gerenciador.tarefas.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine("--Pressione 'Enter' para voltar--");
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input) || !string.IsNullOrEmpty(input))
                {
                    break;
                }
            }
            else
            {
                while (true)
                {
                    Console.WriteLine("1 - Selecionar tarefa");
                    Console.WriteLine("2 - Voltar ao menu principal");

                    Console.WriteLine();

                    Console.Write("> ");
                    input = Console.ReadLine();
                    if (!string.IsNullOrEmpty(input))
                    {
                        if (input.Trim() == "1")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Para selecionar alguma tarefa, digite seu número");

                            while (true)
                            {
                                Console.Write("> ");
                                input = Console.ReadLine();
                                if (!string.IsNullOrEmpty(input))
                                {
                                    if (Convert.ToInt32(input) >= 1 && Convert.ToInt32(input) <= gerenciador.tarefas.Count)
                                    {
                                        for (int i = 0; i < gerenciador.tarefas.Count; i++)
                                        {
                                            if (Convert.ToInt32(input) == i + 1) // If the input value is equal to List index + 1 (like the Gerenciador.cs logic)
                                            {
                                                foreach (var detalhe in gerenciador.tarefas[i])
                                                {
                                                    Console.WriteLine(detalhe);
                                                }
                                            }
                                        }
                                    }
                                    else if (Convert.ToInt32(input) < 1)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("<ERRO> Digite um número válido");
                                        Console.WriteLine();

                                        continue;
                                    }
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                        else if (input.Trim() == "2")
                        {
                            sairListar = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("<ERRO> Digite '1' ou '2'");
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
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
                input = Console.ReadLine() ?? ""; // Different input
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
                Console.WriteLine($"Confirma? {data}: {inputData:dd/MM/yyyy}");
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