# Projeto de Calculadora <img src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/csharp/csharp-original.svg" height=25/>

[![English Version](https://img.shields.io/badge/-English%20version-1f6feb?style=flat-square)](./README-en.md)

Este projeto é uma solução de calculadora no modo de aplicativo de console, construído em C#. O objetivo deste projeto é praticar os fundamentos do desenvolvimento de software com C#, sendo esta minha primeira abordagem nesta linguagem. A calculadora realiza 4 operações básicas (soma, subtração, multiplicação e divisão) através de um menu de opções.

<p align=center><img src="./docs/docs_usage.gif"/></p>


## Principais Conceitos

Este projeto serviu para aplicar alguns conceitos-chave da programação, implementados com a linguagem de programação C#. A seguir, segue a lista desses conceitos:

>   * Controle do fluxo de execução (princípios de programação)
>       * Estrutura Coalesce
>       * Atribuição múltipla
>       * Conversão de tipos
>       * Strategy Design Pattern
>       * Sistema de I/O para usuários
>   * Arquitetura OOP básica
>       * Retorno composto (Tupla nomeada)
>       * Função de alta ordem (delegate)
>   * Método de Expressão (função lambda/anônima)
>   * Docstrings


## Modo de Usar

Para testar esta aplicação, executar no Terminal (CMD):

```bash
git clone https://github.com/mbaliu-treino/101-csharp-fundamentals.git
cd ./101-csharp-fundamentals/Calculator
dotnet run
```


## Roadmap do Desenvolvimento

Processo de construção do aplicativo, visando torná-lo mais robusto, legível e fácil de manter.

>1. Criação do protótipo
>2. Modularização da solução: redução de redundâncias
>3. Docstrings
>4. Tratamento de erros
>    * Controle da entrada do usuário (loop infinito)
>    * Validação de regras de negócios (impossibilidade de divisão por 0)
>5. Redução de repetição de código (uso de função de alta ordem)


### Próximos Passos para Melhorias

>6. Controle de entrada segura
>7. Sistema de log