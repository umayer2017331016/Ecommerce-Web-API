var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer(); 
builder.Services.AddSwaggerGen();

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if(app.Environment.IsDevelopment()){
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/",()=> "Web API Project is running");

app.MapGet("/hello",()=>{
    var response = new {message ="This ia json object",
    success=true};
    return response;
});

app.MapPost("/helloPost",()=>{
    return "POST Method";
});

app.MapPut("/hello",()=>{
    return "PUT Method";
});

app.Run();
