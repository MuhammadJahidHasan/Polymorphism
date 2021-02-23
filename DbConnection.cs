using System;

namespace Polymorphisom
{
    public abstract class  DbConnection {
        public string ConnectionString { get; private set; }
        public TimeSpan Timeout { get; set; }

         public DbConnection(string ConnectionString)
        {
            if(!string.IsNullOrEmpty(ConnectionString)){

                this.ConnectionString = ConnectionString;
                //System.Console.WriteLine(ConnectionString);
            }

            else{

                throw 
                new InvalidOperationException("Please provide a valid connection string");
            }
        }

        public abstract void OpeningConnection();

         public abstract void ClosingConnection();

         public abstract void Execute(string dbCommand);


        
    }
}
