using Microsoft.EntityFrameworkCore;
using student_portal.Data;
using student_portal.Resolvers;
using student_portal.Services;
using student_portal.Services.GraphQLServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddControllers().AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<StudentPortalDbContext>(options => {
    options.UseMySQL(builder.Configuration.GetConnectionString("schoolPortal"));
});

builder.Services.AddGraphQLServer().AddQueryType<QueryType>().AddMutationType<MutationType>();
builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<IStudentGQL, StudentServiceGQL>();

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
app.MapGraphQL();

app.Run();
