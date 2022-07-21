using FileReaderAndWriteAPI.FileReaderAndWriter;
using Microsoft.AspNetCore.Builder;
using Models;

var builder = WebApplication.CreateBuilder(args);


var s=FileReadingUtilities.GetAllFilesInAPath(new FolderDetails { FolderPath= @"C:\Users\max\Videos" });



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwagger();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
