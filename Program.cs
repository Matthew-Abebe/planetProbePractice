using System;
using System.Collections.Generic;

namespace planetsProbes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };

            List<KeyValuePair<string, string>> probeDestinations = new List<KeyValuePair<string, string>>();

            // Add some planet/probe combinations to the list

            probeDestinations.Add(new KeyValuePair<string, string>("Viking 1", "Mars"));
            probeDestinations.Add(new KeyValuePair<string, string>("Mariner 1", "Venus"));
            probeDestinations.Add(new KeyValuePair<string, string>("Voyager 1", "Jupiter"));
            probeDestinations.Add(new KeyValuePair<string, string>("Voyager 1", "Saturn"));

            // Iterate planets

            foreach (string planet in planetList)
            {
                // List to store probes that visited the planet
                List<string> matchingProbes = new List<string>();

                probeDestinations.ForEach(probDest =>
                {

                    if (probDest.Value == planet)
                    {

                        matchingProbes.Add(probDest.Key); //scope
                    }

                    /*
                        Does the current probe's destination
                        match the value of the `planet` variable?
                        If so, add it to the list.
                    */

                    /*
                        Use String.Join(",", matchingProbes) as part of the
                        solution to get the output below. It's the C# way of
                        writing `array.join(",")` in JavaScript.
                    */
                });

                string probes = String.Join(",", matchingProbes);

                Console.WriteLine($"{planet} : {probes}");

            };



        }

    }

}
