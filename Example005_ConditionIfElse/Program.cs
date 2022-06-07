Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "стёпа")
{
    Console.WriteLine("Ура, это же СТЁПА!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}