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
        // Main method ที่ใช้สำหรับเริ่มต้นแอปพลิเคชัน
        public static void Main(string[] args)
        {
            // ใช้ WebApplication.CreateBuilder สำหรับเริ่มต้น ASP.NET Core
            var builder = WebApplication.CreateBuilder(args);

            // ลงทะเบียนบริการที่ต้องการ
            builder.Services.AddControllers();  // หรือบริการอื่นๆ ที่ต้องการ

            var app = builder.Build();

            // กำหนดการตั้งค่าของ HTTP pipeline
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

            // กำหนดเส้นทางสำหรับ Controller
            app.MapControllers();

            // เรียกใช้งานแอปพลิเคชัน
            app.Run();
        }
    }
}

