Console.WriteLine("Digite uma letra: ");
string letra = Console.ReadLine().ToLower();

// Método switch case:

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;
    default:
        Console.WriteLine("Consoante");
        break;
}

// Outro método usando if else:
// O sinal || significa "OU".

// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Consoante");
// }

// Aqui seria o método mais longo usando if else:

// if (letra == "a")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "e")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "i")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "o")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Consoante");
// }

// ---------------------------------------------------------------------

// Operadores condicionais:

// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// // && significa "E" lógico, ou seja, ambas as condições precisam ser verdadeiras para que o resultado seja verdadeiro.

// Console.WriteLine("Quantidade em estoque: " + quantidadeEmEstoque);
// Console.WriteLine("Quantidade compra: " + quantidadeCompra);
// Console.WriteLine("É possível realizar a compra? " + possivelVenda);

// // Dois sinais de == são usados para comparar valores, enquanto um único sinal de = é usado para atribuição de valor a uma variável.

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda inválida.");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada com sucesso!");
// }
// else
// {
//     Console.WriteLine("Não temos a quantidade desejada em estoque.");
// }