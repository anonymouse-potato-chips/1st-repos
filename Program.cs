var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Ok("Hello from 1st-repo"));

app.UseDefaultFiles();
app.UseStaticFiles();

app.Run();
