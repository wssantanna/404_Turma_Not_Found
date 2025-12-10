var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/quadrado", (double lado) =>
{

        if (lado <= 0)
        {
            throw new ArgumentException("Entrada Inválida");
        } 
        else
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
        }
    
});

app.MapGet("/retangulo", (double largura, double altura) =>
{
    if (largura <= 0 || altura <= 0)
    {
        throw new ArgumentException("Entrada Inválida");
    }
    else 
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
    }
});

app.MapGet("/triangulo", (double @base, double altura) =>
{
    if (@base <= 0 || altura <= 0)
    {
        throw new ArgumentException("Entrada Inválida");
    }
    else
    {
        double area = (@base * altura) / 2.0;
        double hipotenusa = Math.Sqrt(Math.Pow(@base, 2) + Math.Pow(altura, 2));
        double perimetro = @base + altura + hipotenusa;

        return new
        {
            figura = "triangulo_reto",
            @base,
            altura,
            area,
            hipotenusa,
            perimetro
        };
    }
});

app.MapGet("/circulo", (double raio) =>
{
    if (raio <= 0)
    {
        throw new ArgumentException("Entrada Inválida");
    }
    else
    {
        double area = Math.PI * Math.Pow(raio, 2);
        double perimetro = 2 * Math.PI * raio;

        return new
        {
            figura = "circulo",
            raio,
            area,
            perimetro
        };
    }
});

app.Run();
