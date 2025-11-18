# Introdução à Banco de Dados

## O que é um Banco de Dados?

Vamos começar entendendo sobre Banco de Dados com conceitos práticos e rudimentares do nosso dia-a-dia!

Sabe aquela sua agenda de contatos telefônicos (isso é se você ainda utilizar né). Então pensa nela! Uma lista com dados que juntos compõe uma informação. Essa coleção de dados como por exemplo Nome, Número de Telefone, Endereço estão escritas em um papel. Isso por si só já é um banco de dados! 

Por estarem escritas em papel esta é uma forma analógica de banco de dados (dados que não estão armazenados em meios computacionais).

Agora quando, resolvemos utilizar meios computacionais para guarda-los chegamos à definição abaixo de banco de dados:

> Uma coleção organizada de informações (dados) armazenadas eletronicamente em um sistema computacional.

## SGBD

Sistema de Gerenciamento de Banco de Dados, é um conjunto de programas que permite ao usuário (ou a aplicação) interagir com o banco de dados de forma segura, eficiente e estruturada.

Ele gerencia tudo o que acontece com os dados: inserção, atualização, remoção, consulta, segurança, concorrência, backup, desempenho, etc.

### Tecnologia de Banco de Dados

Quando falamos em tecnologias de banco de dados estamos nos referindo à técnica de engenharia empregada na persistência[^1] dos dados nos dispositivos computacionais. 

Comercialmente temos hoje em dia duas grandes tecnologias com esta finalidade. São elas os **Banco de Dados Relacionais** e os **Banco de Dados NoSQL**.

[^1]: **Persistência** é o processo de conservar e armazenar dados em um mecanismo de armazenamento. Nesse processo, os dados são registrados de forma a serem preservados ao longo do tempo, garantindo sua integridade, confiabilidade e segurança.

#### Tecnologias Banco de Dados Relacionais

A tecnologia de banco de dados relacionais foi a primeira a surgir nos adventos da computação moderna. Neste modelo os dados são armazenados em tabelas bidimensionais. Ou seja, a tabela possui um conjunto de registros guardados em linhas e colunas. Cada coluna representa um dado de uma informação registrada pela linha.

A consulta dos dados neste modelo é feita por uma linguagem denominada SQL - Structured Query Language, ou em tradução livre, Linguagem de Consulta Estruturada.

Abaixo como é a disposição dos dados no modelo relacional. Mais à frente iremos ver especificidades deste modelo (este é nosso modelo alvo para os estudos).

| id | nome | ddd | celular |
| --- | --- | --- | --- |
| 1 | Beatriz Siqueira | 21 | 998700010 |
| 2 | Jorge Aragão | 21 | 985632100 |
| 3 | Fernanda Montenegro | 11 | 978452133 |

#### Tecnologias Banco de Dados NoSQL

A tecnologia NoSQL é uma tecnologia de banco de dados moderna criada para aumento de performance nas capacidades de leitura e gravação dos dados. Nesse modelo a informação é organizada em documentos e nós. 

Por exemplo o `MongoDB` que é uma das mais famosas tecnologias de banco de dados NoSQL. Ele armazena os dados em documentos e a estrutura desses dados é muito semelhante ao JSON[^2].

**Exemplo**

```json
[{
	"nome": "Beatriz Siqueira",
	"ddd": 21,
	"celular": "998700010"
},
{
	"nome": "Jorge Aragão",
	"ddd": 31,
	"celular": "985632100"
},
{
	"nome": "Fernanda Montenegro",
	"ddd": 11,
	"celular": "978452133"
}]
```

[^2]: **JSON**, acrônimo para **J**ava**S**cript **O**bject **N**otation.

#### Principais diferenças entre às Tecnologias

**Relacional**

Prós

- **Consultas flexíveis:** Suporta diferentes cargas de trabalho e implementa abstrações de dados em registros tabulares, permitindo que os mecanismos de banco de dados otimizem as consultas de forma eficiente.

- **Compactação de dados:** Graças à normalização e a diversas otimizações, é possível alcançar uma compactação que maximiza o desempenho do banco de dados e o uso dos recursos.

- **ACID:** Conjunto de propriedades — atomicidade, consistência, isolamento e durabilidade — que garantem forte integridade dos dados, assegurando que as transações sejam sempre válidas e confiáveis.

Contras

- **Rigidez de Modelo:** Bancos relacionais requerem um extremo cuidado em sua modelagem. Por possuírem um esquema pré-definido suas alterações futuras podem se tornar um problema a ser contornado.

- **Escalabilidade Horizontal Limitada:** Expandir horizontalmente os bancos relacionais ou são imaturamente empregados, ou é completamente sem suporte ou são feitos por meio de tecnologias especificas e proprietárias (não existe um consenso de mercado sobre).

**Não-Relacional ou NoSQL**

Prós

- **Escalabilidade e disponibilidade:** Normalmente bancos NoSQL são projetados para suportar escalabilidade horizontal.

- **Modelos Flexíveis:** a não exigência do compromisso com o modelo de dados é um ponto forte. Uma vez que os esquemas são dinâmicos e podem ser alterados na hora.

- **Alto Desempenho:** Devido a uma limitação de funcionalidades é possível obter um alto desempenho nos bancos NoSQL.

- **Abstração em alto nível:** Os bancos de dados NoSQL fornecem APIs de alto nível para as operações que serão realizadas. Garantindo facilidade devido a abstração implementada por elas. 

Contras

- **Consistência eventual:** Muitos bancos NoSQL priorizam disponibilidade e desempenho, o que pode resultar em modelos de consistência mais fracos, como a consistência eventual.

- **Menos maturidade em transações complexas:** Embora alguns sistemas já ofereçam recursos transacionais, muitos bancos NoSQL não suportam transações complexas com o mesmo nível de confiabilidade dos bancos relacionais.

- **Falta de padronização:** A diversidade de modelos (documentos, chave-valor, colunas, grafos) dificulta a padronização, tornando mais complexo migrar entre soluções e até aprender um único padrão universal.

- **Ferramentas e consultas menos robustas:** Em comparação com o SQL tradicional, algumas ferramentas de consulta, análise e integração podem ser mais limitadas, exigindo soluções personalizadas.

- **Curva de aprendizado:** Por envolver diferentes paradigmas e arquiteturas, o aprendizado pode ser mais desafiador, exigindo que o desenvolvedor compreenda bem o funcionamento do modelo escolhido.