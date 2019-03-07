using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 2 - Da se analizira programata za formatiranje na Dates dadena vo Dates.cs fajlot na Github G1. 
            //Istata da se stavi vo konzolna aplikacija i posle izvrshuvanje da se popolnat praznite komentari.

            //Create datetime            
            DateTime dt = new DateTime(2018, 02, 21, 18, 50, 23, 230);

            //Example how it looks like in the output
            var t = String.Format("{0:t}", dt); // "6:50 PM"

            Console.WriteLine(t);
            var d = String.Format("{0:d}", dt); // "21.02.2018"
            Console.WriteLine(d);
            var T = String.Format("{0:T}", dt); // "6:50:23 PM"
            Console.WriteLine(T);
            var D = String.Format("{0:D}", dt); // "Wednesday, February 21, 2018"
            Console.WriteLine(D);
            var f = String.Format("{0:f}", dt); // "Wednesday, February 21, 2018 6:50 PM"
            Console.WriteLine(f);
            var F = String.Format("{0:F}", dt); // "Wednesday, February 21, 2018 6:50:23 PM"
            Console.WriteLine(F);
            var g = String.Format("{0:g}", dt); // "21.02.2018 6:50 PM"
            Console.WriteLine(g);
            var G = String.Format("{0:G}", dt); // "21.02.2018 6:50:23 PM"
            Console.WriteLine(G);
            var m = String.Format("{0:m}", dt); // "21 February"
            Console.WriteLine(m);
            var y = String.Format("{0:y}", dt); // "February, 2018"
            Console.WriteLine(y);
            var r = String.Format("{0:r}", dt); // "Wednesday, February 21, 2018 6:50:23 PM - GMT"
            Console.WriteLine(r);
            var s = String.Format("{0:s}", dt); // 2018-02-21T6:50:23 PM;
            Console.WriteLine(s);
            var u = String.Format("{0:u}", dt); // 2018-02-21 6:50:23 PMZ;
            Console.WriteLine(u);

            Console.WriteLine("--------------");

            DateTime TimeNow = DateTime.Now;
            DateTime TimeUtc = DateTime.UtcNow;
            DateTime TimeToday = DateTime.Today;
            Console.WriteLine("Current DateTime: {0} ", TimeNow);  	// Indicates the current DateTime Today - 07.03.2019 06:03:40;
            Console.WriteLine("UTC DateTime:     {0} ", TimeUtc); 	// Indicates the UTC DateTime Today - 07.03.2019 05:03:40;
            Console.WriteLine("Today:            {0} ", TimeToday); // Indicates the DateTime Today - 00:00:00;
            Console.WriteLine();

            DateTime yesterday;
            yesterday = TimeNow.AddDays(-1);
            Console.WriteLine("Yesterday: {0}", yesterday);								// Indicates the DateTime yesterday - 06.03.2019 06:03:40
            Console.WriteLine("The day before yesterday {0}", yesterday.TimeOfDay);		// Indicates the DateTime of the day before yesterday - 06:03:40.3338015;
            Console.WriteLine("Minus 2 hours: {0}", TimeNow.AddHours(-2));              // Indicates the DateTime today minus 2 hours - 07.03.2019 04:03:40

            int mDays = DateTime.DaysInMonth(2016, 2);
            Console.WriteLine("Month Feb, 2016 has {0} days.", mDays);							// Indicates how many day the Month of February 2016 had - 29 days; 
            Console.WriteLine("Month Feb, 2018 has {0} days.", DateTime.DaysInMonth(2018, 2));	// Indicates how many day the Month of February 2018 had - 28 days;
        }
    }
}
