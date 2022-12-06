# barbearia
Sistema de Gestão de Barbearia


---------

## Entidades
- Cliente
- Barbeiro
- Serviço
- Produto
- Forma de pagamento
- Operação (Venda ou Prestação de serviço)

---------

### Cliente : Pessoa
- Id, Nome, Sexo, DataNasc

### Barbeiro : Pessoa
- Id, CPF, Nome, Login, Admissão

### ProdutoServico
- Id, Nome, Tipo (P/S), CategoriaId, Preço

### Categoria
- Id, Nome

### FormaPagamento
- Id, Nome, Sigla

### Operação
- Id, BarbeiroId, ClienteId, DataOperacao, ValorBase, Gorjeta, Vale, Desconto, ValorTotal

### ItensOperação
- Id, OperacaoId, ProdutoId, PreçoUnit, Quantidade, PreçoTotal

### Pagamento
- Id, OperacaoId, FormaPagamentoId, DataPagamento, ValorPago
