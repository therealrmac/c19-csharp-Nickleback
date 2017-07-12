using System;
using System.Collections.Generic;
using System.Linq;

namespace nickelback
{
    class Program
    {
        static void Main(string[] args)
        {
           List<(string, string)> goodSongs= new List<(string, string)>();

           HashSet<(string, string)> allSongs= new HashSet<(string, string)>();
           allSongs.Add(("Michael Jackson", "Black or White"));
           allSongs.Add(("Nickleback", "Someday"));
           allSongs.Add(("Nickleback", "Photograph"));
           allSongs.Add(("Black Tongue", "Waste"));
           allSongs.Add(("Born of Osiris", "Follow The Signs"));
           allSongs.Add(("After The Burial", "Lost in The Static"));
           allSongs.Add(("Chon", "Splash"));

           foreach(var x in allSongs){
               if(x.Item1!="Nickleback"){
                    goodSongs.Add((x));
               } 
           }
           foreach(var y in goodSongs){
               Console.WriteLine($"{y.Item1} - {y.Item2}");
           }
        }
    }
}
