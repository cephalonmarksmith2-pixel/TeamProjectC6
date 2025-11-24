using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProjectC6.Menu_s
{


    public class GenerateRandomRedux
    {

        /// <summary>
        /// Make Random number but 0 to 99
        /// </summary>
        public void generateRandomRedux()// examle of a outside class using a thing from this class
        {
            Random random = new Random();
            int randomDigits = random.Next(00, 99);
            Console.WriteLine($"Generated Random Number: {randomDigits}");
        }
    }
}
    