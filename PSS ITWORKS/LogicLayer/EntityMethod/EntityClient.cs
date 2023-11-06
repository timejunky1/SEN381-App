// EntityClient.cs
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PSS_ITWORKS.LogicLayer
{
    class EntityClient : IEntity
    {
        private int id;
        private string companyName;
        private string name;
        private string surname;
        private int contractId;
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

        public EntityClient(int id, string companyName, string name, string surname, string role, int contractId, string phone, string email, DateTime contractInitiationDate, int streetNumber, string streetName, string city, string province, string zipCode)
        {
            this.id = id;
            this.companyName = companyName;
            this.name = name;
            this.surname = surname;
            this.contractId = contractId;
            this.streetNumber = streetNumber;
            this.streetName = streetName;
            this.city = city;
            this.province = province;
            this.zipCode = zipCode;
            this.phone = phone;
            this.email = email;
            this.contractInitiationDate = contractInitiationDate;
            this.role = role;
        }

        public void SetJobs(List<EntityJob> jobs)
        {
            this.jobs = jobs;
        }

        public void SetCalls(List<EntityCall> calls)
        {
            this.calls = calls;
        }

        public int GetID()
        {
            return id;
        }

        public string GetCompanyName()
        {
            return companyName;
        }

        public string GetName()
        {
            return name;
        }

        public string GetSurname()
        {
            return surname;
        }

        public int GetContractId()
        {
            return contractId;
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
