# 📦 Arrays (Vetores)

Um **Array** é uma estrutura de dados que permite armazenar uma sequência de elementos do mesmo tipo com um tamanho fixo. Imagine-o como uma estante com um número determinado de gavetas numeradas.

## 🛠️ Criando e Manipulando um Array

No C#, os arrays começam sempre no **índice 0**.

```csharp
// Declaração de um array com 4 posições
int[] arrayInteiros = new int[4];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
arrayInteiros[3] = 1;

// ⚠️ ERRO COMUM:
// arrayInteiros[4] = 10; -> Isso gera uma "IndexOutOfRangeException" 
// pois tentamos acessar uma posição que não existe.

```

---

## 🔄 Redimensionando um Array

Arrays têm tamanho fixo. Para aumentar o seu tamanho, o C# precisa criar um novo array na memória e copiar os dados do antigo.

### Método 1: `Array.Resize` (Prático)

```csharp
// Dobrando o tamanho do array original
Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

```

### Método 2: `Array.Copy` (Manual/Seguro)

```csharp
// Criamos um novo array maior e copiamos os valores do antigo
int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

```

---

## 🏃 Percorrendo Arrays

### 1️⃣ Usando o laço `FOR`

**Vantagem:** Você tem controle total sobre o índice (a posição atual).

```csharp
for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição N° {contador} - Valor: {arrayInteiros[contador]}");
}

```

### 2️⃣ Usando o laço `FOREACH`

**Vantagem:** Código mais limpo e fácil de ler.
**Desvantagem:** Não fornece o índice nativamente (apenas o valor).

```csharp
foreach (int valor in arrayInteiros)
{
    Console.WriteLine($"Valor: {valor}");
}

```

> **Dica:** Se precisar do índice no `foreach`, você pode criar um contador externo, mas nesses casos o `for` costuma ser mais indicado. 💡

---

## 🆚 Qual escolher?

| Característica | FOR | FOREACH |
| --- | --- | --- |
| **Índice** | Acesso direto via `[i]` | Não possui 🚫 |
| **Leitura** | Mais verboso | Muito mais simples ✨ |
| **Segurança** | Risco de erro de índice | Mais seguro contra erros |
