using System;

namespace Polymorphisom
{
    partial class Program
    {
        static void Main(string[] args)
        {
           var sqlConnection = new SqlConnection("sqlConnection");

           var dbCommandforSql = new DbCommand(sqlConnection, "x => x.Id == sqlId");
           dbCommandforSql.ExecuteCommand();

           System.Console.WriteLine();

           var oracleConnection = new OracleConnection("oracleConnection");
         
           var dbCommandforOracle = new DbCommand(oracleConnection, "x => x.Id == oracleId");
           dbCommandforOracle.ExecuteCommand();


          
        }
    }
}
