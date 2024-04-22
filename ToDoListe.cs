using System;

using System.Collections.Generic;

class Program
{
 static void Main()
 {
   List<string> tasks = new List<string>();
   while (true)
   {
     Console.WriteLine("1. Aufgabe hinzufügen");
     Console.WriteLine("2. Aufgaben anzeigen");
     Console.WriteLine("3. Aufgabe löschen");
     Console.WriteLine("0. Index zum löschen");
     Console.WriteLine("4. Beenden");
     int choice = Convert.ToInt32(Console.ReadLine());
     switch (choice)
     {
       case 1:
         Console.WriteLine("Geben Sie die Aufgabe ein:");
         string task = Console.ReadLine();
         tasks.Add(task);
         break;
       case 2:
         Console.WriteLine("Aufgaben:");
         foreach (string t in tasks)
         {
           Console.WriteLine(t);
         }
         break;
       case 3:
         Console.WriteLine("Geben Sie den Index der zu löschenden Aufgabe ein:");
         int index = Convert.ToInt32(Console.ReadLine());
         if (index >= 0 && index < tasks.Count)
         {
           tasks.RemoveAt(index);
         }
         else
         {
           Console.WriteLine("Ungültiger Index.");
         }
         break;
       case 4:
         return;
     }
   }
 }
}