var app = WebApplication.Create(args);
//WebApplication class : it used to configure the HTTP pipeline and routes

// Add services to the container.

//builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

/*
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();
*/
app.Urls.Add("http://localhost:3000");
app.Urls.Add("http://localhost:4000");
app.MapGet("/", ()=>"Hello World");
app.Run();
