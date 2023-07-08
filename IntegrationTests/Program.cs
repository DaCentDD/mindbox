using MB;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSquare();
var app = builder.Build();
app.Run();