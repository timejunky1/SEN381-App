// EntityClient.cs
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PSS_ITWORKS.LogicLayer
{
    class EntityEmployee : IEntity
    {
        private int id;
        private string name;
        private string surname;
        private int streetNumber;
        private string streetName;
        private string city;
        private string province;
        private string zipCode;
        private string phone;
        private string email;
        private DateTime contractInitiationDate;
        private string role;
        List<EntityJob> jobs;
        List<EntityCall> calls;

        public EntityEmployee(int id, string name, string surname, int streetNumber, string streetName, string city, string province, string zipCode, string phone, string email, DateTime contractInitiationDate, string role, List<EntityJob> jobs)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.streetNumber = streetNumber;
            this.streetName = streetName;
            this.city = city;
            this.province = province;
            this.zipCode = zipCode;
            this.phone = phone;
            this.email = email;
            this.contractInitiationDate = contractInitiationDate;
            this.role = role;
            this.jobs = jobs;
        }

        public EntityEmployee(int id, string name, string surname, int streetNumber, string streetName, string city, string province, string zipCode, string phone, string email, DateTime contractInitiationDate, string role, List<EntityCall> calls)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.streetNumber = streetNumber;
            this.streetName = streetName;
            this.city = city;
            this.province = province;
            this.zipCode = zipCode;
            this.phone = phone;
            this.email = email;
            this.contractInitiationDate = contractInitiationDate;
            this.role = role;
            this.calls = calls;
        }

        public int GetID()
        {
            return id;
        }

        public string GetName()
        {
            return name;
        }

        public string GetSurname()
        {
            return surname;
        }

        public string GetPhone()
        {
            return phone;
        }

        public string GetEmail()
        {
            return email;
        }

        public DateTime GetContractInitiationDate()
        {
            return contractInitiationDate;
        }

        public int GetStreetNumber()
        {
            return streetNumber;
        }

        public string GetStreetName()
        {
            return streetName;
        }

        public string GetCity()
        {
            return city;
        }

        public string GetProvince()
        {
            return province;
        }

        public string GetZipCode()
        {
            return zipCode;
        }

        public string GetRole()
        {
            return role;
        }

        public List<EntityJob> GetJobs()
        {
            return jobs;
        }

        public List<EntityCall> GetCalls()
        {
            return calls;
        }
    }
}
