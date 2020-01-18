using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;

namespace DatabaseAccess.UNA.Conexion
{
    public abstract class DbAccess
    {
        public string ConnectionString { get; set; }
        public  DbConnection Connection { get; set; }
        public DbTransaction Transaction { get; set; }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
        public abstract long EjectSQL(string algo);
        //public abstract DataTable QuerySQL(string algo);
        public abstract bool IsTransaction();
        public abstract void CommitTransaction();
        public abstract void RollBackTransaction();
        public abstract void BeginTransaction();

    }
}
