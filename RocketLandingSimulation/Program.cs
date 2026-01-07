int count = 10;
for (int x = 0; x < count; x++)
{
    // clear console at the start
    Console.Clear();

    // top line
    for (int y = 0; y <= x; y++)
    {
        Console.WriteLine("");
    }

    // main rocket
    Console.WriteLine("\t/ \\");
    Console.WriteLine("\t| |");    
    Console.WriteLine("\t| |");    
    Console.WriteLine("\t| |");    
    Console.WriteLine("\t| |");    
    Console.WriteLine("\t/ \\");

    // for bot line (will skipped at last iteration x = 9)
    for (int y = count-1; y > x; y--)
    {
        Console.WriteLine("");
    }
    Console.Write("==================================================");

    // if its at landing spot
    if (x == count-1)
    {
        Console.Write(" Landed Success!");
        Console.ReadKey();
    }
    // if not in landing spot yet
    else
    {
        Thread.Sleep(600);
    }
}

