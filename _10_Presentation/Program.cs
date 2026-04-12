using _10_Presentation;
using _20_Business;
using _30_Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPresentationLayer();
builder.Services.AddBusinessLayer();
builder.Services.AddInfrastructureLayer();

var app = builder.Build();

app.Run();