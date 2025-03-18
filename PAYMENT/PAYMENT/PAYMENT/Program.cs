//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();




using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace YourNamespace
{
    public class Program
    {
        // Main method ���������Ѻ��������ͻ���पѹ
        public static void Main(string[] args)
        {
            // �� WebApplication.CreateBuilder ����Ѻ������� ASP.NET Core
            var builder = WebApplication.CreateBuilder(args);

            // ŧ����¹��ԡ�÷���ͧ���
            builder.Services.AddControllers();  // ���ͺ�ԡ������ ����ͧ���

            var app = builder.Build();

            // ��˹���õ�駤�Ңͧ HTTP pipeline
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            // ��˹���鹷ҧ����Ѻ Controller
            app.MapControllers();

            // ���¡��ҹ�ͻ���पѹ
            app.Run();
        }
    }
}

