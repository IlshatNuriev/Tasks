int n = int.Parse(Console.ReadLine());

string[] dictionary = new string[n];

for (int i = 0; i < n; i++)
{
    dictionary[i] = Console.ReadLine();
}

int q = int.Parse(Console.ReadLine());

for (int j = 0; j < q; j++)
{
    string s = Console.ReadLine();
    
    int t = 0;
    string temp = "";

    for (int k = 0; k < dictionary.Length; k++)
    {
        string stringToCompare = dictionary[k];
        int p = 0;        
               

        for(int k2 = 1; k2 < stringToCompare.Length && k2 < s.Length; k2++)
        {
            if (stringToCompare[stringToCompare.Length - k2] == s[s.Length - k2] && stringToCompare != s)
            {
                p++;
            }
            else break;
        }

        if (p > t)
        {
            t = p;
            temp = stringToCompare;
        }

    }

    if(!string.IsNullOrEmpty(temp))
    {
        Console.WriteLine(temp);
    }
    
}

