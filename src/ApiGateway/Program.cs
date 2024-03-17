using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("Ocelot.json",optional:false,reloadOnChange:true);

//builder.Configuration.SetBasePath(builder.Environment.ContentRootPath).AddJsonFile("", optional: false, reloadOnChange: true);

builder.Services.AddControllers();

builder.Services.AddOcelot();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.UseOcelot().Wait();

app.MapGet("/", () => "Hello World!");

app.Run();
