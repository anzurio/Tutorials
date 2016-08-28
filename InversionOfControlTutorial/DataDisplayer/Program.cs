using System;
using Inverter;


/// <summary>
/// The Company's App.
/// </summary>
namespace DataDisplayer
{
    class Program
    {
        static void Main(string[] args)
        {
            // A different version of each application will need to be compiled for each customer.
            IDriver driver = Provider.GetDriver("Customer 2", "protocol:111");

            ProcessData(RetrieveData(driver));

            Console.Read();
        }

        /// <summary>
        /// Method used to display the data.
        /// </summary>
        /// <param name="data">The data to be displayed.</param>
        private static void ProcessData(string data)
        {
            string[] values = data.Split(',');
            foreach (string v in values) Console.WriteLine(v);
        }

        /// <summary>
        /// Retrieves the data from the data store using a Third Party library.
        /// </summary>
        /// <param name="driver">The Third Party class which connects to the data store.</param>
        /// <returns>The data retrieved.</returns>
        private static string RetrieveData(IDriver driver)
        {
            return driver.GetData();
        }
    }
}
