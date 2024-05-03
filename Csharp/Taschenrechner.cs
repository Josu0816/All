using System;

class Program
{
 static void Main()
 {
   Console.WriteLine("Bitte geben Sie die erste Zahl ein:");
   double num1 = Convert.ToDouble(Console.ReadLine());

   Console.WriteLine("Bitte geben Sie die zweite Zahl ein:");
   double num2 = Convert.ToDouble(Console.ReadLine());

   Console.WriteLine("Bitte wählen Sie eine Operation (+, -, *, /):");
   char operation = Convert.ToChar(Console.ReadLine());

   double result = 0;

   switch (operation)
   {
     case '+':
       result = num1 + num2;
       break;
     case '-':
       result = num1 - num2;
       break;
     case '*':
       result = num1 * num2;
       break;
     case '/':
       if (num2 != 0)
         result = num1 / num2;
       else
         Console.WriteLine("Ungültige Division durch Null!");
       break;
     default:
       Console.WriteLine("Ungültige Operation!");
       break;
   }

   Console.WriteLine("Ergebnis: " + result);
 }
}