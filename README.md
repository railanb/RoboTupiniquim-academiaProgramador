# # ROBÔ TUPINIQUIM 

Projeto desenvolvido durante curso da [ACADEMIA DO PROGRAMADOR](https://www.academiadoprogramador.net/inicio) 2026

![Foto do programa](/docs/apresentacao.gif)

## Introdução
Projeto desenvolvido usando a linguagem C#, uma aplicação de console com uma ideia muito bacana, criar uma Robô que navegue por um plano retângular. A ideia princial é receber uma sequência de coordenadas como posição inicial e a posição para qual o robô deverá se deslocar. Nesse projeto, foi aperfeiçoado o connehimento sobre o modelo estruturação com  classes, entidades, etc...

## Funcionalidades

- Posição e Orientação: A posição do robô é dada por coordenadas (X, Y) e uma letra que representa a
direção para onde ele está olhando (Norte, Sul, Leste, Oeste).
- Comandos: será enviado strings de comando simples (E, D, M):
- E (Esquerda) e D (Direita) fazem o robô virar 90 graus, sem sair do lugar.
- M (Mover) move o robô uma posição no grid para frente, mantendo a direção.

### Input:
```
Digite a posição inicial: 1 2 N
Digite a sequência de comandos: EMEMEMEMM
```
### Output Esperado:
```
Posição alcançada: 1 3 N
```

## Como utilizar o programa
1. Clone o repositório ou baixe os arquivos do repositório.
2. Abra seu emulador  de terminal de preferência e navegue até a pasta raiz do projeto baixado.
3. Utilize o comando abaixo para restaurar as dependências  do projeto.

```
dotnet restore
```
4. Em seguida compile e execute o projeto com o comando:
```
dotnet run --project AdivinhacaoJogo
```

## Requisitos
- [.NET 10.0 SDK](https://dotnet.microsoft.com/pt-br/download)
