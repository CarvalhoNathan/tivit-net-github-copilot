# 🧠 Operadores Lógicos

Os operadores lógicos são usados para combinar ou inverter condições booleanas (`true` ou `false`). Eles são o cérebro por trás das tomadas de decisão no código.

---

## ⚖️ Operador OR (OU) -> `||`

O operador **OR** retorna verdadeiro se **pelo menos uma** das condições for verdadeira. Basta que um lado seja `true` para que o bloco seja executado.

```csharp
bool maiorDeIdade = true;
bool possuiAutorizacao = false;

// Se for maior de idade OU tiver autorização, entra.
if (maiorDeIdade || possuiAutorizacao)
{
    Console.WriteLine("Entrada permitida! ✅");
}
else
{
    Console.WriteLine("Entrada não permitida! ❌");
}

```

---

## 🔗 Operador AND (E) -> `&&`

O operador **AND** só retorna verdadeiro se **todas** as condições forem verdadeiras simultaneamente.

```csharp
bool possuiPresencaMinima = true;
double media = 7.5;

// Só é aprovado se tiver presença mínima E média maior ou igual a 7.
if (possuiPresencaMinima && media >= 7)
{
    Console.WriteLine("Aprovado! 🎉");
}
else
{
    Console.WriteLine("Reprovado! 📚");
}

```

---

## 🔄 Operador NOT (NÃO / Inversão) -> `!`

O operador **NOT** inverte o valor lógico. Se algo é `false`, `!algo` se torna `true`. Ele é usado para verificar se uma condição **não** foi atendida.

> **Regra de ouro:** O `!` transforma o falso em verdadeiro e o verdadeiro em falso. No exemplo abaixo, o `if` só executa se **não** estiver chovendo e **não** estiver tarde.

```csharp
bool choveu = false;
bool estaTarde = false;

// "Se NÃO choveu E NÃO está tarde"
if (!choveu && !estaTarde)
{
    Console.WriteLine("Vou pedalar! 🚲");
}
else
{
    Console.WriteLine("Vou pedalar outro dia! 🏠");
}

```

---

### 📝 Resumo Rápido

* `||` (OR): Pelo menos um é verdade. 🟢
* `&&` (AND): Todos devem ser verdade. ⛓️
* `!` (NOT): Inverte o estado atual. 🔄

---
