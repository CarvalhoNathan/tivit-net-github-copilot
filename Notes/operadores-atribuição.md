// Convertendo de maneira segura:

string a = "15-";
int b = 0;
int.TryParse(a, out b);

Console.WriteLine(b);
Console.WriteLine("Conversão realizada com sucesso!");

// ---------------------------------------------------------------------

// Ordem dos operadores:

// 1º - ( ) --> Parênteses
// 2º - * / % --> Multiplicação, Divisão e Resto da Divisão
// 3º - + - --> Adição e Subtração

// double a = 4 / 2 + 2;
// Console.WriteLine(a);

// ----------------------------------------------------------------------

// Cast implícito - conversão automática de tipos menores para tipos maiores

// int a = 5;
// double b = a;

// int a = 5;
// long b = a;

// int a = int.MaxValue;
// long b = a;

// Console.WriteLine(b);

// ----------------------------------------------------------------------

// Quando quiser converter um valor em string, posso usar o método ToString().

// int inteiro = 5;
// string a = inteiro.ToString();

// Console.WriteLine(a);

// ----------------------------------------------------------------------

// int a = Convert.ToInt32(null);
// int a = int.Parse("5");

// O Convert ainda aceita valores nulos, diferente do Parse que não aceita valores nulos.

// Console.WriteLine(a);

// ---------------------------------------------------------------------

// int a = 10;
// int b = 20;

// int c = a + b;

// c = c + 5;
// Se eu deixasse apenas 5, ele excluiria o valor antigo que daria 30 e ficando apenas 5.

// c += 5;
// Essa é a forma reduzida de fazer o que está na linha acima.
// c -= 5; // Subtrai 5 do valor atual de c
// c *= 5; // Multiplica o valor atual de c por 5
// c /= 5; // Divide o valor atual de c por 5

// Console.WriteLine(c);

// ----------------------------------------------------------------------

// DateTime:

// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));

// ----------------------------------------------------------------------

// string apresentacao = "Olá, seja bem vindo";

// int quantidade = 1;
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Aqui ele mantém o valor antigo da variável quantidade

// quantidade = 10;
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Aqui ele altera o valor da variável quantidade

// int quantidade = 1;
// quantidade = 10;
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Aqui ele altera o valor da variável quantidade, porém a variável quantidade foi declarada apenas uma vez.

// ----------------------------------------------------------------------

// double altura = 1.80;
// decimal preco = 1.80M;
// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variável preco: " + preco);
// Console.WriteLine("Valor da variável condicao: " + condicao);

// ----------------------------------------------------------------------

// Pessoa p = new Pessoa();

// p.Nome = "Nathan";
// p.Idade = 23;
// p.Apresentar();

// Pessoa pessoaFisica = new Pessoa();
// Exempelo de camelCase em variável
// Único caracter especial permitido em variável é o _ (underline)