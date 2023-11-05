// EntityContract.cs
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PSS_ITWORKS.LogicLayer
{
    class EntityContract : IEntity
    {
        private int id;
        private string title;
        private string SLA;
        private int duration;
        private decimal cost;
        private int priority;
        private string availability;
        List<EntityService> services;
        List<EntityClient> clients;

        public EntityContract(int id, string title, string sLA, int duration, decimal cost, int priority, string availability)
        {
            this.id = id;
            SLA = sLA;
            this.duration = duration;
            this.cost = cost;
            this.priority = priority;
            this.availability = availability;
            this.title = title;
        }

        public void SetClients(List<EntityClient> clients)
        {
            this.clients = clients;
        }

        public List<EntityClient> GetClients()
        {
            return this.clients;
        }
        public List<EntityService> GetServices()
        {
            return services;
        }
        public void SetServices(List<EntityService> services)
        {
            this.services = services;
        }
        
        public int GetId()
        {
            return id;
        }

        public string GetSLA()
        {
            return SLA;
        }

        public int GetDuration()
        {
            return duration;
        }

        public decimal GetCost()
        {
            return cost;
        }

        public int GetPriority()
        {
            return priority;
        }

        public string GetAvailability()
        {
            return availability;
        }

        public string GetTitle()
        {
            return title;
        }
    }
}
