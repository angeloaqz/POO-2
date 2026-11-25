# Atividade – Ciclos de Vida do Software

---

## Questão 1 - Modelo Cascata (Sistema de Pedidos)

### 1. Definição
* **Problema:** A empresa precisa registrar vendas de forma organizada, evitando erros manuais na soma dos itens e no controle de quem comprou.
* **Objetivo:** Desenvolver um sistema simples em console que permita cadastrar o cliente, adicionar produtos ao pedido, calcular o valor total e registrar a forma de pagamento.

### 2. Análise
* **Funcionalidades principais:** Informar o nome do cliente, inserir produtos (nome e preço), somar os valores dos itens e definir a forma de pagamento.
* **Regras de negócio:** Um pedido deve estar vinculado a um cliente, pode conter um ou mais produtos e o valor total deve corresponder exatamente à soma dos preços dos itens adicionados.

### 3. Projeto
A solução foi estruturada de forma orientada a objetos em duas classes principais:
* `Produto`: armazena `Nome` e `Preco`.
* `Pedido`: armazena `Cliente`, uma lista `List<Produto>` e `FormaPagamento`, além dos métodos `AdicionarProduto()`, `CalcularTotal()` e `ExibirResumo()`.

### 4. Implementação
Código-fonte disponível no arquivo `Questao1_SistemaPedidos.cs`.

### 5. Testes
* **Teste 1:**
  * **Situação testada:** Criar um pedido para "Carlos Silva" adicionando "Teclado Mecânico" (R$ 250,00) e "Mouse Gamer" (R$ 120,00), com pagamento em "Cartão de Crédito".
  * **Resultado esperado:** Exibir os dois produtos, a forma de pagamento e o total de R$ 370,00.
  * **Resultado obtido:** O sistema exibiu todos os dados corretamente e calculou R$ 370,00.
* **Teste 2:**
  * **Situação testada:** Criar um pedido sem adicionar nenhum produto.
  * **Resultado esperado:** O método `CalcularTotal()` deve retornar R$ 0,00 sem gerar erro.
  * **Resultado obtido:** O sistema exibiu total R$ 0,00 corretamente.

### Alteração de Requisito (Modelo Cascata)
* **Quais etapas seriam afetadas e por quê?**
  Todas as etapas a partir da **Análise** seriam afetadas (Análise, Projeto, Implementação e Testes). Como o modelo Cascata é rígido e sequencial, uma nova funcionalidade exige voltar à documentação de requisitos na Análise, adaptar a estrutura das classes no Projeto, reescrever partes da Implementação e refazer os Testes para garantir que nada quebrou.

---

## Questão 2 - Modelo Incremental (Sistema de Carrinho de Compras)

O código-fonte final (com Incremento 1 e Incremento 2 integrados) está disponível no arquivo `Questao2_CarrinhoCompras.cs`.

### Respostas sobre os Incrementos
1. **O que já existia no primeiro incremento?**
   A classe `Produto` (com Id, Nome e Preço), a classe `Carrinho` contendo a lista de itens, o método de adicionar produtos (`AdicionarProduto`) e a exibição básica dos itens (`VisualizarCarrinho`).
2. **O que foi acrescentado no segundo?**
   O método `CalcularTotal()`, o método `RemoverProduto(int id)` e o atributo `FormaPagamento`.
3. **O que precisou ser alterado na primeira versão?**
   A classe `Carrinho` recebeu a nova propriedade `FormaPagamento`, e o método `VisualizarCarrinho()` foi atualizado para também exibir o valor total calculado e a forma de pagamento escolhida.

### Alteração de Requisito (Desconto de 10% acima de R$ 500)
* **Em qual incremento essa funcionalidade poderia ser incorporada e por quê?**
  Poderia ser incorporada no **Incremento 2** (ou em um novo **Incremento 3** logo após ele), pois é justamente no Incremento 2 que a lógica de cálculo de valores (`CalcularTotal()`) é implementada. No Incremento 1 ainda não existia cálculo financeiro no carrinho.

---

## Questão 3 - Grupo (Sistema de Reservas de Salas)

O código-fonte final (com Incremento 1 e Incremento 2 integrados) está disponível no arquivo `Questao3_ReservaSalas.cs`.

### Distribuição das Funcionalidades
* **Incremento 1:** Criação das entidades `Sala` e `Responsavel`, cadastro de ambos no `SistemaReservas` e consulta de salas disponíveis.
* **Incremento 2:** Criação da entidade `Reserva` (vinculando sala, responsável, data e horário), implementação do método `RealizarReserva()` (que também altera o status da sala para indisponível) e consulta de todas as reservas realizadas.

### Perguntas da Apresentação
* **Por que o desenvolvimento realizado caracteriza um modelo Incremental?**
  Porque o sistema não foi entregue todo de uma vez no final. Primeiro construímos um núcleo funcional básico (cadastrar e listar salas e responsáveis) que já podia ser executado e testado, e depois evoluímos esse mesmo código adicionando novas funcionalidades (as reservas com data e horário) sem precisar jogar fora o que já estava pronto.
