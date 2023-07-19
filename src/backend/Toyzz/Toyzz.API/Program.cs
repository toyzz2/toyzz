using StackExchange.Profiling;
using Toyzz.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext(builder.Configuration);
builder.Services.AddUnitOfWork();

builder.Services.AddMvc();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddMiniProfiler(o =>
{
    o.PopupRenderPosition = RenderPosition.BottomLeft;
    o.PopupShowTimeWithChildren = true;
    o.RouteBasePath = "/profiler";
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.UseMiniProfiler();
app.MapControllers();

app.Run();