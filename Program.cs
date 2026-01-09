// O namespace é o caminho único da classe, porém caso eu queira usar a mesma classe, eu preciso alterar apenas o nome do namespace e assim consigo continuar usando a classe.

using tivit_net_github_copilot.Models;

DateTime dataAtual = DateTime.Now.AddDays(5);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));

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

// double altura = 1.80;
// decimal preco = 1.80M;
// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variável preco: " + preco);
// Console.WriteLine("Valor da variável condicao: " + condicao);

// Pessoa p = new Pessoa();

// p.Nome = "Nathan";
// p.Idade = 23;
// p.Apresentar();

// Pessoa pessoaFisica = new Pessoa();
// Exempelo de camelCase em variável
// Único caracter especial permitido em variável é o _ (underline)