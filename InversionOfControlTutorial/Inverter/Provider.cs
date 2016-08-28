using DataStoreDriver;
using ControladorDeDatos;

namespace Inverter
{
    public class Provider
    {
        public static IDriver GetDriver(string type, string connectionString)
        {
            if (type == "Customer 1")
                return new CustomerOneDriver(connectionString);
            if (type == "Customer 2")
                return new CustomerTwoDriver(connectionString);

            // Not the best way to do this but for now, should work.
            return null;
        }

    }
}
