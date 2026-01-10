using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tivit_net_github_copilot.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y) 
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void Subtrair(int x, int y) 
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void Multiplicar(int x, int y) 
        {
            Console.WriteLine($"{x} X {y} = {x * y}");
        }
        public void Dividir(int x, int y) 
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public void Potencia (int x, int y) 
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {pot}");
        }
        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}° = {Math.Round(seno, 4)}");
        }
        public void Conseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double conseno = Math.Cos(radiano);
            Console.WriteLine($"Conseno de {angulo}° = {Math.Round(conseno, 4)}");
        }
        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Conseno de {angulo}° = {Math.Round(tangente, 4)}");
        }

        public void RaizQuadrada(double x)
        {
            Math.Sqrt(x);
            Console.WriteLine($"A raiz quadrada de {x} é {Math.Sqrt(x)}");
        }
    }
}