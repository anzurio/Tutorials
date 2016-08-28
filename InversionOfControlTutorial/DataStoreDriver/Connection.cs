/// <summary>
/// A third party library to access the Customer 1's Data Store
/// </summary>
namespace DataStoreDriver
{
    /// <summary>
    /// The main class uses to access the data.
    /// </summary>
    public class Connection
    {
        private string _connectionString;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="connectionString">The location of the data base.</param>
        public Connection(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// Method used to retrieve data from the data store.
        /// </summary>
        /// <returns>The data retrieved.</returns>
        public string GetData()
        {
            return _connectionString + ",one,two,three";
        }
    }
}
