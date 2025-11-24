using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProjectC6.Menu_s
{
    /// <summary>
    /// basic menu structure for a student menu 
    /// </summary>
    public class ExampleMenue : Menu
    {
        private readonly GenerateRandomRedux _randomGenerator; // global useage for this class
        /// <summary>
        /// this code is incompleat but it is a basic structure for a student menu
        /// i want it to be able to accses ...
        /// and i want it do...
        /// </summary>
        public ExampleMenue()
        {
            _randomGenerator = new GenerateRandomRedux(); // calling it in specific class its used 
            AddItem("View random number", generateRandom);
            AddItem("Submit Assignment", () => Console.WriteLine("Assignment submitted."));
            AddItem("View Timetable", () => Console.WriteLine("Timetable: Mon-Fri"));
            AddItem("Second Random number", () =>
            {
                _randomGenerator.generateRandomRedux();
            });
            
        }

        /// <summary>
        /// Make Random number
        /// 
        /// 
        /// </summary>
        public void generateRandom() 
        {
            Random random = new Random();
            int randomDigits = random.Next(10000, 99999);
            Console.WriteLine($"Generated Random Number: {randomDigits}");
        }


      
    }
}
