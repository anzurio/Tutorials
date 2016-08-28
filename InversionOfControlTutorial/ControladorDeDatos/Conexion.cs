/// <summary>
/// A third party library to access the Customer 2's Data Store
/// </summary>
namespace ControladorDeDatos
{
    /// <summary>
    /// The main class uses to access the data.
    /// </summary>
    public class Conexion
    {
        string _protocol;
        string _address;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="protocol">The protocol of the data store (e.g., mongodb).</param>
        /// <param name="address">The address of the data store.</param>
        public Conexion(string protocol, string address)
        {
            _protocol = protocol;
            _address = address;
        }

        /// <summary>
        /// Method used to retrieve data from the data store.
        /// </summary>
        /// <param name="data">The data retrieved.</param>
        public void ObtenerDatos(out string data)
        {
            data = _protocol + _address + ",uno,dos,tres";
        }
    }
}
