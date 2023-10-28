﻿// StrategyContractManager.cs
using Microsoft.SqlServer.Server;
using PSS_ITWORKS.LogicLayer;
using System;
using System.Data;
using System.Diagnostics.Contracts;
using System.Windows.Forms;

namespace PSS_ITWORKS
{
    class StrategyContractManager : IStrategyAManagement
    {
        DatabaseAPI api = new DatabaseAPI();
        public BindingSource Get()
        {
            return api.GetContracts();
        }

        public void Create(IEntity entity)
        {
            try
            {
                EntityContract contract = entity as EntityContract;
                api.CreateContract(contract);
                foreach (EntityService service in contract.GetServices())
                {
                    api.AddContractRef(service.GetId());
                }
            }catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
            
        }

        public void Delete(int ID, string s = "")
        {
            api.DeleteContract(ID);
            api.DeleteContractRef(ID,0);
        }

        public void Update(IEntity entity)
        {
            try
            {
                EntityContract contract = entity as EntityContract;
                api.UpdateContract(contract);
                api.DeleteContractRef(contract.GetId(),0);
                foreach (EntityService service in contract.GetServices())
                {
                    api.AddContractRef(contract.GetId(), service.GetId());
                }
            }
            catch(Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
        }

        public void Connect(string connString)
        {
            api.SetConnection(connString);
        }

        public BindingSource Get(int ID)
        {
            return api.GetClientAndContractInfo(ID);
        }

        public BindingSource GetSpecific(int id1 = 0, int id2 = 0, string s1 = "", string s2 = "")
        {
            BindingSource bs = api.GetContractStats(id1, id2, s1);
            BindingSource result = new BindingSource();
            foreach(DataRow row in bs)
            {
                foreach(SqlDataRecord r in row);
                    ;
                result.Add(row);
            }
        }

        public BindingSource GetSpecific1(string s1)
        {
            throw new NotImplementedException();
        }

        public BindingSource GetSpecific2(string s2)
        {
            throw new NotImplementedException();
        }

        public BindingSource GetSpecific1(int n1)
        {
            throw new NotImplementedException();
        }

        public BindingSource GetSpecific2(int n1)
        {
            throw new NotImplementedException();
        }
    }
}