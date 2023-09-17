Console.Write("Enter your name");
string UserName = Console.ReadLine();
if (UserName.ToLower() == "sergey") // Операция .ToLower() - позволяет перевести все символы нашей строки в нижний регистр.
{
    Console.WriteLine("Ура , это же Сергей");
}
else
{
    Console.WriteLine("Привет, " + UserName);
}