using System;
using Oracle.ManagedDataAccess.Client;
using OracleBpm.Features.Contract;
using OracleBpm.Features.Data.EntityConifg;
using System.Collections.Generic;
using System.Data;

using OracleBpm.Features.Domain.Entities;

namespace OracleBpm.Features.Data.Repositorys
{
    public class FeatureRoleRepository : IFeatureBaseRepository<EntityRole>, IFeatureRole
    {

       private static readonly string connectinString = "Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = NB-GILSON)(PORT = 1521)))(CONNECT_DATA = (SID = xe))); Persist Security Info=True;User ID = system; Password=1234;Pooling=True;Connection Timeout = 60;";
      
       FeatureDataBase _featureDataBase = new FeatureDataBase(connectinString);

        public void AddFeature(EntityRole entityFeatuare)
        {
            var connection = _featureDataBase.CreateConnection();
            connection.Open();
            var sqlcommand = "INSERT INTO TBL_SLC VALUES(220,'SINISTRO PREDIAL')";
            _featureDataBase.CreateCommand(sqlcommand,CommandType.Text, connection).ExecuteNonQuery();
            _featureDataBase.ClosedConnection(connection);
        }

        public IList<EntityRole> ListFeature()
        {
            var connection = _featureDataBase.CreateConnection();
            List<EntityRole> ListentityRoles = new List<EntityRole>();
            connection.Open();
            string sqlCommad = "SELECT CDG_SEG_SLC, DES_SLC FROM TBL_SLC";
            IDataReader list = _featureDataBase.CreateCommand(sqlCommad, CommandType.Text, connection).ExecuteReader();

           var reader = (OracleDataReader)list;

            if (reader.HasRows)
            {                
                while (reader.Read())
                {
                    ListentityRoles.Add(new EntityRole
                    {
                        CodigoRole = Convert.ToInt32(reader["CDG_SEG_SLC"]),
                        DescricaoRole = reader["DES_SLC"].ToString()
                    }); ;
                }              
                              
            }

            _featureDataBase.ClosedConnection(connection);

            return ListentityRoles;
        }

        public void RemoveFeature(EntityRole entityFeatuare)
        {
            var connection = _featureDataBase.CreateConnection();
            connection.Open();
            var sqlcommand = "DELETE FROM TBL_SLC WHERE CDG_SEG_SLC=220";
            _featureDataBase.CreateCommand(sqlcommand, CommandType.Text, connection).ExecuteNonQuery();
            _featureDataBase.ClosedConnection(connection);
        }

        public void UpdateFeature(EntityRole entityFeatuare)
        {
            var connection = _featureDataBase.CreateConnection();
            connection.Open();
            var sqlcommand = "UPDATE TBL_SLC SET DES_SLC ='DADOS ATUALIZADOS 1' WHERE CDG_SEG_SLC=220";
            _featureDataBase.CreateCommand(sqlcommand, CommandType.Text, connection).ExecuteNonQuery();
            _featureDataBase.ClosedConnection(connection);
        }
    }
}
