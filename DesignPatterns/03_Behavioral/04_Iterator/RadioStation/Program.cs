using System;
using System.Linq;

namespace DesignPatterns._03_Behavioral._04_Iterator.RadioStation
{
    public class Program
    {
        static void Main()
        {
            var stations = new StationList();
            var station1 = new RadioStation(95.3f);
            
            stations.Add(station1);
            
            var station2 = new RadioStation(96.8f);
            stations.Add(station2);
            
            var station3 = new RadioStation(104.5f);
            stations.Add(station3);

            foreach (var radioStation in stations)
            {
                Console.WriteLine(radioStation.GetFrequency());
            }

            var q = stations.FirstOrDefault(radioStation => radioStation.GetFrequency() == 96.8f);
            Console.WriteLine(q.GetFrequency());
        }
    }
}