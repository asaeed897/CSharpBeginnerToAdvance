using System.Collections;
using System.Collections.Generic;

namespace CSharpIntermediate
{
    class Program
    {

        static void Main(string[] args)
        {
            var instruction = "create a table Student";
            var sqlConnection = new SqlConnection("Build a connection");
            var oracleConnection = new OracleConnection("Build a connection");
            var dbCommand = new DbCommand(sqlConnection, instruction);
            dbCommand.Execute();
            dbCommand = new DbCommand(oracleConnection,instruction);
            dbCommand.Execute();

            // 31 and 32 Summary & Exercise
        }
    }
}
