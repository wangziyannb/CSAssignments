using DapperTutorial.Menu;
using Infrastructure.Services;
namespace DapperTutorial;

public class Program
{
    public static void Main()
    {
        Menus m = new Menus();
        m.Run();
    }

}