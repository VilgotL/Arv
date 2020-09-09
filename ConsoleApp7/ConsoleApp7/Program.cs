using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            double höjd;
            double bredd;
            int form;
            Console.WriteLine("Höjd: ");
            höjd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bredd: ");
            bredd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Skriv 1 om det är en rätvinklig triangel och 2 om det är en rektangel");
            form = Convert.ToInt32(Console.Read());
            if (form == 1)
            {
                Triangle t = new Triangle(bredd, höjd);
                Console.WriteLine("Area: " + t.Area());
                Console.WriteLine("Omkrets: " + t.Circumferance());
            }
            if (form == 2)
            {
                Rectangle r = new Rectangle(bredd, höjd);
                Console.WriteLine("Area: " + r.Area());
                Console.WriteLine("Omkrets: " + r.Circumferance());
            }
            Console.ReadLine();
        }
    }
}
