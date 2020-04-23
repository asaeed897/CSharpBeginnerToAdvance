using System;

namespace CSharpIntermediate
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrator()
        {
            _logger.LogInfo("Migrating started at " + DateTime.Now);

            //Details of migrating the database

            _logger.LogInfo("Migrating finished at " + DateTime.Now);
        }
    }
}