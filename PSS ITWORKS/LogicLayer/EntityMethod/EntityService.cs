// EntityService.cs
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PSS_ITWORKS.LogicLayer
{
    class EntityService : IEntity
    {
        private int Id;
        private string title;
        private int duration;
        private int priority;
        private decimal cost;
        private string availability;
        List<EntityContract> contracts;

        public EntityService(int id, string title, int duration, int priority, decimal cost, string availability)
        {
            Id = id;
            this.title = title;
            this.duration = duration;
            this.priority = priority;
            this.cost = cost;
            this.availability = availability;
        }

        public void SetContracts(List<EntityContract> contracts)
        {
            this.contracts = contracts;
        }

        public List<EntityContract> GetContracts()
        {
            return this.contracts;
        }

        public int GetId()
        {
            return Id;
        }

        public string GetTitle()
        {
            return title;
        }

        public int GetDuration()
        {
            return duration;
        }

        public int GetPriority()
        {
            return priority;
        }

        public decimal GetCost()
        {
            return cost;
        }

        public string GetAvailability()
        {
            return availability;
        }

        public List<EntityContract> GetContracts()
        {
            return contracts;
        }
    }
}
