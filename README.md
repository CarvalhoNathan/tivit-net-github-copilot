# TIVIT - .Net com GitHub Copilot (Bootcamp) 🚀

## 📑 Sumário

* [📝 Introdução](#-introdução)
* [⏳ História do .NET](#-história-do-net)
* [🔄 .NET Framework vs. .NET (Moderno)](#-net-framework-legado-vs-net-moderno)
* [📈 Evolução das Versões](#-evolução-das-versões)
* [🛠️ O que é um Compilador?](#o-que-é-um-compilador)
* [🔁 Compilador vs. Transpilador](#-compilador-vs-transpilador)
* [⚡ Nem toda linguagem é compilada!](#-nem-toda-linguagem-é-compilada)
* [🚀 O Compilador JIT (Just-In-Time)](#-o-compilador-jit-just-in-time)
* [🏗️ O CLR (Common Language Runtime)](#o-clr-common-language-runtime)

---

## 📝 Introdução

O **.NET** é uma plataforma de desenvolvimento unificada e gratuita para construir diversos tipos de aplicações. Uma analogia simples para entender a relação entre a plataforma e a linguagem:

* **ASP.NET:** É o framework (a caixa de ferramentas) que fornece os componentes para criar uma aplicação web. 🌐
* **C#:** É a linguagem de programação (a instrução) que define como esses componentes devem se comportar. ✍️
* **.NET:** É o ecossistema completo que une tudo isso. 🏗️

---

## ⏳ História do .NET

A Microsoft iniciou o desenvolvimento do C# no final dos anos 90, lançando a primeira versão do framework em **2002**. O objetivo principal era oferecer uma alternativa robusta ao Java. ☕

* **A Disputa com a Sun:** Inicialmente, a Microsoft tentou implementar melhorias no Java dentro de sua plataforma, mas foi impedida judicialmente pela Sun Microsystems. ⚖️
* **A Estratégia Windows:** Isso motivou a criação de um ecossistema próprio e integrado ao Windows, facilitando o desenvolvimento de apps Desktop e Web, o que consolidou a relevância da Microsoft. 🖥️
* **A Evolução:** Com o tempo, o foco mudou do exclusivo Windows para o **Open Source** e **Multiplataforma**, resultando no que conhecemos hoje. 🔓

---

## 🔄 .NET Framework (Legado) vs. .NET (Moderno)

### 🏢 .NET Framework (Legado)
* **Restrito:** Funciona exclusivamente no ecossistema Windows. 🪟
* **Foco:** Ideal para aplicações desktop antigas (WinForms, WPF) e Web legado. 🏛️

### 🚀 .NET (Antigo .NET Core)
* **Multiplataforma:** Roda em Windows, Linux e macOS. 🐧🍎
* **Flexibilidade:** Desenvolva em um sistema e execute em outro sem dores de cabeça. 💻
* **Redução de Custos:** Permite hospedar aplicações em servidores Linux, que são significativamente mais baratos que servidores Windows. 💰

---

## 📈 Evolução das Versões

A Microsoft unificou os nomes para acabar com a confusão entre as linhas de desenvolvimento.

| Versão | Notas | Status |
| --- | --- | --- |
| **.NET 8/9** | Versões mais recentes com foco em performance e IA. | Atual ✨ |
| **.NET 6** | Versão LTS (Long Term Support) muito estável. | Utilizada 🛠️ |
| **.NET 5** | O marco da unificação (o termo "Core" foi removido). | Histórica 🚩 |
| **.NET Core 3.1** | A última grande versão antes da unificação. | Legado 📜 |

> **Curiosidade:** A Microsoft pulou a versão 4 do .NET Core para evitar confusão com o antigo **.NET Framework 4.8**, saltando direto para o **.NET 5**. 💡

---

## O que é um Compilador?

Para entender o papel do compilador, precisamos diferenciar os níveis de linguagem:

* **Linguagem de Alto Nível:** É a que nós escrevemos. Exemplo em **C#**: `Console.WriteLine("Hello World");`. ✨
* **Linguagem de Baixo Nível:** É a que a máquina entende. Possui pouca abstração e é difícil de ler. Exemplo em **Assembly**:
  ```assembly
  push message
  call _printf
  ```

**Compilador:** É o programa que realiza a tradução da linguagem de alto nível para baixo nível (código de máquina ou bytecode). 🔄

---

## 🔁 Compilador vs. Transpilador

### 🏗️ Compilador

Transforma código de alto nível em baixo nível.

* **Exemplos:** C#, Java, C++.

### 🔄 Transpilador

Realiza a conversão de uma linguagem de alto nível para **outra linguagem de alto nível**.

* **Exemplo:** **TypeScript para JavaScript**. A saída continua sendo um código que humanos conseguem ler, mas em um formato que o navegador entende.

---

## ⚡ Nem toda linguagem é compilada!

### 📦 Linguagem Compilada

O código fonte é traduzido para código de máquina antes da execução.

* **Exemplo:** C, Rust e C#. 🚀

### 📖 Linguagem Interpretada

O código é lido e executado linha por linha por um "intérprete" em tempo real.

* **Exemplo:** JavaScript e PHP. 🐍

---

## 🚀 O Compilador JIT (Just-In-Time)

No .NET, a compilação acontece em duas etapas:

1. **C# para IL:** O código é transformado em uma Linguagem Intermediária (CIL), que é universal para o .NET. 📑
2. **JIT em ação:** Quando você executa o programa, o compilador **JIT** traduz esse IL para a linguagem específica do seu processador naquele exato momento. ⏱️

Isso permite que o .NET seja rápido e funcione em qualquer sistema operacional!

---

## O CLR (Common Language Runtime)

O **CLR** é o ambiente de execução que gerencia as aplicações .NET. Ele funciona como um "gerente de obra":

* **Garbage Collector:** Gerencia a memória automaticamente. 🧹
* **Segurança:** Garante que o código seja seguro para o sistema. 🛡️
* **Tratamento de Erros:** Fornece o suporte para lidar com exceções. ⚠️

> **Analogia:** Se o código é a música, o CLR é a casa de shows que fornece toda a estrutura necessária para o show acontecer. 🏟️
