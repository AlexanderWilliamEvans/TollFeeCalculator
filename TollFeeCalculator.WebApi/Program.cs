var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var AllowedOrigins = "_allowedOrigins";
builder.Services.AddCors(options =>
{
	options.AddPolicy(name: AllowedOrigins,
		policy =>
		{
			policy.WithOrigins("http://localhost:3000");
		}
		);
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
