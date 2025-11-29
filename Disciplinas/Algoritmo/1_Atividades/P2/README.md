# Problema

Calcular a média de números positivos

**Como** usuário da aplicação,<br>**quero** inserir uma sequência de números inteiros positivos, <br>**para** que a aplicação calcule e exiba a média apenas dos valores positivos informados.

## Critérios de aceite

1. O sistema deve solicitar que o usuário informe um ou mais números inteiros positivos, separados por vírgula ou inseridos um por vez.
2. O sistema deve desconsiderar qualquer número negativo informado.
3. O sistema deve validar entradas inválidas, como:
- letras ("texto")
- símbolos que não são números
- valores não inteiros, se estiver seguindo somente inteiros
4. Caso ao menos um número positivo tenha sido informado, o sistema deve:
- somar apenas os valores positivos
- contar quantos valores positivos foram digitados
- calcular a média com a fórmula: `MÉDIA = SOMA DOS POSITIVOS / QUANTIDADE DE POSITIVOS`
5. O sistema deve exibir a média no formato:
- A média dos números positivos é: X
6. Caso nenhum número positivo tenha sido inserido, o sistema deve exibir:
- Nenhum número positivo foi informado
7. O sistema deve permitir encerramento quando o usuário digitar 0 como valor final da sequência.

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
