// O namespace é o caminho único da classe, porém caso eu queira usar a mesma classe, eu preciso alterar apenas o nome do namespace e assim consigo continuar usando a classe.

using tivit_net_github_copilot.Models;

Pessoa p = new Pessoa();

p.Nome = "Nathan";
p.Idade = 23;
p.Apresentar();

// Pessoa pessoaFisica = new Pessoa();
// Exempelo de camelCase em variável
// Único caracter especial permitido em variável é o _ (underline)