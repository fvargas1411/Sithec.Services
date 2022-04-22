using Microsoft.EntityFrameworkCore;
using Sithec.Humano.Persistencia;
using System;
using System.IO;

namespace Sithec.Humano.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionBuilder.UseSqlServer(@"server=FINLPT0074\SQL2016;database=DBHUMANO; User Id=sa;Password=FINASIST; timeout = 900; Current language=español;");

            var context = new AppDbContext(optionBuilder.Options);

            //TestConnection(context);
        }

        static void TestConnection(AppDbContext context)
        {
            var isCon = true;

            try 
            {
                isCon = context.Database.EnsureCreated();
            }
            catch (Exception) 
            {
                isCon = false;
            }

            if (isCon)
                System.Console.WriteLine("Conexión exitosa");
            else
                System.Console.WriteLine("Conexión no exitosa");

            System.Console.Read();
        }
    }
}
