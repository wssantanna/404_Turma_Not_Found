var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/quadrado", (double lado) =>
{
    double area = lado * lado;
    double perimetro = 4 * lado;

    return new
    {
        figura = "quadrado",
        lado,
        area,
        perimetro
    };
});

app.MapGet("/retangulo", (double largura, double altura) =>
{
    double area = largura * altura;
    double perimetro = 2 * (largura + altura);

    return new
    {
        figura = "retangulo",
        largura,
        altura,
        area,
        perimetro
    };
});

app.MapGet("/triangulo", (double @base, double altura) =>
{
    double area = (@base * altura) / 2.0;
    double hipotenusa = 0.0; // Implemente
    double perimetro = 0.0; // Implemente

    return new
    {
        figura = "triangulo_reto",
        @base,
        altura,
        area,
        hipotenusa,
        perimetro
    };
});

app.MapGet("/circulo", (double raio) =>
{
    double area = 0.0; // Implemente
    double perimetro = 0.0; // Implemente

    return new
    {
        figura = "circulo",
        raio,
        area,
        perimetro
    };
});

app.Run();
