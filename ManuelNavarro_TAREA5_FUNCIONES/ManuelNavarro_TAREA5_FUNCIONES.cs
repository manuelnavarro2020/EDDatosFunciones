using System;
public class Tarea1{
 public static int signo(float n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                if (n > 0)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }
        public static void Main(string[] args)
        {
            float numero;
            Console.WriteLine("Ingrese un número: ");
            numero = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(signo(numero));
        }

}

using System;
public class Tarea2{
public static void Menor(int num1, int num2){

if(num1 > num2){
 Console.WriteLine("El numero {0} es menor",num2);
}
else{
  Console.WriteLine("El numero {0} es menor", num1);

}
}
public static void Main(string[]args){
  int num1;
  int num2;
Console.WriteLine("Digite un numero: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite otro numero: ");
num2 = Convert.ToInt32(Console.ReadLine());
Menor(num1,num2);

 }
}

using System;
public class Tarea3{
public static bool EsPrimo(int num){

if(num==2 || num%2 !=0){
  return true;
}
else {
  return false;

}
}
public static void Main (string[]args){

int num;
Console.WriteLine("Ingrese un numero: ");
num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(EsPrimo(num));

  }
 }

 using System;
public class Tarea5{
public static void Suma (int a, int b){

Console.Write(a+b);
}
public static void Resta (int a, int b){
Console.Write(a-b);
}
public static void Multiplicacion (int a, int b){
Console.Write(a*b);
}
public static void Division(int a, int b){
Console.Write(a/b);
}

public static void Main(string[]args){
Console.WriteLine("***********CALCULA***********");
Console.Write("Calcula 5+4: ");
Suma(5,4);
Console.WriteLine("");
Console.Write("Calcula 3-2: ");
Resta(3,2);
Console.WriteLine("");
Console.Write("Calcula 6*6: ");
Multiplicacion(6,6);
Console.WriteLine("");
Console.Write("Calcula 10/2: ");
Division(10,2);


 }
}

using System;
 public class Tarea6{
 public static int SumaCifras(String n)
        {
            int num = int.Parse(n);
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
        static void Main(string[] args)
        {
          Console.WriteLine("Digite un numero: ");

            Console.WriteLine(SumaCifras("678"));          
        }
 }

  using System;
 public class Tarea7{
   public static void Triangulo(int numero, string letra){
     for (int i = numero; i>=1; i--){
       for(int a=i; a>=1; a--){

         Console.Write(letra);
        }
        Console.WriteLine();
     }
     }
  public static void Main(string[] args){
    Triangulo(10, "z");

  }
 
 }
 