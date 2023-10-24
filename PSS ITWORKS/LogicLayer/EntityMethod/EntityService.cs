// EntityService.cs
using System;
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

        public EntityService(int id, string title, int duration, int priority, decimal cost, string availability)
        {
            Id = id;
            this.title = title;
            this.duration = duration;
            this.priority = priority;
            this.cost = cost;
            this.availability = availability;
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
    }
}
