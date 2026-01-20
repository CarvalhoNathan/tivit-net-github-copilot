# 🚗 DIO - Trilha .NET - Fundamentos: Sistema de Estacionamento

Este repositório contém a resolução do desafio de projeto do módulo de Fundamentos da **DIO (Digital Innovation One)**. O objetivo é aplicar os conceitos de C# e .NET para gerenciar o fluxo de um estacionamento.

![Diagrama de classe estacionamento](diagrama_classe_estacionamento.png)

## 🎯 Objetivo do Projeto

Desenvolver um sistema robusto para gerenciamento de veículos, capaz de realizar operações de entrada, saída (com cálculo de taxas) e listagem de frota.

---

## 🏗️ Modelagem do Sistema

A estrutura principal baseia-se na classe `Estacionamento`, conforme o diagrama abaixo:

### 📊 Atributos (Estado)

* **`precoInicial`**: Valor fixo cobrado apenas por entrar no estacionamento. 💰
* **`precoPorHora`**: Valor variável cobrado por cada hora de permanência. ⏱️
* **`veiculos`**: Uma `List<string>` que armazena as placas dos veículos atualmente estacionados. 📋

### ⚙️ Métodos (Comportamento)

1. **`AdicionarVeiculo`**: Solicita a placa ao usuário e a armazena na lista. ➕
2. **`RemoverVeiculo`**:
* Verifica se a placa informada existe na lista.
* Solicita a quantidade de horas permanecidas.
* Realiza o cálculo: `$precoInicial + (precoPorHora * horas)$`.
* Remove o veículo da lista e exibe o valor final ao cliente. ➖


3. **`ListarVeiculos`**: Exibe todos os veículos estacionados. Se a lista estiver vazia, informa que não há veículos. 🔍

---

## 🖥️ Fluxo da Aplicação

O programa conta com um **Menu Interativo** via console que opera em loop até que o usuário decida encerrar:

1. **Cadastrar veículo** 📝
2. **Remover veículo** 💸
3. **Listar veículos** 🚗
4. **Encerrar** 🚪

---

## 🛠️ Instruções para Implementação

O projeto base possui uma estrutura pré-definida com comentários **"TODO"**. Para completar o desafio, siga estas etapas:

1. **Entrada de Dados:** Use `Console.ReadLine()` para capturar placas e tempos.
2. **Validação:** No método de remoção, utilize `.Any()` ou `.Contains()` para verificar a existência do veículo.
3. **Cálculo:** Certifique-se de realizar a operação matemática correta para não gerar cobranças indevidas.
4. **Exibição:** Use Interpolação de Strings (`$""`) para tornar as mensagens ao usuário mais amigáveis.

---

## 🚀 Como Executar

1. Clone este repositório.
2. Certifique-se de ter o **SDK do .NET 6** (ou superior) instalado.
3. Navegue até a pasta do projeto e execute:
```bash
dotnet run

```
