# TBL 4 – Logging com NLog

Projeto em C# implementado com a biblioteca **NLog** integrando todos os 7 exercícios propostos no roteiro:

* **Exercícios 1 e 7 (`NLog.config`):** Configurado para gravar logs simultaneamente em arquivo (`log.txt`) e no console, utilizando layout estruturado com data (`${longdate}`), nível (`${level}`), mensagem (`${message}`) e exceção (`${exception}`).
* **Exercício 2:** Registro de log `Info` no início e no encerramento da aplicação.
* **Exercício 3:** Conversão de `string` para `int` com tratamento `try/catch` e registro `Error` contendo a exceção quando a conversão falha.
* **Exercícios 4, 5 e 6:** Classe de domínio `Conta` desacoplada do logger (seguindo as boas práticas do material), com fluxo completo de **depósito**, **saque** e **transferência** registrando início, sucesso (`Info`), tentativas inválidas (`Warn`) e erros de regra/exceções (`Error`).
