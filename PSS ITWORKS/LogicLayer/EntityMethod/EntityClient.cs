// EntityClient.cs
using System;
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

        public EntityClient(
            string companyName, 
            string personName, 
            string personSurname, 
            int contractId, 
            string phone,
            string email,
            DateTime contractInitiationDate,
            int streetNumber,
            string streetName,
            string city,
            string province,
            string zipCode
            )
        {
            this.companyName = companyName;
            this.name = personName;
            this.surname = personSurname;
            this.contractId = contractId;
            this.phone = phone;
            this.email = email;
            this.contractInitiationDate = contractInitiationDate;
            this.streetNumber = streetNumber;
            this.streetName = streetName;
            this.city = city;
            this.province = province;
            this.zipCode = zipCode;
            this.role = "Client";
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
