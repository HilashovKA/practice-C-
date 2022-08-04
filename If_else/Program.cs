Console.WriteLine("Ведите имя пользовател ");
string username = Console.ReadLine();

if(username.ToLower() == "Маша")
{
    Console.WriteLine("Ура, Маша");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}