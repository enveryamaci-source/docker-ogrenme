var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Sigma kuralları!!!!!!");
Console.WriteLine("Matrix'ten sinyal: Birisi siteye baglandi!");

app.Run();
