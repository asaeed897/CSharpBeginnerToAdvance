using System;

namespace CSharpIntermediate
{
    public abstract class DbConnection
    {
        private readonly string _connectionString;
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentException("Null or empty string is not allowed as an Argument.","connectionString");
            }

            this._connectionString = connectionString;
        }

        public abstract void Open();
        public abstract void Close();
    }
}