using System;


class Program
{
  static void Main ()
  {
	Console.WriteLine ("Passwortlänge eingeben:");

	int length = Convert.ToInt32 (Console.ReadLine ());

	string password = GeneratePassword (length);

	  Console.WriteLine ("Generiertes Passwort: " + password);

  }
  static string GeneratePassword (int length)
  {
	string characters =
	  "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

	Random random = new Random ();

	string password = "";

	for (int i = 0; i < length; i++)
	  {
		int index = random.Next (characters.Length);

		password += characters[index];

	  }
	return password;
  }
  Console.WriteLine ("Funktionierts ?");
  
}