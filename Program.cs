using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haromszog
{
  class Program
  {
    static double Terulet(double a, double b, double c)
    {
      double s = (a + b + c) / 2;
      return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }
    
    static void Main(string[] args)
    {
      Console.WriteLine(Terulet(3,4,5));

      Console.ReadKey();
    }
  }
}
