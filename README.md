# barbearia
Sistema de Gestão de Barbearia


---------

## Entidades
- Cliente
- Barbeiro
- ProdutoServico
- Forma de pagamento
- Operação (Venda ou Prestação de serviço)
- ItensOperacao
---------

### Cliente : Pessoa
- Id, Nome, Sexo, DataNasc
- *IEnumerable<Operacao>* Operacoes

### Barbeiro : Pessoa
- Id, CPF, Nome, Login, Admissão
- *IEnumerable<Operacao>* Operacoes

### ProdutoServico
- Id, Nome, Tipo (P/S), CategoriaId, Preço
-- *Categoria* Categoria

### Categoria
- Id, Nome

### FormaPagamento
- Id, Nome, Sigla

### Operação
- Id, BarbeiroId, ClienteId, DataOperacao, ValorBase, Gorjeta, Vale, Desconto, ValorTotal
-- *Barbeiro* Barbeiro
-- *Cliente* Cliente
-- *IEnumerable<ItensOperacao>* Itens

### ItensOperacao
- Id, OperacaoId, ProdutoId, PrecoUnit, Quantidade, PrecoTotal
-- *Produto* Produto
-- *IEnumerable<Pagamento>* Pagamentos

### Pagamento
- Id, OperacaoId, FormaPagamentoId, DataPagamento, ValorPago
-- *Operacao* Operacao
-- *FormaPagamento* FormaPagamento 
