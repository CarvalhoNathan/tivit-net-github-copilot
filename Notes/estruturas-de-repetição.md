# 🔄 Estruturas de Repetição (Loops)

As estruturas de repetição permitem executar o mesmo bloco de código várias vezes até que uma condição seja atendida.

---

## 🔁 Laço FOR

O `for` é utilizado quando sabemos exatamente quantas vezes o código deve ser executado. Ele exige três condições:

1. **Inicialização:** Variável de controle (contador).
2. **Condição:** Enquanto for verdadeira, o loop continua.
3. **Passo:** Incremento ou decremento da variável.

```csharp
int numero = 5;

for(int contador = 0; contador <= 10; contador++)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
}

```

*Ideal para tabuadas e percorrer arrays!* 🔢

---

## 🔄 Laço WHILE

O `while` (enquanto) é usado quando não sabemos o número exato de repetições, mas temos uma condição de parada.

```csharp
int numero = 5;
int contador = 1;

while (contador <= 10)
{
    Console.WriteLine($"{contador} Execução: {numero} x {contador} = {numero * contador}");
    contador++;

    // Exemplo de interrupção forçada com break
    if (contador == 6)
    {
        break; 🛑 // Para o loop imediatamente
    }
}

```

---

## 🔁 Laço DO WHILE

Diferente do `while`, o `do while` garante que o bloco de código seja executado **pelo menos uma vez**, pois a condição só é verificada ao final.

```csharp
int soma = 0, numero = 0;

do
{
    Console.WriteLine("Digite um número: (0 para sair)");
    numero = Convert.ToInt32(Console.ReadLine());
    soma += numero;

} while (numero != 0);

Console.WriteLine($"A soma dos números digitados é: {soma}");

```

*Útil para entradas de dados onde o usuário decide quando parar.* 📥

---

## 📱 Exemplo Prático: Menu Interativo

Combinando `while`, `switch` e variáveis de controle para criar um sistema funcional:

```csharp
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
            exibirMenu = false; // Para o loop
            // Environment.Exit(0); -> Fecha o programa inteiro
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
}
Console.WriteLine("Programa finalizado.");

```
