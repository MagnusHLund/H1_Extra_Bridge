namespace H1_Extra_Bridge
{
    internal class Program
    {
        /// <summary>
        /// Calls the controller and gets out of static.
        /// </summary>
        static void Main()
        {
            new Controller.Controller().Start();
        }
    }
}