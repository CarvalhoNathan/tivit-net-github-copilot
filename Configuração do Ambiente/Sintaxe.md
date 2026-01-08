# ✍️ Sintaxe e Indentação

## 🏗️ O Conceito de Classe e Objeto

Para programar em C#, precisamos entender a **Orientação a Objetos**. Imagine a classe como uma planta de uma casa e o objeto como a casa construída.

### 📋 A Classe (O Molde)

A classe define as características e as ações que algo terá. No nosso exemplo, uma **Pessoa**:

* **Atributos (Características):** Nome, Idade, Altura. 🆔
* **Métodos (Ações):** Apresentar(), Andar(), Comer(). 🏃‍♂️

### 🏠 O Objeto (A Instância)

O objeto é quando damos vida à classe com dados reais.

* **Exemplo:** Um objeto onde o Nome é "Bob" e a Idade é 20.
* **Resultado:** *"Olá, meu nome é Bob e eu tenho 20 anos"* 🗣️

---

### 💻 Classe em Formato de Código

Veja como traduzimos o conceito acima para a sintaxe do C#:

```csharp
// Definindo a Classe
public class Pessoa 
{
    // Atributos (Propriedades)
    public string Nome { get; set; }
    public int Idade { get; set; }

    // Método (Ação)
    public void Apresentar() 
    {
        // O '$' permite usar variáveis dentro do texto (Interpolação)
        Console.WriteLine($"Olá! Meu nome é {Nome} e tenho {Idade} anos");
    }
}

```

---

# 📏 Convenções de Escrita (Cases)

Na programação, usamos diferentes padrões de escrita para organizar nosso código e facilitar a leitura entre a equipe:

| Padrão | Exemplo | Uso Comum |
| --- | --- | --- |
| **camelCase** | `nomeCompleto` | Variáveis locais e parâmetros. 🐪 |
| **PascalCase** | `NomeClasse` | Nomes de Classes, Métodos e Propriedades. 🏔️ |
| **snake_case** | `nome_da_variavel` | Comum em Bancos de Dados e Python. 🐍 |
| **spinal-case** (ou kebab-case) | `nome-do-arquivo` | URLs e nomes de arquivos. 🍢 |

> **Dica no C#:** O padrão oficial para Classes e Métodos é o **PascalCase**, e para variáveis internas usamos o **camelCase**. 💡
