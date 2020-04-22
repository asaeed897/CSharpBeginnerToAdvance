using System;

namespace CSharpIntermediate
{
    public class DbCommand
    {
        private readonly string _instruction;
        private readonly DbConnection _dbConnection;

        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if (string.IsNullOrWhiteSpace(instruction))
            {
                throw new ArgumentNullException("instruction");
            }
            _instruction = instruction;
            this._dbConnection = dbConnection ?? throw new ArgumentNullException("DbConnection");
            
        }

        public void Execute()
        {
            _dbConnection.Open();
            Console.WriteLine("Run: {0}",_instruction);
            _dbConnection.Close();
        }
    }
}