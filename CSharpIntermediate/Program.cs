namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new ConsoleLogger());
            dbMigrator.Migrator();

            var dbMigrator1 = new DbMigrator(new FileLogger(@"C:\Users\awais\Downloads\Video\CSharp Intermediate\Section 6 Interfaces\Log.txt"));
            dbMigrator1.Migrator();
            // check interface.... 

            // 36 Interface are Not for Multiple Inheritance
        }
    }
}
