# 🚗 Sistema de Estacionamento em C#

Projeto desenvolvido como exercício prático para treinar **lógica de programação, orientação a objetos e manipulação de listas em C#**.

A proposta consiste em criar um pequeno sistema de console capaz de **gerenciar veículos estacionados**, permitindo cadastrar, remover e listar veículos através de um menu interativo.

---

# 🎯 Objetivo do Desafio

Construir uma classe chamada **`Estacionamento`** responsável por controlar os veículos que entram e saem de um estacionamento, aplicando regras de cobrança e organização dos dados.

O sistema simula um estacionamento simples onde cada veículo é identificado pela **placa**.

---

# 🧠 Conceitos praticados

Durante o desenvolvimento deste projeto foram aplicados conceitos importantes de C#:

* Programação Orientada a Objetos (POO)
* Classes e métodos
* Listas (`List<T>`)
* Entrada de dados com `Console.ReadLine()`
* Estruturas de decisão
* Estruturas de repetição
* Organização de lógica de negócio

---

# 🏗️ Estrutura da Classe `Estacionamento`

A classe possui **três variáveis principais**:

### 🔹 `precoInicial`

Tipo: `decimal`

Representa o valor inicial cobrado ao estacionar um veículo.

---

### 🔹 `precoPorHora`

Tipo: `decimal`

Valor cobrado por cada hora adicional que o veículo permanece estacionado.

---

### 🔹 `veiculos`

Tipo: `List<string>`

Lista que armazena as **placas dos veículos estacionados**.

Exemplo:

```
["ABC-1234", "DEF-5678", "GHI-9012"]
```

---

# ⚙️ Métodos Implementados

## ➕ AdicionarVeiculo()

Responsável por:

1. Solicitar ao usuário a **placa do veículo**
2. Armazenar a placa na lista `veiculos`

Fluxo:

```
Usuário digita a placa
        ↓
Sistema recebe com ReadLine()
        ↓
Placa é adicionada na lista de veículos
```

---

## ➖ RemoverVeiculo()

Responsável por:

1. Solicitar a placa do veículo
2. Verificar se o veículo está estacionado
3. Caso esteja, solicitar **quantidade de horas estacionado**
4. Calcular o valor a ser pago

### 💰 Cálculo do valor

```
valorTotal = precoInicial + (precoPorHora * horas)
```

Depois disso:

* O valor é exibido ao usuário
* O veículo é removido da lista

---

## 📋 ListarVeiculos()

Exibe todos os veículos atualmente estacionados.

### Caso existam veículos:

```
Veículos estacionados:
ABC-1234
DEF-5678
GHI-9012
```

### Caso não existam:

```
Não há veículos estacionados
```

---

# 🖥️ Menu Interativo

O sistema possui um menu de navegação no terminal com as seguintes opções:

```
1 - Cadastrar veículo
2 - Remover veículo
3 - Listar veículos
4 - Encerrar
```

Fluxo do programa:

```
Usuário escolhe uma opção
        ↓
Sistema executa a ação correspondente
        ↓
Menu é exibido novamente
```

Até que o usuário escolha **Encerrar**.

---

# 📦 Estrutura do Projeto

```
sistema-estacionamento
│
├── Models
│   └── Estacionamento.cs
│
├── Program.cs
│
└── README.md
```

# 👩‍💻 Autora

Projeto desenvolvido por **Sabrina Paschini** como parte dos estudos em **Análise e Desenvolvimento de Sistemas** e aprofundamento em **C# e desenvolvimento backend**.

---

⭐ Projeto focado em aprendizado e evolução na área de desenvolvimento de software.
