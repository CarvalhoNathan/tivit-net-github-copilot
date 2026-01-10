# 🧮 Operadores Aritméticos e Classe Math

Os operadores aritméticos são a base para qualquer cálculo dentro de um sistema. No .NET, também utilizamos bibliotecas prontas para operações complexas.

## ➕ Operações Básicas

| Operador | Operação | Exemplo |
| --- | --- | --- |
| `+` | Adição | `x + y` |
| `-` | Subtração | `x - y` |
| `*` | Multiplicação | `x * y` |
| `/` | Divisão | `x / y` |
| `%` | Resto da Divisão (Módulo) | `x % y` |

```csharp
Calculadora calc = new Calculadora();

calc.Somar(10, 30);      // 40
calc.Subtrair(10, 50);   // -40
calc.Multiplicar(15, 45); // 675
calc.Dividir(2, 2);      // 1

```

---

## 📈 Incremento e Decremento

Usados frequentemente em laços de repetição para aumentar ou diminuir o valor de uma variável em 1 unidade.

* **Incremento (`++`):** `numero++` é o mesmo que `numero = numero + 1`
* **Decremento (`--`):** `numero--` é o mesmo que `numero = numero - 1`

```csharp
int numero = 10;
numero++; // Agora vale 11 ✨

int outroNumero = 20;
outroNumero--; // Agora vale 19 📉

```

---

## 📐 Operações Avançadas (Potência e Trigonometria)

Para cálculos científicos, o C# utiliza métodos internos. Abaixo, exemplos de como seriam implementados em uma classe `Calculadora`:

### 🔋 Potência e Raiz

* **Potência:** `Math.Pow(base, expoente)`
* **Raiz Quadrada:** `Math.Sqrt(numero)`

```csharp
calc.Potencia(3, 3);      // 3³ = 27
calc.RaizQuadrada(16);    // √16 = 4

```

### 📐 Trigonometria

Utilizada para cálculos de ângulos. **Atenção:** Os métodos de `Math` geralmente trabalham com Radianos, sendo necessário converter graus se necessário.

```csharp
calc.Seno(30);
calc.Cosseno(30);
calc.Tangente(30);

```

---

### ✅ Resumo Visual:

* **Simples:** `+`, `-`, `*`, `/` ✏️
* **Resto:** `%` (Saber se um número é par ou ímpar) ⚖️
* **Evolução:** `++` e `--` 🔄
