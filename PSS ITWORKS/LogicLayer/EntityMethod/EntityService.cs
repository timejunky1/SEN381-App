﻿// EntityService.cs
using System;
using System.Data.SqlClient;

namespace PSS_ITWORKS.LogicLayer
{
    class EntityService : IEntity
    {
        private int Id;
        private string title;
        private string duration;
        private string priority;
        private decimal cost;
        private string availability;

        public EntityService(int id, string title, string duration, string priority, decimal cost, string availability)
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

        public string GetDuration()
        {
            return duration;
        }

        public string GetPriority()
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