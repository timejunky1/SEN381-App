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
        private int jobId;
        private string clientname;
        private string clientRole;
        private string description;
        private DateTime callTime;

        public EntityCall(int id, int employeeId, int clientId, int jobid, string clientname, string clientRole, string description, DateTime callTime)
        {
            Id = id;
            this.employeeId = employeeId;
            this.clientId = clientId;
            this.jobId = jobid;
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

        public int GetClientId()
        {
            return clientId;
        }

        public string GetClientName()
        {
            return clientname;
        }

        public string GetClientRole()
        {
            return clientRole;
        }

        public string GetDescription()
        {
            return description;
        }

        public DateTime GetcallTime()
        {
            return callTime;
        }

        public int GetJobId()
        {
            return jobId;
        }
    }
}