part1();
part2();
void part1()
{
    try
    {
        using (var sr = new StreamReader("../../../input.txt"))
        {
            int sum = 0;
            while (!sr.EndOfStream)
            {
                var input = sr.ReadLine().ToString();
                var firstLength = input.Length / 2;
                var secondLength = input.Length - firstLength;

                string first = input.Substring(0, firstLength);
                string second = input.Substring(firstLength, secondLength);

                char duplicate = checkForDuplicate(first, second);
                sum = sum + getPrio(duplicate);

            }
            Console.WriteLine("Sum1: " + sum);
        }
    }
    catch (IOException e)
    {
        Console.WriteLine("The file could not be read:");
        Console.WriteLine(e.Message);
    }
}
void part2()
{
    try
    {
        using (var sr = new StreamReader("../../../input.txt"))
        {
            int sum = 0;

            while (!sr.EndOfStream)
            {
                string[] input = {"","",""};
                for (int i = 0; i < 3; i++)
                {
                    input[i] = sr.ReadLine().ToString();
                }
                var duplicate = checkForDuplicate(input[0], input[1]);
                while (!input[2].Contains(duplicate))
                {
                    input[0] = input[0].Replace(duplicate, '-');
                    input[1] = input[1].Replace(duplicate, '-');
                    duplicate = checkForDuplicate(input[0], input[1]);
                }
                sum = sum + getPrio(duplicate);
            }
            Console.WriteLine("Sum2: " + sum );
        }
    }
    catch (IOException e)
    {
        Console.WriteLine("The file could not be read:");
        Console.WriteLine(e.Message);
    }
}

char checkForDuplicate(string first, string second)
{
    char duplicate = '-';
    foreach (char c in first)
    {
        foreach (char d in second)
        {
            if (c == d)
            {
                duplicate = d;
                break;
            }
        }
        if(duplicate!= '-')
        {
            break;
        }
    }
    return duplicate;
}

int getPrio(char c)
{
    string alpha = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

    for (int i = 0; i < alpha.Length; i++)
    {
        if (alpha[i] == c)
        {
            return i + 1;
        }
    }
    return 0;
}