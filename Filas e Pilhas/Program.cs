// Coleções - Filas e Pilhas
// Fila (Queue) - FIFO (First In, First Out), primeiro a entrar, primeiro a sair.

Queue<int> fila = new Queue<int>();

fila.Enqueue(2); // Primeiro elemento a entrar na fila e primeiro a sair.
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8); // Último elemento a entrar na fila.

Console.WriteLine("Elementos da fila:");
foreach(int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine("-------------------------");
Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}"); // Remove o primeiro elemento da fila.
fila.Enqueue(10); // Adiciona um novo elemento no final da fila.

foreach(int item in fila)
{
    Console.WriteLine(item);
}

// -------------------------------------------------------------

// Pilha (Stack) - LIFO (Last In, First Out), último a entrar, primeiro a sair.

Stack<int> pilha = new Stack<int>();

pilha.Push(2); // Primeiro elemento a entrar na pilha e último a sair.
pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10); // Último elemento a entrar na pilha e primeiro a sair.

Console.WriteLine("-------------------------");
Console.WriteLine("Elementos da pilha:");
foreach(int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine("-------------------------");
Console.WriteLine($"Removendo elemento do topo: {pilha.Pop()}"); // Remove o último elemento adicionado na pilha (10).

pilha.Push(12); // Adiciona um novo elemento no topo da pilha.

foreach(int item in pilha)
{
    Console.WriteLine(item);
}

// -------------------------------------------------------------

Dictionary<string, string> estados = new Dictionary<string, string>();
estados.Add("SP", "São Paulo");
estados.Add("RJ", "Rio de Janeiro");
estados.Add("MG", "Minas Gerais");
estados.Add("BA", "Bahia");

foreach(var item in estados)
{
    Console.WriteLine($"Chaves: {item.Key}, Valor: {item.Value}");
}

estados.Remove("BA"); // Removendo elementos.
estados["SP"] = "São Paulo - Valor alterado"; // Alterando elementos.

Console.WriteLine("-------------------------");
Console.WriteLine("Removendo Estados:");

foreach(var item in estados)
{
    Console.WriteLine($"Chaves: {item.Key}, Valor: {item.Value}");
}

// -------------------------------------------------------------
// Verificando se existe elemento:

string chave = "BA";
Console.WriteLine($"Verificando o elemento: {chave}");

if (estados.ContainsKey(chave))
{
 Console.WriteLine($"Valor existente: {chave}");   
}
else
{
    Console.WriteLine($"Valor não existe. É seguro adicionar a chave:{chave}");
}