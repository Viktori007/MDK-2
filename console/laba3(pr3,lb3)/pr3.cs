using System;

class HelloWorld
{
  static void Main ()
  {
    for(int x=10;x<90;x+=10)
    Console.WriteLine(x+" gr "+"sin="+ Math.Round(Math.Cos(x),2) + " cos=" + Math.Round(Math.Sin(x),2));
  }
}
