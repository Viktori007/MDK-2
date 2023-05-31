//7 вариант
using System;
class Massiv2 {
  static void Main() {
      
    Console.WriteLine("Введите количество строк: [целое числовое значение] ");
    int a=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество элементов одномерного столбцов: [целое числовое значение] ");
    int b=Convert.ToInt32(Console.ReadLine());
    Random rand = new Random() ;
    int[,] ar = new int[a,b];
    int[,] ar2 = new int[a,b];
    
    for(int i=0;i<a;i++) {
        for(int j=0;j<b;j++) {
    ar[i,j]=rand.Next(100);
    Console.Write( ar[i,j]+ " ");
    }
    Console.Write("\n");
    }
    Console.Write("\n");
    for(int i=0;i<a;i++) {
        for(int j=0;j<b;j++) {
    ar2[i,j]=rand.Next(100);
    Console.Write( ar2[i,j]+ " ");
    }
    Console.Write("\n");
    }
    