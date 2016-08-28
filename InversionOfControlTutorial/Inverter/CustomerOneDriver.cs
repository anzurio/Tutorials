
using DataStoreDriver;

namespace Inverter
{
    public class CustomerOneDriver : IDriver
    {
        private Connection _connection;

        public CustomerOneDriver(string connectionString)
        {
            _connection = new Connection(connectionString);
        }

        public string GetData()
        {
            return _connection.GetData();
        }
    }
}
