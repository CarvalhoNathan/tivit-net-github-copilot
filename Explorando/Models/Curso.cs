using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Explorando.Models
{
    public class Curso
    {
        public Curso()
        {
            
        }

        public Curso(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            // O método ListarAlunos está acessando a propriedade Nome da própria classe Curso para exibir o nome do curso.
            
            Console.WriteLine($"Alunos do curso de: {Nome}");

            for (int count = 0; count < Alunos.Count; count++)
            {
                // Concatenção Strings:
                
                // string texto = "N° " + count + " - " + Alunos[count].NomeCompleto;

                // Uma das maneiras de concatenar strings é utilizando o sinal de +
                
                // --------------------------------------------
                
                // Interpolação Strings:

                string texto = $"N° {count + 1} - {Alunos[count].NomeCompleto}";

                // A interpolação de strings é feita utilizando o $ antes das aspas duplas, e também apenas uma vez as aspas duplas no início e no fim da string, contrário da concatenação que utiliza várias aspas duplas e várias vezes o sinal de +.

                Console.WriteLine(texto);
            };
        }
    }
}