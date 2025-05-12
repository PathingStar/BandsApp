namespace BandsApp.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.MapControllers();
            app.Run();

            // Test kommentar
            // Testkommentar fr�n Mattias
            // Testkommentar fr�n Ghassan
            
        }
    }
}
