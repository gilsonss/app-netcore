using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace OracleBpm.Features.Data.Context
{
   public interface IDatabaseHandler
    {
        IDbConnection CreateConnection();

        void ClosedConnection(IDbConnection connection);
        IDbCommand CreateCommand(string commandText, CommandType commandType, IDbConnection connection);
        IDataAdapter CreateAdapter(IDbCommand command);
        IDataParameter CreateParameter(IDbCommand command);
    }
}
