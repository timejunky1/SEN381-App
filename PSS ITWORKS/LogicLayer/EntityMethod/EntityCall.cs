// EntityCall.cs
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PSS_ITWORKS.LogicLayer
{
    class EntityCall : IEntity
    {
        private int Id;
        private int employeeId;
        private int clientId;
        private string clientname;
        private string clientRole;
        private string description;
        private DateTime callTime;

        public EntityCall(int id, int employeeId, int clientId, string clientname, string clientRole, string description, DateTime callTime)
        {
            Id = id;
            this.employeeId = employeeId;
            this.clientId = clientId;
            this.clientname = clientname;
            this.clientRole = clientRole;
            this.description = description;
            this.callTime = callTime;
        }

        public int GetId()
        {
            return Id;
        }

        public int GetEmployeeId()
        {
            return employeeId;
        }

        public int ClientId()
        {
            return clientId;
        }

        public string ClientName()
        {
            return clientname;
        }

        public string ClientRole()
        {
            return clientRole;
        }

        public string GetDescription()
        {
            return description;
        }

        public DateTime DateTime()
        {
            return callTime;
        }

        
    }
}