using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._singletons
{
    public class Logger
    {
        // private static Logger logger;
        private static Logger instance;

        private Logger()
        {

        }

        public static Logger Instance
        {
            get        // Get, defines an accessor method in a property or indexer that returns the property value or the indexer element. (See example class TimePeriod below).
            {
                if (instance == null) 
                {
                    instance = new Logger();
                }
                return instance;        // Return, terminates execution of the method in which it appears and returns control to the calling method. 
            }
        }

        // public static Logger GetInstance()
        // {
        //     if (logger == null)
        //     {
        //         logger = new Logger();
        //     }
        //     return logger;
        // }
    }

    // class TimePeriod
    // {
    //     private double seconds;
    //     public double Seconds
    //     {
    //         get { return seconds; }
    //         set { seconds = value; }
    //     }
    // }
}