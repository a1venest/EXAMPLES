Console.WriteLine("Как Вас зовут?");
string username = Console.ReadLine();

if(username.ToLower() == "маша") 
    {
        Console.WriteLine("Привет, Машенька!");
    }
else
    {
        Console.Write("Привет, ");
        Console.Write(username);
    }