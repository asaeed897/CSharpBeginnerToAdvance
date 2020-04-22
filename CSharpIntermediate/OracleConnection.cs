using System;

namespace CSharpIntermediate
{
    public class OracleConnection : DbConnection
    {
        private bool _status;
        public OracleConnection(string connectionString)
            :base(connectionString)
        {
            
        }

        public override void Open()
        {
            if(_status)
            {
                Console.WriteLine("Connection is already is open.");
                
            }
            else
            {
                Console.WriteLine("Opening Oracle Connection.");
                _status = true;
            }
        }

        public override void Close()
        {
            if (_status)
            {
                Console.WriteLine("Closing Oracle Connection.");
                _status = false;
            }
            else
            {
                throw new InvalidOperationException("Before closing a connection you have to open it first.");
            }
        }
    }
}