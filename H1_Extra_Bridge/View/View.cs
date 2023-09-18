using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Extra_Bridge.View
{
    internal class View
    {
        /// <summary>
        /// Returns the console.readline to wherever this method gets called from
        /// </summary>
        /// <returns></returns>
        public string Readline()
        {
            return Console.ReadLine();
        }

        /// <summary>
        /// Outputs a custom message based on the string parameter
        /// </summary>
        /// <param name="message"></param>
        public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}
