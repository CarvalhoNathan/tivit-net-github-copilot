using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tivit_net_github_copilot.Models
{
    public class Pessoa
    {
        // Logo abaixo estão os atributos da classe Pessoa:
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string NomeRepresentanteLegalDaPessoaFisica { get; set; }

        // Método Apresentar:
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e eu tenho {Idade} anos.");
            // Console.WriteLine($"Olá, meu nome é {Nome}\n e eu tenho {Idade} anos.");
            // O \n serve para pular linha no console
        }

        // Nome de classe, método e atributo são sempre PascalCase
        // Nome de variável é sempre camelCase

        // Console = Classe
        // WriteLine = Método
        // () = O que está entre parênteses é o parametro
    }
}