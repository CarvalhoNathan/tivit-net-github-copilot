using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exceções_e_Coleções.Models
{
    public class Excecao
    {
        public void Metodo1()
        {
            try
            {
                Metodo2();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Execeção tratada!" + ex.StackTrace);
            }
        }

        public void Metodo2()
        {
            Metodo3();
        }

        public void Metodo3()
        {
            Metodo4();
        }

        public void Metodo4()
        {
            throw new Exception("Ocorreu uma exceção.");
        }
    }
}