// EntityJob.cs
using System;
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

        public int GetId()
        {
            return Id;
        }

        public int GetClientId()
        {
            return clientId;
        }

        public int ServiceId()
        {
            return serviceId;
        }

        public DateTime TimeBegin()
        {
            return timeBegin;
        }

        public DateTime TimeEnd()
        {
            return timeEnd;
        }

        public string Status()
        {
            return status;
        }

        public string Notes()
        {
            return notes;
        }
    }
}
