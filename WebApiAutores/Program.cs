using WebApiAutores;

var builder = WebApplication.CreateBuilder(args);

var Startup = new startup(builder.Configuration);
Startup.ConfigureServices(builder.Services);


var app = builder.Build();


var servicioLogger = (ILogger<startup>)app.Services.GetService(typeof(ILogger<startup>));

Startup.Configure(app, app.Environment, servicioLogger);


app.Run();
