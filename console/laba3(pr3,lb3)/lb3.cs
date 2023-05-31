using System;
class Hel {
  static void Main() {
      double g,x,z;
      int n;
      Console.WriteLine("vvedite n");
      n = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("vvedite x");
      x = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("vvedite z");
      z = Convert.ToDouble(Console.ReadLine());
      
      for (int i=1;i<=n;i++){
          if (i%2==0) g=Math.Sin(Math.Pow(z,i));
          else g=Math.Cos(Math.Pow(z,i));
     Console.WriteLine("g="+ (Math.Round((0.8*i-g)/(Math.Sqrt(x*x+5*i*x+20+5*i)),2)));
     
      }
     
  }
  
  
  
}