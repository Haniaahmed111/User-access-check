using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== User Access Check ===");


        Console.Write("Indtast brugernavn: ");
        string username = Console.ReadLine() ?? string.Empty;

        Console.Write("Indtast adgangskode: ");
        string password = Console.ReadLine() ?? string.Empty;

        Console.Write("Indtast bruger-ID: ");
        uint userId = 0;
        uint.TryParse(Console.ReadLine(), out userId);


        bool isAdmin = userId > 65536;


        bool validUsername = username.Length >= 3;


        bool hasSpecialChar = password.Contains("$") || password.Contains("|") || password.Contains("@");


        bool validPassword = hasSpecialChar &&
                             ((isAdmin && password.Length >= 20) ||
                              (!isAdmin && password.Length >= 16));


        Console.WriteLine();
        Console.WriteLine($"Er administrator: {isAdmin}");
        Console.WriteLine($"Brugernavn gyldigt: {validUsername}");
        Console.WriteLine($"Adgangskode gyldig: {validPassword}");
    }
}