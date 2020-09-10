using System;

namespace Modellering
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] arr = {33, 44, 55, 66};


      Audience a1 = new Audience();
      a1.size = 300;
      a1.excitement = 3;

      Audience a2 = new Audience() {size = 300, excitement = 3};

      a1.excitement = 30;
      
      Football theBall = new Football();
      Football theOtherBall = new Football();

      theBall.x = 100;

      System.Console.WriteLine(theOtherBall.x);

      Console.ReadLine();
    }
  }
}
