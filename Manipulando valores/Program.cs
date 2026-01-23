using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Globalization;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Serialization.DataContracts;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

// Concatenação de strings:

// string numero1 = "10";
// string numero2 = "20";

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);
// Saída: Apenas juntou o 10 com o 20, saindo 1020

// ------------------------------------------------------------

// Concatenação de inteiros:

// string numero1 = 10;
// string numero2 = 20;

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);
// Saída: Somou os valores 10 e 20, saindo 30, como são inteiros ele realizou a soma matemática.

// Porém caso tenhamos uma mistura de tipos, o C# prioriza a concatenação de strings, como exemplo se tiver uma string e um inteiro, ele irá concatenar os valores ao invés de somar.

// ------------------------------------------------------------

// Formatando valores monetários:

// decimal valorMonetario = 1582.40M;

// Console.WriteLine($"{valorMonetario:C}");
// Ele vai formatar o valor monetário conforme a cultura da máquina onde o código está sendo executado.

// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
// Força a formatação do valor monetário para o padrão brasileiro, independente da cultura da máquina onde o código está sendo executado.

// ------------------------------------------------------------

// Representando porcentagens:

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P2"));
// Saída: 34.21 %

// Representando o tipo datetime:

// int numero = 123456;

// Console.WriteLine(numero.ToString("##-##-##"));

string dataString = "2026-01-23 18:00";

bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

if (sucesso)
{
    Console.WriteLine($"Conversão com sucesso: {data}");
}
else
{
    Console.WriteLine($"{dataString} (não é uma data válida)");
}

// DateTime data = DateTime.Parse(dataString);

// Console.WriteLine(data);
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

