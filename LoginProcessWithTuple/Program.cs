(string, int) account = ("admin", 123456);
bool loggedIn = true;

while (loggedIn)
{
    Console.Write("Enter your username:");
    string userName = Console.ReadLine();
    Console.Write("Enter your password:");
    int password = int.Parse(Console.ReadLine());

    try
    {
        if (userName == account.Item1 && password == account.Item2)
        {
            loggedIn = false;
        }
        else
        {
            throw new Exception("Wrong username or password");
        }
    }
    catch(Exception ex) 
    {
        Console.WriteLine(ex.Message);
    }

}
