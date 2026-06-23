var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Ok("Naveer Gib Up Fren"));

app.UseDefaultFiles();
app.UseStaticFiles();

app.Run();
