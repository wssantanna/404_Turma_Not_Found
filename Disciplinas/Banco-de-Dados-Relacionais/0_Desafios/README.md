# PROBLEMA 1 — FASE DE PLANEJAMENTO (SEM DADOS)
## Validação e Correção da Modelagem Inicial – EcoMarket

Você está participando da fase de planejamento do sistema EcoMarket, um marketplace de produtos sustentáveis.
A modelagem inicial criada pela equipe júnior é:


Tabelas propostas:

## Tabela: clientes
- **id** — chave primária  
- **nome** — nome do cliente  
- **email** — precisa ser único  



## Tabela: enderecos
- **id** — chave primária  
- **cliente_id** — FK para clientes  
- **rua**  
- **cidade**

## Tabela: pedidos
- **id**
- **cliente_id** — referência ao cliente que realizou o pedido  
- **endereco_id** — referência ao endereço de entrega

## Tabela: produtos

- **id**
- **nome**
- **preco**

## Tabela: pedido_produtos 

- **id**
- **pedido_id** — referência ao pedido  
- **produto_id** — referência ao produto

## :/ Possíveis problemas identificados

Pedido_produtos possui um campo id, mesmo sendo uma tabela de relacionamento muitos-para-muitos.

A tabela pedidos permite associar um endereço que não pertence ao cliente.

A estrutura atual de endereços pode limitar o cliente a ter apenas um endereço.

Algumas constraints importantes parecem estar ausentes.

## \o/ Tarefas

1. Identifique e descreva todos os problemas de modelagem.  
2. Corrija a modelagem completa, incluindo **tipos**, **constraints** e **relacionamentos**.  
3. Explique quais relacionamentos devem ser **1:1**, **1:N** e **M:N**.  
4. Justifique todas as correções propostas.

# PROBLEMA 2 — IMPLEMENTAÇÃO COM DADOS (ERRO DE RELACIONAMENTO)
## Correção da Modelagem em Uso – EduSync

O sistema escolar EduSync já funciona há meses. As tabelas abaixo estão em uso e já possuem dados:

## Tabelas atuais:

## disciplinas

- **id**

- **nome** 

## professores

- **id**

- **nome**

- **disciplina_id**

## :/ Problema identificado:

A modelagem atual cria a relação:
> “um professor → uma disciplina”
Porém, na prática, um professor pode ministrar várias disciplinas.
Para contornar essa limitação, o time começou a cadastrar professores duplicados, cada um vinculado a uma única disciplina.


- O banco agora possui **122 professores duplicados** representando apenas **34 professores reais**. 

## Tarefas:

1. Explique por que o relacionamento atual é incorreto.

2. Proponha um plano completo para corrigir o relacionamento, sem perder dados existentes.

3. Reestruture a modelagem para suportar que um professor ministre várias disciplinas.

4. Detalhe como você trataria os registros duplicados durante a migração.

# PROBLEMA 3 — PROBLEMA REPORTADO POR USUÁRIO (BUG FUNCIONAL)
## Carrinho de Compras com Itens Duplicados – FastFood+

O sistema FastFood+ permite que usuários adicionem produtos a um carrinho de compras.
Um usuário relatou o seguinte problema:

> “Quando adiciono o mesmo item duas vezes, o sistema cria duas linhas no carrinho, em vez de somar a quantidade.”

## Tabela atual:

- **Carrinho_itens**

- id

- usuario_id

- produto_id

- quantidade


# \o/ Tarefas

1. Identifique e explique a falha na modelagem.

2. Proponha pelo menos duas soluções possíveis:

- **via banco de dados**,

- **via aplicação**.

3. Defina como a tabela deveria ser estruturada para evitar duplicações.

4. Descreva como seria o processo de correção dos dados já existentes.

# PROBLEMA 4 — MUDANÇA DE REGRA DE NEGÓCIO + MIGRAÇÃO DE DADOS

## Modelo de Assinaturas Revisado – StreamBox

O sistema StreamBox armazena as assinaturas dos usuários na seguinte estrutura:

Tabela atual:

- **assinaturas** 

- id

- usuario_id

- plano

- data_assinatura

- ativo (boolean)

## Nova regra de negócio:

1. Um usuário pode ter vários registros históricos de planos.

2. Apenas um plano por vez pode estar ativo.

3. O campo plano deve deixar de ser texto e passar a ser uma chave estrangeira para uma nova tabela planos:

- id

- nome

- valor

## Problemas identificados nos dados atuais:

- Há usuários com mais de um plano ativo simultaneamente.

- O campo plano é textual e não garante integridade.

- A mudança pode impactar dados e funcionalidades atuais.

# \o/ Tarefas

1. Redesenhe a modelagem considerando a nova tabela planos.

2. Proponha um plano de migração completo:

- criação da nova tabela,

- popular planos existentes,

- migrar dados,

- resolver conflitos de múltiplos planos ativos,

- garantir que apenas um plano ativo seja possível.

