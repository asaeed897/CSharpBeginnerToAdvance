using System;

namespace CSharpIntermediate
{
    public class SqlConnection : DbConnection
    {
        private bool _status;
        public SqlConnection(string connectionString)
            :base(connectionString)
        {
            
        }
        public override void Open()
        {
            if (_status)
            {
                Console.WriteLine("Connection is already open");
            }
            else
            {
                Console.WriteLine("Opening Sql Connection.");
                _status = true;
            }
        }

        public override void Close()
        {
            if (_status)
            {
                Console.WriteLine("Closing Sql Connection.");
                _status = false;
            }
            else
            {
                throw new InvalidOperationException("Before closing a connection you have to open it first.");

            }
        }
    }
}