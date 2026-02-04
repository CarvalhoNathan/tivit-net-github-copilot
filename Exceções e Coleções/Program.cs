using Exceções_e_Coleções.Models;

// Exceptions:

// Os recursos de manipulação de exceção da linguagem C# ajudam você a lidar com quaisquer situações excepcionais ou inesperadas que possam ocorrer durante a execução do programa.

// ------------------------------------------------------------

// Aqui ele vai tentar executar o código dentro do bloco try, e se alguma exceção ocorrer, ele vai capturar essa exceção e executar o bloco catch correspondente.

try
{
    string[] linhas = File.ReadAllLines("Misc/arquivoLeitura.txt");

    // Do jeito que está, ele funciona normalmente, porém se o arquivo não existir ou se digitar o endereço errado, ele lançará uma exceção do tipo FileNotFoundException.
    
    foreach(string linha in linhas)
    {
        Console.WriteLine(linha);
    }
} catch (FileNotFoundException ex)
// Aqui ele está capturando especificamente a exceção FileNotFoundException.
{
    Console.WriteLine("Arquivo não encontrado: " + ex.Message);
} catch (DirectoryNotFoundException ex)
// Aqui ele está capturando especificamente a exceção DirectoryNotFoundException.
{
    Console.WriteLine("Diretório não encontrado: " + ex.Message);
} catch(Exception ex)
// Aqui ele está capturando qualquer outra exceção genérica que não tenha sido capturada pelos blocos catch anteriores.
{
    Console.WriteLine("Ocorreu uma exceção genérica: " + ex.Message);
}
finally{
    Console.WriteLine("Chegou até aqui");
}

// Porém a exceção genérica "Exception" deve ser sempre a última a ser capturada, pois se ela estiver antes das outras, as outras nunca serão alcançadas, já que Exception captura todas as exceções.

// O bloco finally é opcional, mas ele é executado sempre, independentemente de uma exceção ter sido lançada ou não. Ele é útil para liberar recursos ou realizar ações de limpeza, como fechar arquivos ou conexões de banco de dados.

// ------------------------------------------------------------

new Excecao().Metodo1();
