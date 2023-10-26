// EntityClient.cs
using System;
using System.Data.SqlClient;

namespace PSS_ITWORKS.LogicLayer
{
    class EntityUser : IEntity
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

        public EntityUser(int id, string companyName, string name, string surname, int contractId, int streetNumber, string streetName, string city, string province, string zipCode, string phone, string email, DateTime contractInitiationDate, string role)
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
        public EntityUser(int id, string name, string surname, string phone,  string email, string role)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.phone = phone;
            this.email = email;
            this.role = role;
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
    }
}
