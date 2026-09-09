var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => {
    Console.WriteLine("Matrix'ten sinyal: Birisi siteye baglandi!");
    return "Hello Sigma";
});

app.Run();
