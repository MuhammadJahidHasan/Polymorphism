namespace Polymorphisom
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string ConnectionString) :base(ConnectionString)
        {
            
        }
        public override void ClosingConnection()
        {
           System.Console.WriteLine("Closing the oracle connection");
        }

        public override void Execute(string dbCommand)
        {
            System.Console.WriteLine("Command: {0}",dbCommand);
        }

        public override void OpeningConnection()
        {
            System.Console.WriteLine("opening the oracle connection");
        }
    }
}
