# Problema

Calcular área e perímetro de figuras geométricas planas via API.

**Como** usuário da aplicação,<br> **quero** informar as dimensões de uma figura geométrica, seja a figura um quadrado, retângulo, triângulo retângulo ou círculo,<br> **para** que a aplicação calcule corretamente área e perímetro e devolva o resultado em formato `JSON`.

> **Nota:** O desenvolvedor não deve apagar as rotas; a atividade consiste em corrigir/validar entradas e implementar os cálculos faltantes de acordo com os critérios de aceite.

## Critérios de aceite

### 1 . A API deve manter as quatro rotas existentes.

| # | Metodo | Rota |
| --- | --- | --- |
| 1 | `GET` |`/quadrado` |
| 2 | `GET` | `/retangulo` |
| 3 | `GET` | `/triangulo` |
| 4 | `GET` | `/circulo` |

### 2 . Todas as rotas devem receber parâmetros obrigatórios a partir do recurso `query string`.

| # | Metodo | Rota | Parâmetro |
| --- | --- | --- | --- | 
| 1 | `GET` | `/quadrado` | `?lado=` |
| 2 | `GET` | `/retangulo` | `?largura=&altura=` |
| 3 | `GET` | `/triangulo` | `?base=&altura=` |
| 4 | `GET` | `/circulo` | `?raio=` |

### 3 . Para todas as figuras, todo parâmetro deve ser maior que zero:
- Se qualquer parâmetro for menor ou igual a zero, a rota deve rejeitar a operação e retornar:
  - "Entrada inválida"

### 4 . Se algum parâmetro estiver ausente ou não puder ser interpretado como número, a API também deve retornar:
- "Entrada inválida"

### 5 . Fórmulas obrigatórias:

#### Quadrado

##### A) Área 

$$
Área = lado^2
$$
##### B) Perímetro

$$
Perímetro = 4 \cdot lado
$$

#### Retângulo

##### A) Área

$$
Área = largura \cdot altura
$$

##### B) Perímetro

$$
Perímetro = 2(largura + altura)
$$

#### Triângulo retângulo

##### A) Área

$$
Área = \frac{base \cdot altura}{2}
$$


##### B) Hipotenusa[^1]

$$
Hipotenusa = \sqrt{base^2 + altura^2}
$$

[^1]: Teorema de Pitágoras.

##### C) Perímetro

$$
Perímetro = base + altura + hipotenusa
$$

#### Círculo

##### A) Área

$$
A = \pi \cdot raio^2
$$

##### B) Comprimento

$$
Comprimento = 2 \cdot \pi \cdot raio
$$

### 6 . As respostas de sucesso devem seguir estes formatos JSON:

#### Quadrado

```json
{
  "figura": "quadrado",
  "lado": <valor>,
  "area": <valor>,
  "perimetro": <valor>
}
```

#### Retângulo

```json
{
  "figura": "retangulo",
  "largura": <valor>,
  "altura": <valor>,
  "area": <valor>,
  "perimetro": <valor>
}
```

#### Triângulo

```json
{
  "figura": "triangulo_reto",
  "base": <valor>,
  "altura": <valor>,
  "area": <valor>,
  "hipotenusa": <valor>,
  "perimetro": <valor>
}
```

#### Círculo

```json
{
  "figura": "circulo",
  "raio": <valor>,
  "area": <valor>,
  "comprimento": <valor>
}
```

### 7 . Em caso de erro, a rota deve retornar apenas:

- "Entrada inválida"

## Casos de teste

### Quadrado

| Caso | Entrada | Ação esperada | Saída |
| --- | --- | --- | --- |
| Lado válido | `/quadrado?lado=4` | Calcular área e perímetro | `{ "figura": "quadrado", "lado": 4, "area": 16, "perimetro": 16 }` |
| Lado zero | `/quadrado?lado=0` | Rejeitar valor menor ou igual a zero | `"Entrada inválida"` |
| Lado negativo | `/quadrado?lado=-5` | Rejeitar valor menor ou igual a zero | `"Entrada inválida"` |

### Retângulo

| Caso | Entrada | Ação esperada | Saída |
| --- | --- | --- | --- |
| Lados válidos | `/retangulo?largura=5&altura=3` | Calcular área e perímetro | `{ "figura": "retangulo", "largura": 5, "altura": 3, "area": 15, "perimetro": 16 }` |
| Altura zero | `/retangulo?largura=5&altura=0` | Rejeitar valor menor ou igual a zero | `"Entrada inválida"` |
| Largura negativa | `/retangulo?largura=-2&altura=3` | Rejeitar valor menor ou igual a zero | `"Entrada inválida"` |

### Triângulo Retângulo

| Caso | Entrada | Ação esperada | Saída |
| --- | --- | --- | --- |
| Base e altura válidas | `/triangulo?base=3&altura=4` | Calcular área, hipotenusa e perímetro | `{ "figura": "triangulo_reto", "base": 3, "altura": 4, "area": 6, "hipotenusa": 5, "perimetro": 12 }` |
| Base zero | `/triangulo?base=0&altura=4` | Rejeitar valor menor ou igual a zero | `"Entrada inválida"` |
| Altura negativa | `/triangulo?base=3&altura=-4` | Rejeitar valor menor ou igual a zero | `"Entrada inválida"` |

### Círculo

| Caso | Entrada | Ação esperada | Saída |
| --- | --- | --- | --- |
| Raio válido | `/circulo?raio=3` | Calcular área e comprimento | `{ "figura": "circulo", "raio": 3, "area": 28.2743..., "comprimento": 18.8495... }` |
| Raio zero | `/circulo?raio=0` | Rejeitar valor menor ou igual a zero | `"Entrada inválida"` |
| Raio negativo | `/circulo?raio=-1` | Rejeitar valor menor ou igual a zero | `"Entrada inválida"` |