using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

Console.WriteLine("Enter number from 1 to 5 to choose a task");
int task = Convert.ToInt32(Console.ReadLine());

if (task == 1)
{
    Console.WriteLine("Write landline");
    string landline = Console.ReadLine();
    string landlineValidator = @"^\d{3}\s?\d{3}";
    if (Regex.IsMatch(landline, landlineValidator))
    {
        Console.WriteLine($"{landline} is valid landline");
    }
    else
    {
        Console.WriteLine($"{landline}don't meet requirements of validation");
    }
}
else if (task == 2)
{
    Console.WriteLine("Write phone number");
    string phoneNumber = Console.ReadLine();
    string phoneNumberValidator = @"^[+]?\d{3}\s?\d{2}\s?\d{3}\s?\d{4}$";

    if (Regex.IsMatch(phoneNumber, phoneNumberValidator))
    {
        Console.WriteLine($"{phoneNumber} is valid phone number");
    }
    else
    {
        Console.WriteLine($"{phoneNumber}don't meet requirements of validation");
    }
}
else if (task == 3)
{
    Console.WriteLine("Write email");
    string email = Console.ReadLine();
    string emailValidator = @"^[a-zA-Z0-9./+_-]{2,20}[a-zA-Z0-9./+_-]{2,20}[@][a-zA-Z0-9.]+$";
    if (Regex.IsMatch(email, emailValidator))
    {
        Console.WriteLine($"{email} is valid email");
    }
    else
    {
        Console.WriteLine($"{email}don't meet requirements of validation");
    }
}
else if (task == 4)
{
    Console.WriteLine("Write your full name");
    string fullName = Console.ReadLine();
    string fullNameValidator = @"^([a-zA-Zа-яА-Я]{2,20})\s([a-zA-Zа-яА-Я]{2,20})\s([a-zA-Zа-яА-Я]{2,20})$";
    if (Regex.IsMatch(fullName, fullNameValidator))
    {
        Console.WriteLine($"{fullName} is valid full name");
    }
    else
    {
        Console.WriteLine($"{fullName}don't meet requirements of validation");
    }
}
else if (task == 5)
{
    Console.WriteLine("Write your password");
    string password = Console.ReadLine();
    string passwordValidator = "(([A-Z]|[a-z]|[/*-+!@#$%^&*]|[0-9])+){8,15}";//Additional task don't completly meet requirements
    if (Regex.IsMatch(password, passwordValidator))
    {
        Console.WriteLine($"{password} is valid password");
    }
    else
    {
        Console.WriteLine($"{password}don't meet requirements of validation");
    }
}
else
{
    Console.WriteLine("There is no task with this number");
}