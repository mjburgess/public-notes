using System;
using System.Collections.Generic;

class Solution11_1
{

    public static void Solution()
    {

        //ARRAYS

        string[] countries = {
             "United Kingdom",
             "Iran",
             "Germany"
        };


        long[] pops = {
             65000000,
             50000000,
             75000000
        };

        string[] europe = {
             "United Kingdom",
             "France",
             "Spain"
        };

        for (int i = 0; i < countries.Length; i++)
        {
            Console.WriteLine(countries[i]);
            Console.WriteLine(pops[i]);
        }



        //LISTS
        //countries.ToList()
        List<string> countrieList = new List<string>(countries);

        foreach (var euro in europe)
        {
            countrieList.Add(euro);
        }


        countrieList.RemoveRange(0, 2);



        // DICTIONARIES
        Dictionary<string, long> populations = new Dictionary<string, long>();

        for (int i = 0; i < countries.Length; i++)
        {
            populations[countries[i]] = pops[i];
        }



        foreach (var unique in new HashSet<string>(countries))
        {
            Console.WriteLine(unique);
        }



    }


    Dictionary<string, long> MapPopulation(string[] countries, long[] pops)
    {
        Dictionary<string, long> populations = new Dictionary<string, long>();

        for (int i = 0; i < countries.Length; i++)
        {
            populations[countries[i]] = pops[i];
        }

        return populations;
    }
}