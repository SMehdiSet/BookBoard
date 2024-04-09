using BookBoard.DataLayer.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

#region DateBase Context

builder.Services.AddDbContext<BookBoardContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("BookBoardConnection"));
});

#endregion
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
