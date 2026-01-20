List<string> listaStrings = new List<string>();

listaStrings.Add("SP");
listaStrings.Add("RJ");
listaStrings.Add("MG");

Console.WriteLine("Percorrendo a lista com o FOR:");

for(int contador = 0; contador < listaStrings.Count; contador++)
{
    Console.WriteLine($"Posição N° {contador} - {listaStrings[contador]}");
}

Console.WriteLine("\nPercorrendo a lista com o FOREACH:");

int contadorForeach = 0;
foreach(string item in listaStrings)
{
    Console.WriteLine($"Posição N° {contadorForeach} - {item}");
    contadorForeach++;
}