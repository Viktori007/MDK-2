//7 вариант
using System;
class Massiv {
  static void Main() {
      
    Console.WriteLine("Введите количество элементов одномерного массива: [целое числовое значение] ");
    int a=Convert.ToInt32(Console.ReadLine());
    Random rand = new Random() ;
    int max=0,min=0,m1=0,m2=0;
    int[] ar = new int[a];
    for(int i=0;i<a;i++) {
    ar[i]=rand.Next(100);
    Console.WriteLine( ar[i]+ "  ");
    }
    min=ar[0]; max=ar[0];
    for(int i=0;i<a;i++) {
        if (min>=ar[i]) {
            min=ar[i];
            m1=i+1;
        }
        if (max<ar[i]){
            max=ar[i];
            m2=i+1;
        }
    }
    
    Console.WriteLine("позиция минимального элемента: "+ m1 + "\n позиция максимального элемента: "+ m2);
  }
}