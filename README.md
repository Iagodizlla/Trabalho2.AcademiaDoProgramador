# Trabalho Robô Tupiniquim

![](https://i.imgur.com/1PgTZB2.gif)

## Introdução

- Um ambiente virtual feito para suportar e cálcular o trajeto de 2 robôs em marte.

---
## Tecnologias

[![Tecnologias](https://skillicons.dev/icons?i=git,github,cs,dotnet,visualstudio)](https://skillicons.dev)

---
## Funcionalidades

- **Tutorial**: O programa tem um pequeno tutorial que explica como funciona o ambiente virtual.
- **Posição Inicial**: A posição inicial do robô pode ser escolhida, junto com sua direção no eixo.
- **Movimentos Controlados**: Os movimentos de girar e andar são controlados pelo usuário.
- **Cálculo Exato**: O programa faz o cálculo exato dos movimentos do robô e pode definir sua posição final.
- **Erros do Usuário**: O programa exibe que ocorreu algum erro quando o usuário digita errado ou faz movimentos impossíveis para o robô.
- **Teste Duplo**: O programa suporta dois robôs de uma só vez no ambiente virtual.

---
## Como utilizar

1. Clone o repositório ou baixe o código fonte.
2. Abra o terminal ou o prompt de comando e navegue até a pasta raiz
3. Utilize o comando abaixo para restaurar as dependências do projeto.

```
dotnet restore
```

4. Em seguida, compile a solução utilizando o comando:
   
```
dotnet build --configuration Release
```

5. Para executar o projeto compilando em tempo real
   
```
dotnet run --project Calculadora.ConsoleApp
```

6. Para executar o arquivo compilado, navegue até a pasta `./Calculadora.ConsoleApp/bin/Release/net8.0/` e execute o arquivo:
   
```
Calculdora.ConsoleApp.exe
```

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.
