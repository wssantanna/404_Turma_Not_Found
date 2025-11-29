# Problema

Calcular IOF em Operações Financeiras.

**Como** usuário da aplicação,<br>**quero** nformar o tipo de operação e o valor da operação, <br>**para** que a aplicação calcule o IOF devido e o valor final da operação com o imposto incluído.

## Critérios de aceite

1. O sistema deve solicitar dois dados obrigatórios do usuário:
- o tipo de operação financeira;
- o valor da operação em reais.
2. O sistema deve aceitar somente os seguintes tipos de operação como válidos:
- Empréstimo
- Financiamento
- Cartão de crédito
- Seguro
- Câmbio (câmbio de moedas)
3. Para cada tipo válido, o sistema deve aplicar a taxa de IOF correspondente:

| Tipo | Taxa |
| --- | --- |
| Empréstimo ou Financiamento | 3.38% |
| Cartão de crédito | 4.38% |
| Seguro | 25% |
| Câmbio de moedas | 1.1% | 

4. O cálculo deve seguir obrigatoriamente a fórmula:
- IOF (R$) = valor da operação × taxa
- Valor final = valor da operação + IOF
5. O sistema deve exibir a resposta final no seguinte formato:
“O valor pago de IOF será de R$ X, resultando em um total final de R$ Y.”
6. Caso o usuário informe um tipo de operação inválido, o sistema deve exibir:
“Tipo de operação inválido”
7. Caso o valor informado não seja numérico (ex.: texto, símbolo, vazio), o sistema deve exibir:
“Entrada inválida”
8. Caso o valor informado seja negativo, o sistema deve rejeitar a operação e exibir:
“Entrada inválida”
9. Caso o valor informado seja zero, o sistema deve aceitá-lo como um valor válido e:
- aplicar a taxa correspondente resultando em IOF R$ 0,00;
- exibir:
“O valor pago de IOF será de R$ 0,00, resultando em um total final de R$ 0,00.”
10.	As casas decimais devem seguir o padrão brasileiro, utilizando:
- vírgula como separador decimal;
- duas casas decimais.

## Casos de teste

| Caso | Entrada | Ação esperada | Saída |
| --- | --- | --- | --- |
| Empréstimo | Empréstimo, 1000 | Aplicar taxa de 3.38% | "O valor pago de IOF será de R$ 33,80, resultando em um total final de R$ 1.033,80." |
| Financiamento | Financiamento, 1000 | Aplicar taxa de 3.38% | "O valor pago de IOF será de R$ 33,80, resultando em um total final de R$ 1.033,80." |
| Cartão de crédito | Cartão de crédito, 500 | Aplicar taxa de 4.38% | "O valor pago de IOF será de R$ 21,90, resultando em um total final de R$ 521,90." |
| Seguro | Seguro, 2000 | Aplicar taxa de 25% | "O valor pago de IOF será de R$ 500,00, resultando em um total final de R$ 2.500,00." |
| Câmbio de moedas | Câmbio, 3000 | Aplicar taxa de 1.1% | "O valor pago de IOF será de R$ 33,00, resultando em um total final de R$ 3.033,00." |
| Tipo inválido | “abc”, 500 | Rejeitar tipo desconhecido | "Tipo de operação inválido" |
| Valor inválido | Seguro, "abc" | Rejeitar valor não numérico | "Entrada inválida" |
| Valor negativo | Empréstimo, -100 | Rejeitar valor negativo | "Entrada inválida" |
| Valor zero | Empréstimo, 0 | Aceitar valor zero e aplicar taxa correspondente  | "O valor pago de IOF será de R$ 0,00, resultando em um total final de R$ 0,00." |
