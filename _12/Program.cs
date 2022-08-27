
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности.");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Кординаты центра окружности х0, у0.");
            double x0 = Convert.ToDouble(Console.ReadLine());
            double y0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите кординаты точки.");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());

            double Circumference = Rectangle.GetCircumference(r);
            double Square = Rectangle.GetSquare(r);
            double Have = Rectangle.GetHave(r, x0, y0, x1, y1);
            Console.WriteLine($"{Circumference}");
            Console.WriteLine($"{Square}");
            Console.ReadKey();
        }
    }
}
