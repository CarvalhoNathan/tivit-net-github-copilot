// Operadores Lógicos
// Operador OR na prática:

// bool MaiorDeIdade = true;
// bool possuiAutorizacaoDoResponsavel = false;

// if (MaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada permitida!");
// }
// else
// {
//     Console.WriteLine("Entrada não permitida!");
// }

// ----------------------------------------------------------------------

// Operador AND na prática:

// bool possuiPresencaMinima = true;
// double media = 7.5;

// if (possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado!");
// }
// else
// {
//     Console.WriteLine("Reprovado!");
// }

// ----------------------------------------------------------------------

// Operador NOT na prática:
// Quando está com sinal de exclamação antes da variável, ele inverte o valor lógico dela. Então ele sempre vai esperar false para entrar no if.
// Exemplo: choveu = false, então realmente não choveu, o que faz com que a condição do if seja verdadeira (vou pedalar). Caso estivesse chovendo (choveu = true), a condição do if seria falsa, e iria para o else (vou pedalar outro dia).

bool choveu = false;
bool estaTarde = false;

if (!choveu && !estaTarde)
{
    Console.WriteLine("Vou pedalar!");
}
else
{
    Console.WriteLine("Vou pedelar outro dia!");
}