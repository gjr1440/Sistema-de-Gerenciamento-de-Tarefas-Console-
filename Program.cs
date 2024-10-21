string? input;
bool programaFinalizado = false;

while (programaFinalizado == false)
{
    Console.WriteLine("GERENCIADOR DE TAREFAS");

    Console.WriteLine();

    Console.WriteLine("1 - Adicionar tarefa");
    Console.WriteLine("2 - Listar tarefas");

    Console.WriteLine();

    Console.Write("> ");
    input = Console.ReadLine();
    if (input?.Trim() == "1")
    {
        while (true)
        {
            Console.WriteLine("ADICIONAR TAREFA");

            Console.WriteLine();


        }
    }
    else if (input?.Trim() == "2")
    {

    }
    else
    {
        continue;
    }
}