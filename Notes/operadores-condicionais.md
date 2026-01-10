# 🚦 Estruturas Condicionais

As estruturas condicionais permitem que o programa execute diferentes blocos de código dependendo de uma condição ser verdadeira ou falsa.

## 🔀 Switch Case

O `switch` é ideal quando você tem uma única variável e quer compará-la com vários valores possíveis. No exemplo abaixo, agrupamos vários "cases" para uma única saída:

```csharp
Console.WriteLine("Digite uma letra: ");
string letra = Console.ReadLine().ToLower();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal 🍎");
        break;
    default:
        Console.WriteLine("Consoante 🥥");
        break;
}

```

> **Dica:** O método `.ToLower()` converte o que o usuário digitou para minúsculo, garantindo que o programa reconheça "A" ou "a" da mesma forma. 💡

---

## ⚖️ IF, ELSE IF e ELSE

O `if` é mais flexível e permite testar condições complexas usando operadores lógicos.

### Exemplo 1: Forma Simplificada (Operador `||`)

Usamos o operador `||` (OU) para verificar várias condições em uma única linha:

```csharp
if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
{
    Console.WriteLine("Vogal");
}
else
{
    Console.WriteLine("Consoante");
}

```

### Exemplo 2: Condicionais de Negócio (Estoque)

Neste exemplo, usamos o operador `&&` (E) para validar se uma venda pode ser feita:

```csharp
int quantidadeEmEstoque = 10;
int quantidadeCompra = 4;

// && (E): Ambas as condições precisam ser VERDADEIRAS
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

if (quantidadeCompra == 0)
{
    Console.WriteLine("Venda inválida. ⚠️");
}
else if (possivelVenda)
{
    Console.WriteLine("Venda realizada com sucesso! ✅");
}
else
{
    Console.WriteLine("Desculpe, não temos estoque suficiente. ❌");
}

```

---

## ⚠️ Diferença Importante: `=` vs `==`

Muitos iniciantes confundem esses dois operadores. Lembre-se sempre:

* **`=` (Atribuição):** Define o valor de uma variável. (`x = 10;`) ✍️
* **`==` (Comparação):** Verifica se dois valores são iguais. (`if (x == 10)`) ⚖️

---

### 📝 Resumo de Decisão:

* Use **Switch Case** para testar uma variável contra valores fixos e discretos. 🗄️
* Use **If / Else** para faixas de valores (ex: `idade > 18`) ou condições múltiplas. 🏔️
