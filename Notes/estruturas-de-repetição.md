// Estruturas de Repetição:

// Introdução ao FOR:

// O FOR exije 3 condições:
// 1 - Inicialização de uma variável de controle (contador)
// 2 - Condição de continuação (enquanto essa condição for verdadeira, o loop continua)
// 3 - Incremento ou decremento da variável de controle

// int numero = 5;

// for(int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }

// ----------------------------------------------------------------------

// Introdução ao WHILE:

// int numero = 5;
// int contador = 1;

// while (contador <= 10)
// {
//     Console.WriteLine($"{contador} Execução: {numero} x {contador} = {numero * contador}");
//     contador++;

//     if (contador == 6)
//     {
//         break;
//     }
// }

// ----------------------------------------------------------------------

// Introdução ao DO WHILE:

// int soma = 0, numero = 0;

// do
// {
//     Console.WriteLine("Digite um número: (0 para sair)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// } while (numero != 0);

// Console.WriteLine($"A soma dos números digitados é: {soma}");

// ----------------------------------------------------------------------

// Construção menu interativo:

string opcao;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a opção desejada:");
    Console.WriteLine("1 - Cadastrar Cliente");
    Console.WriteLine("2 - Buscar Cliente");
    Console.WriteLine("3 - Excluir Cliente");
    Console.WriteLine("4 - Sair");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de Cliente");
            break;
        case "2":
            Console.WriteLine("Busca de Cliente");
            break;
        case "3":
            Console.WriteLine("Exclusão de Cliente");
            break;
        case "4":
            Console.WriteLine("Saindo...");
            exibirMenu = false;
            // Environment.Exit(0); outra opção de sair do programa
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
}

Console.WriteLine("Programa finalizado.");