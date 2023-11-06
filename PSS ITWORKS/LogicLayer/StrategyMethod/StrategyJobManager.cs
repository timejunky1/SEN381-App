// StrategyJobManager.cs
using PSS_ITWORKS.LogicLayer;
using PSS_ITWORKS.ServiceLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PSS_ITWORKS
{
    public class StrategyJobManager : IStrategyAManagement
    {
        DatabaseAPI api = new DatabaseAPI();
        SMSAPI sms = new SMSAPI();

        public void Connect(string myString)
        {
            api.SetConnection(myString);
        }

        public void Create(IEntity entity)
        {
            EntityJob job = entity as EntityJob;
            api.InsertJob(job);
        }

        public void Delete(int ID)
        {
            api.DeleteJob(ID);
        }

        public List<IEntity> Get()
        {
            List<EntityJob> jobs = api.GetJobs();
            List<IEntity> entities = new List<IEntity>();
            foreach (EntityJob job in jobs)
            {
                entities.Add(job);
            }
            return entities;
        }

        public IEntity Get(int ID)
        {
            EntityJob job = api.GetJob(ID);
            List<int> employeeIds = api.GetJobEmployeeRef(jobId: ID);
            List<EntityEmployee> jobEmployees = new List<EntityEmployee>();
            foreach (int employeeId in employeeIds)
            {
                jobEmployees.Add(api.GetEmployee(employeeId));
            }
            job.SetEmployees(jobEmployees);
            List<int> callIds = api.GetJobCallRef(jobId: ID);
            List<EntityCall> calls = new List<EntityCall>();
            foreach (int callId in callIds)
            {
                calls.Add(api.GetCall(callId));
            }
            job.SetCalls(calls);
            return job;
        }

        public void Update(IEntity entity)
        {
            EntityJob job = entity as EntityJob;
            EntityClient jobClient = api.GetClient(job.GetClientId());
            EntityService service = api.GetService(job.GetServiceId());
            api.DeleteJobEmployeeRef(jobId: job.GetClientId());
            foreach(EntityEmployee employee in job.GetEmployees())
            {
                api.InsertJobEmployeeRef(job.GetId(), employee.GetID());
                string SMS = $"Service: {service.GetTitle()}\nClient: {jobClient.GetName()} {jobClient.GetSurname()}\nAddress: {jobClient.GetStreetNumber()} {jobClient.GetStreetName()}";
                sms.SendSMS(SMS, employee.GetPhone());
            }
            api.UpdateJob(job);
        }
    }
}