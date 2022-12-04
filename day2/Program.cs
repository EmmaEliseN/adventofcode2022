calculateFirstScore();
calculateSecondScore();

void calculateFirstScore()
{
    try
    {
        using (var sr = new StreamReader("../../../input.txt"))
        {
            int score = 0;
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine().ToString();
                if (line != null)
                {
                    string elf = line.Split(' ')[0];
                    string me = line.Split(' ')[1];

                    switch (elf)
                    {
                        case "A":
                            if (me == "X")
                            {
                                score = score + 1 + 3;
                            }
                            else if (me == "Y")
                            {
                                score = score + 2 + 6;
                            }
                            else if (me == "Z")
                            {
                                score = score + 3;
                            }
                            break;

                        case "B":
                            if (me == "X")
                            {
                                score = score + 1;
                            }
                            else if (me == "Y")
                            {
                                score = score + 2 + 3;
                            }
                            else if (me == "Z")
                            {
                                score = score + 3 + 6;
                            }
                            break;

                        case "C":
                            if (me == "X")
                            {
                                score = score + 1 + 6;
                            }
                            else if (me == "Y")
                            {
                                score = score + 2;
                            }
                            else if (me == "Z")
                            {
                                score = score + 3 + 3;
                            }
                            break;

                        default:
                            break;

                    }
                }

            }
            Console.WriteLine("Score 1: " + score.ToString());
        }
    }
    catch (IOException e)
    {
        Console.WriteLine("The file could not be read:");
        Console.WriteLine(e.Message);
    }
}
void calculateSecondScore()
{
    try
    {
        using (var sr = new StreamReader("../../../input.txt"))
        {
            int score = 0;
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine().ToString();
                if (line != null)
                {
                    string elf = line.Split(' ')[0];
                    string me = line.Split(' ')[1];

                    switch (elf)
                    {
                        case "A":
                            if (me == "X")
                            {
                                score = score + 3 + 0;
                            }
                            else if (me == "Y")
                            {
                                score = score + 1 + 3;
                            }
                            else if (me == "Z")
                            {
                                score = score + 2 + 6;
                            }
                            break;

                        case "B":
                            if (me == "X")
                            {
                                score = score + 1 + 0;
                            }
                            else if (me == "Y")
                            {
                                score = score + 2 + 3;
                            }
                            else if (me == "Z")
                            {
                                score = score + 3 + 6;
                            }
                            break;

                        case "C":
                            if (me == "X")
                            {
                                score = score + 2 + 0;
                            }
                            else if (me == "Y")
                            {
                                score = score + 3  + 3;
                            }
                            else if (me == "Z")
                            {
                                score = score + 1 + 6;
                            }
                            break;

                        default:
                            break;

                    }
                }

            }
            Console.WriteLine("Score 2: " + score.ToString());
        }
    }
    catch (IOException e)
    {
        Console.WriteLine("The file could not be read:");
        Console.WriteLine(e.Message);
    }
}
