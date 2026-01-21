using System.Diagnostics;
using Explorando.Models;

Console.Clear();

Pessoa p1 = new Pessoa(nome: "Nathan", sobrenome: "Carvalho");
Pessoa p2 = new Pessoa("Nicolas", "Carvalho");
// Pode fazer das duas maneiras, colocando o nome do parâmetro ou não

// Versões anteriores sem construtor:

// p1.Nome = "Nathan";
// p1.Sobrenome = "Carvalho";
// p.Idade = 23;
// p.Apresentar();

// Pessoa p2 = new Pessoa("Nicolas", "Carvalho");
// p2.Nome = "Nicolas";
// p2.Sobrenome = "Carvalho";

Curso cursoDeIngles = new Curso("Inglês");
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();