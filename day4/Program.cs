part1();

void part1()
{
    try
    {
        using (var sr = new StreamReader("../../../input.txt"))
        {
            int sum = 0;
            int sum2 = 0;
            while (!sr.EndOfStream)
            {
                var input = sr.ReadLine().ToString();
                int[] elf1 = Array.ConvertAll(input.Split(',')[0].Split('-'), int.Parse);
                int[] elf2 = Array.ConvertAll(input.Split(',')[1].Split('-'), int.Parse);
                int leastZones = Math.Min(elf1[1] - elf1[0], elf2[1] - elf2[0]) + 1;
                int[] elf1TranslatedZones = TranslateZones(elf1);
                int[] elf2TranslatedZones = TranslateZones(elf2);
                if(CheckZones(elf1TranslatedZones, elf2TranslatedZones, leastZones))
                {
                    sum++;
                }
                if(CheckOverlappingZones(elf1TranslatedZones, elf2TranslatedZones))
                {
                    sum2++;
                }

            }
            Console.WriteLine("Sum1: " + sum);
            Console.WriteLine("Sum2: " + sum2);
        }
    }
    catch (IOException e)
    {
        Console.WriteLine("The file could not be read:");
        Console.WriteLine(e.Message);
    }
}

int [] TranslateZones(int[] elf)
{
    int[] translatedZones = new int[100];
    Array.Fill(translatedZones, 0);
    for (int i = elf[0]; i <= elf[1]; i++)
    {
        translatedZones[i] = 1;
    }
    return translatedZones;
}

bool CheckZones(int[] elf1TranslatedZones, int[] elf2TranslatedZones, int leastZones )
{
    int counter = 0;
    for(int i = 0 ; i < elf1TranslatedZones.Length ; i++)
    {
        if(elf1TranslatedZones[i] == elf2TranslatedZones[i] && elf1TranslatedZones[i] == 1)
        {
            counter++;
        }
    }
    if(counter == leastZones)
    {
        return true;
    }
    
    return false;
}
bool CheckOverlappingZones(int[] elf1TranslatedZones, int[] elf2TranslatedZones)
{
    for (int i = 0; i < elf1TranslatedZones.Length; i++)
    {
        if (elf1TranslatedZones[i] == elf2TranslatedZones[i] && elf1TranslatedZones[i] == 1)
        {
            return true;
        }
    }
    return false;
}