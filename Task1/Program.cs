
int t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine());
    string[] prices = Console.ReadLine().Split(' ');

    Dictionary<int, int> count = new();

    for (int j = 0; j < n; j++)
    {
        int price = int.Parse(prices[j]);

        if (count.ContainsKey(price))
            count[price]++;
        else
            count[price] = 1;
    }

    int total = 0;
                      

    foreach (var pair in count)
    {
        int quantityPerShare = pair.Value / 3 * 2;

        if (pair.Value % 3 != 0)
        {
            int remainder = pair.Value % 3;
            quantityPerShare += remainder;
        }

        total += quantityPerShare * pair.Key;
    }

           

    Console.WriteLine(total);
}

