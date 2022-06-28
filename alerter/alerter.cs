using System;
using System.Diagnostics;

namespace AlerterSpace {
    class Alerter {
        static float temperatureThreshold = 200;

        static int alertFailureCount = 0;

        static int networkAlertStub(float celcius) {
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

        static int networkAlert(float celcius)
        {
            Console.WriteLine("ALERT: Temperature is {0} celcius", celcius);
            throw new NotImplementedException();
        }

        static float convertToCelcius(float farenheit)
        {
            float celcius = (farenheit - 32) * 5 / 9;
            return celcius;
        }

        static void alertInCelcius(float farenheit, Func<float, int> networkAlert) {
            float celcius = convertToCelcius(farenheit);
            int returnCode = networkAlert(celcius);
            if (returnCode != 200) {
                // non-ok response is not an error! Issues happen in life!
                // let us keep a count of failures to report
                // However, this code doesn't count failures!
                // Add a test below to catch this bug. Alter the stub above, if needed.
                alertFailureCount += 0;
            }
        }

        static void Main(string[] args) {
            alertInCelcius(400.5f, networkAlertStub);
            alertInCelcius(303.6f, networkAlertStub);
            Debug.Assert(alertFailureCount != 0);
            Console.WriteLine("{0} alerts failed.", alertFailureCount);
            Console.WriteLine("All is well (maybe!)\n");
        }
    }
}
