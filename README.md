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

### Barbeiro : Pessoa
- Id, CPF, Nome, Login, Admissão

### ProdutoServico
- Id, Nome, Tipo (P/S), CategoriaId, Preço
-- **Categoria** Categoria
```
  [ForeignKey(nameof(CategoriaId))]
  public virtual **Categoria** Categoria { get; set; }
```
  
### Categoria
- Id, Nome

### FormaPagamento
- Id, Nome, Sigla

### Operação
- Id, BarbeiroId, ClienteId, DataOperacao, ValorBase, Gorjeta, Vale, Desconto, ValorTotal
-- **Barbeiro** Barbeiro
-- **Cliente** Cliente
-- **IEnumerable<ItensOperacao>** Itens
-- **IEnumerable<Pagamento>** Pagamentos
  
```
  [ForeignKey(nameof(BarbeiroId))]
  public virtual **Barbeiro** Barbeiro { get; set; }

  [ForeignKey(nameof(ClienteId))]
  public virtual **Cliente** Cliente { get; set; }

  [InverseProperty(Itens)]
  public virtual **IEnumerable<ItensOperacao>** Itens { get; set; }

  [InverseProperty(Itens)]
  public virtual **IEnumerable<Pagamento>** Pagamentos { get; set; }
```

  
### ItensOperacao
- Id, OperacaoId, ProdutoId, PrecoUnit, Quantidade, PrecoTotal
-- **Produto** Produto
-- **Operacao** Operacao

```
  [ForeignKey(nameof(ProdutoId))]
  public virtual **Produto** Produto { get; set; }
  
  [ForeignKey(nameof(OperacaoId))]
  public virtual **Operacao** Operacao { get; set; }
```
  
### Pagamento
- Id, OperacaoId, FormaPagamentoId, DataPagamento, ValorPago
-- **Operacao** Operacao
-- **FormaPagamento** FormaPagamento 

```
  [ForeignKey(nameof(OperacaoId))]
  public virtual **Operacao** Operacao { get; set; }

  [ForeignKey(nameof(FormaPagamentoId))]
  public virtual **FormaPagamento** FormaPagamento { get; set; }
```
