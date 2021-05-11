using System;

namespace InterfacesAndExtensibility
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger("/Users/jay/Desktop/log.txt"));
            dbMigrator.Migrate();
        }
    }
}
