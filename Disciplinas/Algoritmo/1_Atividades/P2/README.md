# Problema

Calcular a média de números positivos

**Como** usuário da aplicação,<br>**quero** inserir uma sequência de números inteiros positivos, <br>**para** que a aplicação calcule e exiba a média apenas dos valores positivos informados.

## Critérios de aceite

1. O sistema deve permitir a entrada de múltiplos valores numéricos, podendo ser positivos, negativos ou decimais, encerrando a coleta quando o usuário informar o valor 0.
2. A média deve ser calculada considerando apenas os números positivos, ignorando qualquer número negativo informado pelo usuário.
3. Caso seja informado apenas um número positivo antes do zero, o sistema deve calcular a média com base nesse único valor.
4. Se nenhum número positivo for informado, o sistema deve exibir a mensagem:
- "Nenhum número positivo foi informado"
5. O sistema deve rejeitar valores inválidos, como texto ou caracteres não numéricos, exibindo a mensagem:
- "Entrada inválida"
6. O sistema deve aceitar números decimais positivos como válidos, calculando a média corretamente.
7. Ao receber o valor 0 como primeira entrada, o sistema deve encerrar imediatamente e exibir:
- "Nenhum número positivo foi informado"
8. Para combinações de positivos, negativos e zero, o sistema deve:
- Somar apenas os valores positivos
- Ignorar negativos
- Cálculo da média = soma dos positivos ÷ quantidade de positivos
9. A saída deve apresentar somente o valor numérico final da média, sem textos adicionais, conforme a tabela de casos de uso.

## Casos de teste

| Caso | Entrada | Ação esperada | Saída |
|---|---|---|---|
| Inserção de números positivos | 5, 10, 15, 0 | Calcular a média dos números positivos | 10.0 |
| Inserção de números negativos | -3, -7, -1, 0 | Ignorar números negativos | Nenhum número positivo foi informado |
| Mistura de positivos e negativos | -2, 8, -4, 12, 0 | Somar apenas os números positivos | 10.0 |
| Inserção de um único número positivo | 7, 0 | Calcular a média de um único número | 7.0 |
| Inserção de positivos misturados a zero | -3, 2, 5, 0, 1 | Somar apenas números positivos | 4.0 |
| Inserção de valor não válido | "texto", 5, 0 | Rejeitar entrada inválida | "Entrada inválida" |
| Inserção de número decimal | 4.5, 0 | Aceitar número decimal como válido | 4.5 |
| Apenas números negativos seguidos de zero | -5, -3, -1, 0 | Ignorar negativos e encerrar cálculo | Nenhum número positivo foi informado |
| Inserção do valor zero diretamente | 0 | Encerrar o loop sem realizar cálculos | Nenhum número positivo foi informado |
