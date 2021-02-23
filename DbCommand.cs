using System;

namespace Polymorphisom
{
    public class DbCommand {

         private readonly string _dbCommand;
         private readonly DbConnection _connection;
         public DbCommand(DbConnection connection, string dbCommand)
         {
             if(!string.IsNullOrEmpty(connection.ConnectionString) && 
                !string.IsNullOrEmpty(dbCommand)){

                    this._dbCommand = dbCommand;
                    this._connection = connection;
                }

               else{

                throw 
                new InvalidOperationException("Please provide a valid connection string");
            }  
         }

         public void ExecuteCommand(){
         
               this._connection.OpeningConnection();
               this._connection.Execute(this._dbCommand);
               this._connection.ClosingConnection();
         }

    }
}
