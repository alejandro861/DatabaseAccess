using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace DatabaseAccess.UNA.Conexion
{
    public class MySql : DbAccess
    {
        public override void OpenConnection()
        {
            Connection = new MySqlConnection(ConnectionString);
            Connection.Open();
        }
        public override void CloseConnection()
        {
            if(Connection != null)
            {
                Connection.Close();
            }
        }
        public override long EjectSQL(string sql)
        {
            MySqlCommand command = new MySqlCommand(sql, (MySqlConnection)Connection);
            return command.ExecuteNonQuery();
        }
        //public override DataTable QuerySQL(string algo)
        //{
            
        //}
        public override bool IsTransaction()
        {
            if (Transaction != null)
            {
                return true;
            }
            return false;
        }
        public override void CommitTransaction()
        {
            if (Transaction != null)
            {
                Transaction.Commit();
            }
        }
        public override void RollBackTransaction()
        {
            if(Transaction != null)
            {
                Transaction.Rollback();
            }
        }
        public override void BeginTransaction()
        {
            Connection.BeginTransaction();
        }
    }
}
