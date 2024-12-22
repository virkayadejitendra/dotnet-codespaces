// Backend: .NET Core API Setup

// Suggested Folder Structure:
// - OpenAPIIntegration
//   - Controllers
//     - TestController.cs
//   - Models
//   - Services
//   - Program.cs
//   - appsettings.json
//   - Startup.cs (if needed for additional configurations)

// Program.cs
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Add Swagger/OpenAPI
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



// Additional Folders (empty for now):
// Models: To define your domain models.
// Services: To include business logic or service layer implementation.
