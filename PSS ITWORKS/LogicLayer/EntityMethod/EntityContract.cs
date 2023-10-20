// EntityContract.cs
using System;
using System.Data.SqlClient;

namespace PSS_ITWORKS.LogicLayer
{
    class EntityContract : IEntity
    {
        private int Id;
        private string SLA;
        private int duration;
        private float cost;
        private int priority;
        private string availability;

        public EntityContract(int id, string sLA, int duration, float cost, int priority, string availability)
        {
            Id = id;
            SLA = sLA;
            this.duration = duration;
            this.cost = cost;
            this.priority = priority;
            this.availability = availability;
        }

        public int GetId()
        {
            return Id;
        }

        public string GetSLA()
        {
            return SLA;
        }

        public int GetDuration()
        {
            return duration;
        }

        public float GetCost()
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
    }
}
