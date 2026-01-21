using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Explorando.Models
{
    public class Pessoa
    {
        // Construtores

        public Pessoa()
        {
            
        }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        // Public qualquer um pode acessar
        // Private só a própria classe pode acessar
        private string _nome;
        private int _idade;

        public string Nome 
        {
            // Validações no GET e SET:
            get
            {
                return _nome;
                // return _nome.ToUpper();
                // Vai retornar o _nome e em maiúsculo
            }

            // Outro jeito de usar o GET, usando o body expression:
            // get => _nome.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio.");
                }
                
                _nome = value;
                // Caso o valor não seja vazio, atribui o valor ao _nome
            } 
        }
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}";

        public int Idade 
        {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser negativa.");
                }

                _idade = value;
            }
        }
        
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {NomeCompleto} e tenho {Idade} anos.");
        }
    }
}