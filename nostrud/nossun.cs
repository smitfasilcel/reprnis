using System;
using System.Collections.Generic;

public class Route
{
    public List<string> Stops { get; set; }

    public Route()
    {
        Stops = new List<string> { "Station1", "Station2", "Station3" };
    }
}

class Program
{
    static void Main()
    {
        Route def = new Route();
        List<string> stops = def.Stops;

        foreach (var stop in stops)
        {
            Console.WriteLine(stop);
        }
        // Output:
        // Station1
        // Station2
        // Station3
    }
}
