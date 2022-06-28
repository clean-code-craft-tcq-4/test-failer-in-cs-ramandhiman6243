using System;
using System.Diagnostics;

namespace AlerterSpace
{
    class Alerter
    {
        static int alertFailureCount = 0;

        static void alertInCelcius(float farenheit, Func<float, int> networkAlert)
        {
            float celcius = TemperatureConverter.convertToCelcius(farenheit);
            int returnCode = networkAlert(celcius);
            if (returnCode != 200)
            {
                // non-ok response is not an error! Issues happen in life!
                // let us keep a count of failures to report
                // However, this code doesn't count failures!
                // Add a test below to catch this bug. Alter the stub above, if needed.
                alertFailureCount++;
            }
        }

        static void Main(string[] args)
        {
            alertInCelcius(400.5f, NetworkAlertStub.networkAlertStub);
            alertInCelcius(303.6f, NetworkAlertStub.networkAlertStub);
            Debug.Assert(alertFailureCount == 1);
            Console.WriteLine("{0} alerts failed.", alertFailureCount);
            Console.WriteLine("All is well (maybe!)\n");
        }
    }
}