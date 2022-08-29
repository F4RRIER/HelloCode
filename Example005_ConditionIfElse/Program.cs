Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "misha")
{
    Console.WriteLine("Ура, это же Misha");

}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}