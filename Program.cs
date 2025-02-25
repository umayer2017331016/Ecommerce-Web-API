var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/",()=>{
    return "Web API Project is running";
});

app.MapGet("/hello",()=>{
    return "Get Method";
});

app.MapPost("/helloPost",()=>{
    return "POST Method";
});

app.MapPut("/hello",()=>{
    return "PUT Method";
});

app.Run();
