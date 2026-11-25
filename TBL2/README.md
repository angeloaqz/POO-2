# TBL POO 2 – Exceções Personalizadas

---

## Parte 01 – Implementação das Questões Escolhidas

Foram implementadas **3 questões** dentre as 5 disponíveis no roteiro, utilizando classes que herdam de `System.Exception`:

* **`Questao1_IdadeInvalida.cs`**: Implementa `IdadeInvalidaException`, lançada ao tentar instanciar uma `Pessoa` com idade menor que 0 ou maior que 120.
* **`Questao4_DivisaoPorZero.cs`**: Implementa `DivisaoPorZeroException`, lançada pela classe `Calculadora` ao tentar dividir por zero.
* **`Questao5_EstoqueInsuficiente.cs`**: Implementa `EstoqueInsuficienteException`, lançada pela classe `Produto` ao tentar retirar uma quantidade maior do que a disponível em estoque.

---

## Parte 02 – Teste de Integração em Dupla (Simulação de Código do Colega)

* **`Parte02_TesteColega.cs`**: Simula a validação do código desenvolvido pelo colega de dupla (implementando a **Questão 3 - `UsuarioNaoAutenticadoException`**). O programa de teste força a chamada do método protegido `AcessarRelatorioFinanceiro()` sem que o usuário tenha feito login, validando o lançamento e a captura da exceção personalizada no bloco `try/catch`, e em seguida valida o fluxo normal após o login.
