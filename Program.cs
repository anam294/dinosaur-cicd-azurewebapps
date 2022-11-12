var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.

// app.UseSwagger();
// app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapGet("/", () => "<html>  <head>    <title>Href Attribute Example</title>  </head>  <body>    <h1>Href Attribute Example</h1>    <p>The freeCodeCamp Contribution Page</a> shows you how and where you can contribute to freeCodeCamp's community and growth.    </p>  </body></html>");

app.MapControllers();

app.Run();

