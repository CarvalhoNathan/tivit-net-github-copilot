# 🏗️ Manipulação de Dados e Tipos

No C#, entender como os dados se transformam e como as operações são priorizadas é fundamental para evitar erros de lógica.

## 🔄 Conversão de Tipos (Casting)

### 🛡️ Conversão Segura com `TryParse`

Quando não temos certeza se uma `string` pode virar um número (como "15-"), usamos o `TryParse`. Ele tenta converter e, se falhar, não trava o programa, apenas retorna `0` ou `false`.

```csharp
string a = "15-";
int b = 0;

// Tenta converter 'a' e joga o resultado em 'b'
int.TryParse(a, out b); 

Console.WriteLine(b); // Resultado: 0 (conversão falhou, b mantém o valor inicial)

```

### 🆚 `Convert` vs `Parse`

* **`int.Parse("5")`**: Converte string para inteiro. **Cuidado:** Se o valor for nulo, o programa quebra (Erro). ❌
* **`Convert.ToInt32(null)`**: Mais robusto. Se o valor for nulo, ele retorna **0** em vez de quebrar o programa. ✅

### 🧬 Cast Implícito e `ToString()`

* **Implícito:** O C# converte tipos "menores" para "maiores" automaticamente (ex: `int` para `long` ou `double`), pois não há risco de perda de dados.
* **ToString:** Transforma qualquer tipo em texto.
```csharp
int inteiro = 5;
string texto = inteiro.ToString(); 

```



---

## 🧮 Ordem de Precedência

O C# segue a regra matemática para calcular expressões:

1. **`( )`** : Parênteses primeiro.
2. **`* / %`** : Multiplicação, Divisão e Resto.
3. **`+ -`** : Adição e Subtração.

---

## 📉 Operadores de Atribuição Combinada

Forma reduzida de atualizar o valor de uma variável usando o valor atual dela:

```csharp
int c = 30;
c += 5; // Mesma coisa que: c = c + 5 (Resultado: 35)
c -= 5; // Subtrai do valor atual
c *= 2; // Multiplica o valor atual

```

---

## 📅 Trabalhando com Datas (`DateTime`)

O tipo `DateTime` é usado para manipular horários e calendários.

```csharp
// Pega a data de agora e adiciona 5 dias
DateTime dataAtual = DateTime.Now.AddDays(5);

// Formata a exibição: dd (dia), MM (mês), yyyy (ano)
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy")); 

```

---

## 📝 Variáveis e Tipos Básicos

* **`string`**: Textos.
* **`int`**: Números inteiros.
* **`double` / `decimal`**: Números com vírgula. (Dica: Use `decimal` com o sufixo `M` para dinheiro 💰).
* **`bool`**: Verdadeiro ou Falso.

> **⚠️ Regra de Variável:** O único caractere especial permitido no nome de uma variável é o `_` (underline). Sempre use **camelCase** para nomeá-las!

---

## 👥 Instanciando uma Classe

Para usar as definições que criamos em uma classe, precisamos "instanciar" o objeto:

```csharp
Pessoa p = new Pessoa(); // Criando o objeto
p.Nome = "Nathan";
p.Idade = 23;
p.Apresentar();

```
