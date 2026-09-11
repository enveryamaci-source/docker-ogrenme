var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

string dbAdresi = "Host=veritabani;Port=5432;Database=oyun_verileri;Username=admin;Password=gizlisifre123";
Console.WriteLine($"[SİSTEM BAŞLATILDI] Veritabanı hedefi: {dbAdresi}");

app.MapGet("/", () => {
    Console.WriteLine("Matrix'ten sinyal: Birisi siteye baglandi!");
    return "Hello Sigma";
});

app.Run();
