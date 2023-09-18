using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace H1_Extra_Bridge.Controller
{
    internal class Controller
    {
        View.View view = new();

        // Big int is used so the simulation of vehicles can be over the top, which helps find potential issues for A/S Storebælt
        BigInteger bikes;
        BigInteger cars;
        BigInteger trucks;
        BigInteger busses;

        /// <summary>
        /// This is the entry point for the class, when its called from the main method
        /// </summary>
        public void Start()
        {
            Input();
            calculation();
        }

        /// <summary>
        /// This takes in user input, of how many vehicles are on the bridge.
        /// It has exception handling, incase of user input not being able to convert to big int.
        /// All the code in this method is also wrapped inside a while loop, which only breaks once the program has all the required data for the calculation method.
        /// </summary>
        void Input()
        {
            while (true)
            {
                try
                {
                    view.Message("How many motorcycles are on the bridge?");
                    bikes = BigInteger.Parse(view.Readline());
                    view.Message("How many cars are on the bridge?");
                    cars = BigInteger.Parse(view.Readline());
                    view.Message("How many trucks are on the bridge?");
                    trucks = BigInteger.Parse(view.Readline());
                    view.Message("How many busses are on the bridge?");
                    busses = BigInteger.Parse(view.Readline());
                    break;
                }
                catch
                {
                    view.Message("Only write numbers");
                }
            }
        }

        /// <summary>
        /// Outputs the total number of wheels, to the console, through the view method.
        /// </summary>
        void calculation()
        {
            view.Message("Total wheels:\n" +
            $"{(bikes * 2) + (cars * 4) + (trucks * 4) + (busses * 6)}");
        }
    }
}
