using MyWebApp;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/avengers", () => new Avengers().GetCharacters());

app.Run();
