﻿// EntityCall.cs
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
        private DateTime callTime;
        private string description;

        public EntityCall(int id, int employeeId, int clientId, int jobid, DateTime callTime, string description)
        {
            Id = id;
            this.employeeId = employeeId;
            this.clientId = clientId;
            this.jobId = jobid;
            this.callTime = callTime;
            this.description = description;
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