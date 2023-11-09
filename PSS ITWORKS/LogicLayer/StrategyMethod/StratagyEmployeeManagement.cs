// StrategyUserManager.cs
using PSS_ITWORKS.LogicLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PSS_ITWORKS
{
    public class StratagyEmployeeManagement : IStrategyAManagement
    {
        DatabaseAPI api = new DatabaseAPI();

        public void Connect(string myString)
        {
            api.SetConnection(myString);
        }

        public void Create(IEntity entity)
        {
            EntityEmployee employee = entity as EntityEmployee;
            api.InsertEmployee(employee);
        }

        public void Delete(int ID)
        {
            api.DeleteEmployee(ID);
        }

        public List<IEntity> Get()
        {
            List<IEntity> entities = new List<IEntity>();
            List<EntityEmployee> employees = api.GetEmployees();
            foreach (EntityEmployee employee in employees)
            {
                entities.Add(employee);
            }
            return entities;
        }

        public IEntity Get(int ID)
        {
            ErrorHandler.DisplayError(ID.ToString());
            EntityEmployee employee = api.GetEmployee(ID);
            if(employee != null)
            {
                List<int> jobIds = api.GetJobEmployeeRef(employeeId: ID);
                List<EntityJob> jobs = new List<EntityJob>();
                foreach(int i in jobIds)
                {
                    jobs.Add(api.GetJob(i));
                }
                List<EntityCall> calls = api.GetCalls();
                List<EntityCall> employeeCalls = new List<EntityCall>();
                foreach (EntityCall call in calls)
                {
                    if(call.GetEmployeeId() == ID)
                    {
                        employeeCalls.Add(call);
                    }
                }
                employee.SetJobs(jobs);
                employee.SetCalls(employeeCalls);
            }
            return employee;
        }

        public void Update(IEntity entity)
        {
            EntityEmployee entityEmployee = entity as EntityEmployee;
            api.UpdateEmployee(entityEmployee);
        }
    }
}