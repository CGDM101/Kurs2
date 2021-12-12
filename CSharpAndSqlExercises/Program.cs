using System;
using System.Data;

namespace CSharpAndSqlExercises
{
    public class Databas 
    {
        public string ConnectionString { get; set; } = @"Data Source=.\SQLExpress;Integrated Security=true;database={0}";
        public string DatabaseName { get; set; } = "MinDatabas";
        public void ExecuteSql(string sql) { }
        public DataTable GetDataTable(string sql) { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
