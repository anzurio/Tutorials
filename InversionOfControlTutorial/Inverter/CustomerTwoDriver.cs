using System;
using ControladorDeDatos;

namespace Inverter
{
    public class CustomerTwoDriver : IDriver
    {
        Conexion _connection;
        public CustomerTwoDriver(string connectionString)
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
