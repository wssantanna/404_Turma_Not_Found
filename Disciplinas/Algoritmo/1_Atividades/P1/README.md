# Problema

Somar sequência de números reais.

**Como** usuário da aplicação,<br>**quero** informar uma sequência de números reais, <br>**para** que a aplicação calcule e apresente a soma final desses valores.

## Critérios de aceite

1.	O sistema deve solicitar que o usuário informe dois ou mais números reais, aceitando valores positivos e negativos.

2.	O sistema deve continuar recebendo números até que o usuário informe o valor de parada (por exemplo, 0).

3.	Ao receber o valor de parada, o sistema deve calcular a soma de todos os números informados anteriormente.

4.	A saída deve exibir a soma final de forma clara e numérica.

5.	A soma deve ser calculada corretamente para:
- somente valores positivos;
- somente valores negativos;
- mistura de valores positivos e negativos.

## Casos de teste

| Caso | Entrada | Ação esperada | Saída |
| --- | --- | --- | --- | 
| Inserção de números positivos | 5, 10, 15, 0 | Somar os valores positivos | 30 |
| Inserção de números negativos | -3, -7, -1, 0 | Ignorar números negativos | -11 | 
| Mistura de números positivos e negativos | -2, 8, -4, 12, 4 | Somar números positivos e então subtrair os números negativos | 18 |