using Oracle.ManagedDataAccess.Client;
using OracleBpm.Features.Data.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;


namespace OracleBpm.Features.Data.EntityConifg
{
    //https://thiagoborges.net.br/oracle-no-net-core/
    public class FeatureDataBase : IDatabaseHandler
    {
        private string _connectionString { get; set; }

        public FeatureDataBase(string connectionstring)
        {
            _connectionString = connectionstring;
        }

        public IDbConnection CreateConnection()
        {
            return new OracleConnection(_connectionString);
        }

        public void ClosedConnection(IDbConnection connection)
        {
            var oracleConnection = (OracleConnection)connection;
            oracleConnection.Close();
            oracleConnection.Dispose();      
        }

        public IDbCommand CreateCommand(string commandText, CommandType commandType, IDbConnection connection)
        {
            return new OracleCommand
            {
                CommandText = commandText,
                Connection = (OracleConnection)connection,
                CommandType = commandType
            };            
        }

        public IDataAdapter CreateAdapter(IDbCommand command)
        {
            return new OracleDataAdapter((OracleCommand)command);
        }      

        public IDataParameter CreateParameter(IDbCommand command)
        {
            OracleCommand SQLcommand = (OracleCommand)command;
            return SQLcommand.CreateParameter();
        }
    }
}
