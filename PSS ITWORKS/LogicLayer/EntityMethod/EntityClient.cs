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
            // Implement the logic to retrieve and return a list of EntityCall objects
            // associated with this client.
            // For example, you may fetch the calls from your data source.

            List<EntityCall> clientCalls = new List<EntityCall>();

            // Replace this with your actual data retrieval logic

            return clientCalls;
        }

        public string GetStatus(List<EntityJob> jobs)
        {
            // Initialize counters for each status
            int finishedCount = 0;
            int cancelledCount = 0;
            int pendingCount = 0;

            // Loop through the jobs and count them by status
            foreach (EntityJob job in jobs)
            {
                if (job.GetStatus().Equals("Finished", StringComparison.OrdinalIgnoreCase))
                {
                    finishedCount++;
                }
                else if (job.GetStatus().Equals("Cancelled", StringComparison.OrdinalIgnoreCase))
                {
                    cancelledCount++;
                }
                else if (job.GetStatus().Equals("Pending", StringComparison.OrdinalIgnoreCase))
                {
                    pendingCount++;
                }
            }

            // Determine the overall status based on the counts
            if (finishedCount > 0)
            {
                return "Finished";
            }
            else if (cancelledCount > 0)
            {
                return "Cancelled";
            }
            else if (pendingCount > 0)
            {
                return "Pending";
            }
            else
            {
                return "Unknown"; // You can use a different string or handle this case as needed
            }
        }
    }
}
