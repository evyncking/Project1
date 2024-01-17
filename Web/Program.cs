using MathService;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<FactorialService>();

var app = builder.Build();

app.MapGet("/", (FactorialService factorialService) => 
{
    int result = factorialService.CalculateFactorial();
    return $"Here is factorial(5): {result}";
});

app.Run();
