# 📜 Listas (`List<T>`)

A `List` é uma das coleções mais poderosas do C#. Diferente do Array, ela **não tem tamanho fixo**: você pode adicionar ou remover itens a qualquer momento, e ela gerencia o redimensionamento da memória automaticamente para você.

## 🛠️ Criando e Adicionando Itens

Para usar listas, o C# utiliza o conceito de **Generics** (o `<T>`), onde você define entre os sinais de "maior e menor" qual tipo de dado a lista irá guardar.

```csharp
// Criando uma lista de Strings
List<string> listaStrings = new List<string>();

// Adicionando elementos de forma dinâmica
listaStrings.Add("SP");
listaStrings.Add("RJ");
listaStrings.Add("MG");

```

---

## 🏃 Percorrendo a Lista

Assim como no Array, podemos usar tanto o `FOR` quanto o `FOREACH`. A principal diferença é que para listas usamos a propriedade **`.Count`** em vez de `.Length`.

### 1️⃣ Usando o laço `FOR`

Ideal quando você precisa manipular o índice ou realizar cálculos baseados na posição.

```csharp
Console.WriteLine("Percorrendo com FOR:");

for(int contador = 0; contador < listaStrings.Count; contador++)
{
    Console.WriteLine($"Posição N° {contador} - {listaStrings[contador]}");
}

```

### 2️⃣ Usando o laço `FOREACH`

A maneira mais elegante e legível de percorrer os elementos. Se precisar do índice, podemos usar um contador externo.

```csharp
Console.WriteLine("\nPercorrendo com FOREACH:");

int contadorForeach = 0;
foreach(string item in listaStrings)
{
    Console.WriteLine($"Posição N° {contadorForeach} - {item}");
    contadorForeach++;
}

```

---

## 🆚 Array vs. List: Qual usar?

| Característica | Array `[]` | List `List<T>` |
| --- | --- | --- |
| **Tamanho** | Fixo (imutável após criado) | Dinâmico (cresce conforme o uso) 🚀 |
| **Performance** | Ligeiramente mais rápido | Possui um pequeno custo de processamento |
| **Facilidade** | Mais manual | Métodos prontos (`Add`, `Remove`, `Sort`) ✨ |
| **Propriedade de Tamanho** | `.Length` | `.Count` |

> **Dica de ouro:** No dia a dia profissional, **90% das vezes você usará `List`**, a menos que tenha uma necessidade de performance extrema ou um tamanho de dados que nunca mude. 💡
