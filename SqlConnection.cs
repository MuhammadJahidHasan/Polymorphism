namespace Polymorphisom
{
    public class SqlConnection : DbConnection
    {       
        public SqlConnection(string ConnectionString)  
                :base(ConnectionString) {}
       
        public override void ClosingConnection()
        {
            System.Console.WriteLine("Closing the sql Connection");
        }

        public override void Execute(string dbCommand)
        {
           System.Console.WriteLine("Command: {0}",dbCommand);
        }

        public override void OpeningConnection()
        {
            System.Console.WriteLine("Opening the sql connection");
        }
    }
}
