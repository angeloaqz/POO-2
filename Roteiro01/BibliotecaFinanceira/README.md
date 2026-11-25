# Exercicio 6 - BibliotecaFinanceira

Ao tentar chamar `calc.CalculoInterno(1000, 2, 12)` no projeto Console, o Visual Studio nao mostra o metodo no IntelliSense e a compilacao falha com o erro:

`CS0122: 'CalculadoraJuros.CalculoInterno(double, double, double)' is inaccessible due to its protection level`

## a) Por que o metodo internal nao aparece?

Porque `internal` limita o acesso ao proprio assembly (o projeto compilado). A BibliotecaFinanceira e um assembly (.dll) e o AppFinanceira e outro (.exe), entao o Console nao enxerga o metodo internal. So o metodo `public` (JurosSimples) fica visivel.

Para liberar o acesso a um projeto especifico, seria possivel usar `InternalsVisibleTo` na DLL, mas aqui o objetivo e justamente mostrar que o metodo fica escondido.
