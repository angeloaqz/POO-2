# Exercicio 7 - BibliotecaValidacoes

Classes: ValidadorCPF, ValidadorEmail e ValidadorSenha, consumidas pelo projeto AppValidacoes.

## Passo a passo feito

1. A DLL foi criada e consumida no console com `senha.Validar(texto)`.
2. A assinatura foi alterada para `Validar(string senha, int tamanhoMinimo)`.
3. A DLL foi recompilada, mas o console nao foi atualizado.
4. O console deixou de compilar com o erro:
   `CS7036: There is no argument given that corresponds to the required parameter 'tamanhoMinimo' of 'ValidadorSenha.Validar(string, int)'`
5. O console foi corrigido para `senha.Validar(texto, 8)`.

## O que quebrou?

A chamada `senha.Validar(texto)` no console, porque ela usava a assinatura antiga do metodo.

## Breaking change

Breaking change (mudanca incompativel) e uma alteracao feita em uma biblioteca que faz com que os programas que ja a utilizavam parem de funcionar ou precisem ser alterados. Exemplos: mudar parametros de um metodo, renomear ou remover metodos e classes, mudar o tipo de retorno, trocar `public` por `internal`.

Para evitar, pode-se criar uma sobrecarga mantendo o metodo antigo, marcar o antigo com `[Obsolete]` ou lancar uma nova versao maior da biblioteca avisando da mudanca.
