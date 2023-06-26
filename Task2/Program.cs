

using System.Text.RegularExpressions;

int t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine());

    string regExpression = "^[a-zA-Z0-9_][a-zA-Z0-9-_]{1,23}$";

    var logins = new HashSet<string>();

    for (int j = 0; j < n; j++)
    {
        
        
        string login = Console.ReadLine();

        if (!Regex.IsMatch(login, regExpression) || login[0].ToString().Contains("-") || login.Length < 1 || login.Length > 24)
        {
            Console.WriteLine("NO");
        }
        else
        {
            string loginLowCase = login.ToLower();
            if (logins.Add(loginLowCase))
            {
                Console.WriteLine("YES");
            }
            else Console.WriteLine("NO");
            
        }
    }  

 
}
