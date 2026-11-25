# POO2 - Roteiro 05 (Testes Unitarios com xUnit)

| Projeto | Conteudo |
|---|---|
| AppCalculadora | Calculadora e programa de console da aula |
| AppCalculadora.Tests | Testes da Calculadora (Somar, Subtrair, Multiplicar, Dividir e excecao) |
| AulaTestes | Classes dos exercicios: ValidadorSenha, Carrinho, ConversorTemperatura, CalculadoraIMC |
| AulaTestes.Tests | Testes dos exercicios 1 a 4 e exemplos de Assert da aula |

| Exercicio | Arquivo de teste |
|---|---|
| 1 - Validador de Senha | AulaTestes.Tests/ValidadorSenhaTests.cs |
| 2 - Carrinho de Compras | AulaTestes.Tests/CarrinhoTests.cs |
| 3 - Conversor de Temperatura | AulaTestes.Tests/ConversorTemperaturaTests.cs |
| 4 - Calculadora de IMC | AulaTestes.Tests/CalculadoraIMCTests.cs |

Para rodar os testes: `dotnet test AppCalculadora.Tests` e `dotnet test AulaTestes.Tests`.
Para executar a calculadora: `dotnet run --project AppCalculadora`.
