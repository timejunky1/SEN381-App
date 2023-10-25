﻿// EntityJob.cs
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PSS_ITWORKS.LogicLayer
{
    class EntityJob : IEntity
    {
        private int Id;
        private int clientId;
        private int serviceId;
        private DateTime timeBegin;
        private DateTime timeEnd;
        private string status;
        private string notes;
        List<EntityUser> employees;
        List<EntityCall> calls;

        public EntityJob(int id, int clientId, int serviceId, DateTime timeBegin, DateTime timeEnd, string status, string notes)
        {
            Id = id;
            this.clientId = clientId;
            this.serviceId = serviceId;
            this.timeBegin = timeBegin;
            this.timeEnd = timeEnd;
            this.status = status;
            this.notes = notes;
        }

        public EntityJob(int id, int clientId, int serviceId, DateTime timeBegin, DateTime timeEnd, string status, string notes, List<EntityUser> employees)
        {
            Id = id;
            this.clientId = clientId;
            this.serviceId = serviceId;
            this.timeBegin = timeBegin;
            this.timeEnd = timeEnd;
            this.status = status;
            this.notes = notes;
            this.employees = employees;
        }

        public EntityJob(int clientId, int serviceId, string notes)
        {
            this.clientId = clientId;
            this.serviceId = serviceId;
            this.notes = notes;
        }

        public EntityJob(int jobId, string notes, string status)
        {
            this.Id = jobId;
            this.status = status;
            this.notes = notes;
        }

        public int GetId()
        {
            return Id;
        }

        public int GetClientId()
        {
            return clientId;
        }

        public int GetServiceId()
        {
            return serviceId;
        }

        public DateTime GetTimeBegin()
        {
            return timeBegin;
        }

        public DateTime GetTimeEnd()
        {
            return timeEnd;
        }

        public string GetStatus()
        {
            return status;
        }

        public string GetNotes()
        {
            return notes;
        }

        public List<EntityUser> GetEmployees()
        {
            return employees;
        }

        public List<EntityCall> GetCalls()
        {
            return calls;
        }
    }
}
