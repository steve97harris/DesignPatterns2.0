using System;

namespace DesignPatterns._ColourPrototype
{
    public class MainApp
    {
        public static void MainOLD()
        {
            ColourManager colourManager = new ColourManager();
            
            // Initialize standard colours
            colourManager["red"] = new Colour(255,0,0, 0);
            colourManager["green"] = new Colour(0,255,0, 0);
            colourManager["blue"] = new Colour(0,0,255, 0);
            colourManager["yellow"] = new Colour(0,0,0, 255);

            // User inputs personal colours
            colourManager["angry"] = new Colour(255,54,0, 0);
            colourManager["sad"] = new Colour(128,211,128, 0);
            colourManager["flames"] = new Colour(211,34,20, 83);
            colourManager["plants"] = new Colour(0,211,16, 3);

            Colour colourA = colourManager["green"].Clone() as Colour;
            Colour colourB = colourManager["flames"].Clone() as Colour;
            Colour colourC = colourManager["plants"].Clone() as Colour;
            Colour colourD = colourManager["angry"].Clone() as Colour;

            Console.ReadKey();
        }
    }

    public abstract class ColourPrototype
    {
        public abstract ColourPrototype Clone();
    }
}