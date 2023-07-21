using OrderControlReact.BLL.Managers;
using OrderControlReact.Core.Src;
using PetaPoco;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddControllers();
builder.Services.AddControllers()
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.PropertyNamingPolicy = null;
                });
builder.Services.AddTransient<Manager>();
builder.Services.AddScoped<OrderManager>();
var level3DbConnection = builder.Configuration.GetSection("ConnectionString").Get<ConnectionString>();
var dbProviders = builder.Configuration.GetSection("DbProviders").Get<DbProviders>();
builder.Services.AddHttpContextAccessor();

builder.Services.AddSingleton(x =>
{
    return new Database(DatabaseConfiguration.Build()
   .UsingConnectionString(ConnectionString.PostGre)
   .UsingProviderName(DbProviders.PostSql)
   .UsingDefaultMapper<ConventionMapper>(m =>
   {
       m.InflectTableName = (inflector, s) => s.ToLowerInvariant();
       m.InflectColumnName = (inflector, s) => s.ToLowerInvariant();
   })
   .UsingCommandTimeout(180)
   .WithAutoSelect());
}
);
builder.Services.AddScoped<IDatabase>(x =>
{
    return DatabaseConfiguration.Build()
       .UsingConnectionString(ConnectionString.PostGre)
       .UsingProviderName(DbProviders.PostSql)
       .UsingDefaultMapper<ConventionMapper>(m =>
       {
           m.InflectTableName = (inflector, s) => s.ToLowerInvariant();
           m.InflectColumnName = (inflector, s) => s.ToLowerInvariant();
       })
       .UsingCommandTimeout(180)
       .WithAutoSelect()
       .Create();
});
builder.Services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
{
    builder.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader();
}));
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();
app.UseCors("MyPolicy");
app.MapControllers();

app.Run();
