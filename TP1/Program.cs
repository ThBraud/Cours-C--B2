using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Security.Cryptography;

Person person = new Person();

Console.WriteLine("Quel est votre nom ?");
person.LastName = Console.ReadLine();
Console.WriteLine("Quel est votre prénom ?");
person.FirstName = Console.ReadLine();
Console.WriteLine("Quel est votre date de naissance (JJ/MM/YYYY) ?");
String birthDate = Console.ReadLine();
Console.WriteLine("Quel est votre adresse (rue, code postal, ville) ?");
String address = Console.ReadLine();

List<String> addressDetails = address.Split(",").ToList();

DateTime.TryParse(birthDate, out DateTime birth);

DateTime ajd = DateTime.Today;

if (DateTime.Compare(birth, ajd) < 0)
{
    int age = ajd.Year - birth.Year;
    if (birth.Date > ajd.AddYears(-age))
    {
        age--;
    }

    return age;
}


Console.WriteLine("Hello, World!");
Console.WriteLine($"Bonjour {person.FirstName} {person.LastName}, ");
Console.Write($"tu as {birthDate} ans et tu habites au {addressDetails[0]} {addressDetails[1]} {addressDetails[2]}.");