using Inverter;
using ControladorDeDatos;

namespace CustomerTwoDriver
{
    public class Driver : IDriver
    {
        Conexion _connection;
        public Driver(string connectionString)
        {
            string[] values = connectionString.Split(':');
            if (values.Length == 1)
                _connection = new Conexion("", values[0]);
            else
                _connection = new Conexion(values[0], values[1]);
        }

        public string GetData()
        {
            string data;
            _connection.ObtenerDatos(out data);
            return data;
        }
    }
}
