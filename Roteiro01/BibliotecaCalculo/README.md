# BibliotecaCalculo

DLL simples para calculos de area de figuras geometricas.

## Como usar

1. Compile o projeto BibliotecaCalculo (Ctrl + Shift + B).
2. A DLL fica em `BibliotecaCalculo/bin/Debug/net8.0/BibliotecaCalculo.dll`.
3. No seu projeto: botao direito em Dependencias > Adicionar Referencia > Procurar e selecione a DLL.
4. Use a classe:

```csharp
using BibliotecaCalculo;

var calc = new CalculadoraGeometria();
Console.WriteLine(calc.AreaRetangulo(4, 5));
Console.WriteLine(calc.AreaCirculo(3));
Console.WriteLine(calc.AreaTriangulo(6, 2));
```

## Metodos

| Metodo | Parametros | Retorno |
|---|---|---|
| AreaRetangulo | base, altura | area do retangulo |
| AreaCirculo | raio | area do circulo |
| AreaTriangulo | base, altura | area do triangulo |
