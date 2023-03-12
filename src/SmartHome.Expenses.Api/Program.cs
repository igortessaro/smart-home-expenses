using SmartHome.Expenses.Infrastructure.CrossCutting.IoC;

string originsPolicy = "AllowAllOrigins";
string[] headersExposed = new string[] { "Date", "Content-Type", "Content-Disposition", "Content-Length" };

var builder = WebApplication.CreateBuilder(args);

_ = builder.Services.AddControllers();
_ = builder.Services.AddEndpointsApiExplorer();
_ = builder.Services.AddSwaggerGen();
_ = builder.Services.AddRouting(options => options.LowercaseUrls = true);
_ = builder.Services.AddCors(options =>
{
    options.AddPolicy(originsPolicy, b => b.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod().WithExposedHeaders(headersExposed));
});
_ = builder.Services.AddMysqlDbContext(builder.Configuration);
_ = builder.Services.AddInfrastructureAutoMapper();
_ = builder.Services.AddRelationalRepository();
_ = builder.Services.AddDomainService();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    _ = app.UseSwagger();
    _ = app.UseSwaggerUI();
}

_ = app.UseRouting();
_ = app.UseRequestLocalization();
_ = app.UseCors(originsPolicy);
_ = app.UseHttpsRedirection();
_ = app.UseAuthorization();
_ = app.MapControllers();

app.Run();