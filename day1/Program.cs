
// See https://aka.ms/new-console-template for more information
try
{
    using (var sr = new StreamReader("../../../input.txt"))
    {
        int maxInt = 0;
        int maxIndex = 0;
        int maxIntTemp = 0;
        List<int> maxCalories = new List<int>();
        int i = 0;
        while (!sr.EndOfStream)
        {
            var calories = sr.ReadLine();
            if (!string.IsNullOrEmpty(calories))
            {
               maxIntTemp = maxIntTemp + int.Parse(calories);
               
            }
            else
            {
                if(maxIntTemp > maxInt)
                {
                    maxInt = maxIntTemp;
                    maxIndex = i;
                }
                if (maxCalories.Count == 3)
                {
                    var low = maxCalories.Min();
                    
                    if(low < maxIntTemp)
                        maxCalories[maxCalories.FindIndex(x => x == low)]= maxIntTemp;
                }
                else
                {
                    maxCalories.Add(maxIntTemp);
                }

                i++;
                maxIntTemp = 0;
            }
        
        }
        Console.WriteLine("Max calories: " + maxInt.ToString() + " By elf: " + (maxIndex + 1).ToString() + " Max calories top 3: " + maxCalories.Sum());
    }
}
catch (IOException e)
{
    Console.WriteLine("The file could not be read:");
    Console.WriteLine(e.Message);
}
