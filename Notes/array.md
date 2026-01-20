int[] arrayInteiros = new int[4];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
arrayInteiros[3] = 1;

// arrayInteiros[4] = 10; Essa linha vai gerar um erro de índice fora dos limites do array

int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2); Redimensiona o array para o dobro do tamanho

Console.WriteLine("--------------------------------");
Console.WriteLine("Percorrendo um array com FOR\n");

// Vantagem: Temos acesso ao índice do array

for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição N° {contador} - Valor: {arrayInteiros[contador]}");
}

Console.WriteLine("--------------------------------");
Console.WriteLine("Percorrendo um array com FOREACH\n");

// Desvantagem: Não temos acesso ao índice do array

foreach (int valor in arrayInteiros)
{
    Console.WriteLine($"Valor do array: {valor}");
}

Console.WriteLine("--------------------------------");

// Solução para ter o índice ao usar o FOREACH

int contadorForeach = 0;
foreach (int valor in arrayInteiros)
{
    Console.WriteLine($"Posição N° {contadorForeach} - Valor: {valor}");
    contadorForeach++;
}