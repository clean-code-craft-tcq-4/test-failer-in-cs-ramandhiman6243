using System;

namespace AlerterSpace
{
    public class NetworkAlertStub
    {
        static float temperatureThreshold = 200;
     
        public static int networkAlertStub(float celcius)
        {
            Console.WriteLine("ALERT: Temperature is {0} celcius", celcius);
            // Return 200 for ok
            // Return 500 for not-ok
            // stub always succeeds and returns 200

            if (celcius > temperatureThreshold)
            {
                return 500;
            }
            else
            {
                return 200;
            }
        }
    }
}
