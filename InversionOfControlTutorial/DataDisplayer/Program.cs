﻿using System;
using DataStoreDriver;

/// <summary>
/// The Company's App.
/// </summary>
namespace DataDisplayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Connection driver = new Connection("192.0.0.1");
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
        private static string RetrieveData(Connection driver)
        {
            return driver.GetData();
        }
    }
}
